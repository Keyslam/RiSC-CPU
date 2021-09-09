using System.Reflection.Emit;
using System.Collections.Generic;
using System.IO;
using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Linq;

namespace Assembler {
	public class Program {
		private class OPCode {
			public enum OPFormat {
				RRR,
				RRI,
				RI,
				RR,
				NON,
				I,
			}

			public OPFormat Format { get; } = default;
			public Func<short, short, short, List<short>> Translate { get; } = null;

			public OPCode(OPFormat format, Func<short, short, short, List<short>> translate) {
				this.Format = format;
				this.Translate = translate;
			}
		}

		private static Dictionary<string, OPCode> opcodes = new();

		private class MyVisitor : RasmBaseListener {
			private class OpDef {
				public OPCode OPCode { get; }
				public List<Func<short>> Args { get; }

				public OpDef(OPCode OPCode, List<Func<short>> args) {
					this.OPCode = OPCode;
					this.Args = args;
				}
			}

			private short currLine;
			private Dictionary<string, short> labelPositions;

			private List<OpDef> opdefs = null;

			public override void EnterFile(RasmParser.FileContext ctx) {
				currLine = 0;
				labelPositions = new Dictionary<string, short>();
				opdefs = new List<OpDef>();
			}

			public override void ExitFile(RasmParser.FileContext ctx) {
				foreach(KeyValuePair<string, short> entry in labelPositions) {
					Console.WriteLine($"{entry.Key}:{entry.Value}");
				}
				
				foreach (var opdef in opdefs) {
					var a = opdef.Args[0]();
					var b = opdef.Args[1]();
					var c = opdef.Args[2]();

					var linesFragment = opdef.OPCode.Translate(a, b, c);

					foreach (var line in linesFragment) {
						string binary = Convert.ToString(line, 2);
						Console.WriteLine(binary);
					}
					
				}

				// var translation = opcode.Translate(collectedArgs[0], collectedArgs[1], collectedArgs[2]);

				// foreach (var byted in translation) {
				// 	string binary = Convert.ToString(byted, 2);
				// 	Console.WriteLine(binary);
				// }
			}

			public override void EnterLine(RasmParser.LineContext ctx) {
			}

			public override void EnterLabelDef(RasmParser.LabelDefContext ctx) {
				labelPositions[ctx.LABEL().GetText().TrimEnd(':')] = currLine;
			}

			public override void EnterStatement(RasmParser.StatementContext ctx) {
				List<Func<short>> collectedArgs = new();
				collectedArgs.Capacity = 3;

				OPCode opcode = null;

				if (ctx.keyword() != null)
					opcode = opcodes[ctx.keyword().GetText()];

				if (ctx.special_keyword() != null)
					opcode = opcodes[ctx.special_keyword().GetText()];

				if (opcode == null)
					throw new Exception("OP code does not exist");

				var args = ctx.arg();
				if (args != null) {
					foreach (var arg in args) {
						if (arg.DECIMAL() != null)
							collectedArgs.Add(() => { return Convert.ToInt16(arg.DECIMAL().GetText(), 10); });

						if (arg.HEXADECIMAL() != null) {
							collectedArgs.Add(() => { return Convert.ToInt16(arg.HEXADECIMAL().GetText(), 16); });
						}

						if (arg.OCTAL() != null)
							collectedArgs.Add(() => { return Convert.ToInt16(arg.OCTAL().GetText(), 8); });

						if (arg.WORD() != null) {
							collectedArgs.Add(() => { return labelPositions[arg.WORD().GetText()]; });
						}
					}
				}

				var argCount = collectedArgs.Count;

				switch (opcode.Format) {
					case OPCode.OPFormat.RRR:
						if (argCount != 3)
							throw new Exception("Expected RRR");
						break;
					case OPCode.OPFormat.RRI:
						if (argCount != 3)
							throw new Exception("Expected RRI");
						break;
					case OPCode.OPFormat.RR:
						if (argCount != 2)
							throw new Exception("Expected RR");
						break;
					case OPCode.OPFormat.RI:
						if (argCount != 2)
							throw new Exception($"Expected RI. {ctx.keyword().GetText()} {argCount}");
						break;
					case OPCode.OPFormat.I:
						if (argCount != 1)
							throw new Exception("Expected I");
						break;
					case OPCode.OPFormat.NON:
						if (argCount != 0)
							throw new Exception("Expected NON");
						break;
				}

				while (collectedArgs.Count < 3)
					collectedArgs.Add(() => { return 0; });

				currLine += 1;
				if (ctx.keyword() != null && ctx.keyword().GetText() == "movi")
					currLine += 1;
				if (ctx.special_keyword() != null && ctx.special_keyword().GetText() == ".space")
					currLine += collectedArgs[0]();

				opdefs.Add(new OpDef(opcode, collectedArgs));
			}
		}

		private static short BuildRRR(short op, short a, short b, short c) {
			return (short)((op << 13) | (short)((a & 0b111) << 10) | ((b & 0b111) << 7) | (c & 0b111));
		}

		private static short BuildRRI(short op, short a, short b, short i) {
			return (short)((op << 13) | ((a & 0b111) << 10) | ((b & 0b111) << 7) | (i & 0b1111111));
		}

		private static short BuildRI(short op, short a, short i) {
			return (short)((op << 13) | ((a & 0b111) << 10) | (i & 0b1111111111));
		}


		public static void Main(string[] args) {
			// try {
			opcodes.Add("add", new OPCode(OPCode.OPFormat.RRR, (a, b, c) => {
				return new List<short>() {
						BuildRRR(0b000, a, b, c)
					};
			}));

			opcodes.Add("addi", new OPCode(OPCode.OPFormat.RRR, (a, b, c) => {
				return new List<short>() {
						BuildRRI(0b001, a, b, c)
					};
			}));

			opcodes.Add("nand", new OPCode(OPCode.OPFormat.RRI, (a, b, c) => {
				return new List<short>() {
						BuildRRR(0b010, a, b, c)
					};
			}));

			opcodes.Add("lui", new OPCode(OPCode.OPFormat.RI, (a, b, c) => {
				return new List<short>() {
						BuildRI(0b011, a, b)
					};
			}));

			opcodes.Add("sw", new OPCode(OPCode.OPFormat.RRI, (a, b, c) => {
				return new List<short>() {
						BuildRRI(0b100, a, b, c)
					};
			}));

			opcodes.Add("lw", new OPCode(OPCode.OPFormat.RRI, (a, b, c) => {
				return new List<short>() {
						BuildRRI(0b101, a, b, c)
					};
			}));

			opcodes.Add("beq", new OPCode(OPCode.OPFormat.RRI, (a, b, c) => {
				return new List<short>() {
						BuildRRI(0b110, a, b, c)
					};
			}));

			opcodes.Add("jalr", new OPCode(OPCode.OPFormat.RR, (a, b, c) => {
				return new List<short>() {
						BuildRRI(0b111, a, b, 0)
					};
			}));


			opcodes.Add("nop", new OPCode(OPCode.OPFormat.NON, (a, b, c) => {
				return opcodes["add"].Translate(0, 0, 0);
			}));

			opcodes.Add("halt", new OPCode(OPCode.OPFormat.NON, (a, b, c) => {
				return opcodes["jalr"].Translate(0, 0, 1);
			}));

			opcodes.Add("lli", new OPCode(OPCode.OPFormat.RI, (a, b, c) => {
				return opcodes["addi"].Translate(a, a, (short)(b & 0x3f));
			}));

			opcodes.Add("movi", new OPCode(OPCode.OPFormat.RI, (a, b, c) => {
				return
					opcodes["lui"].Translate(a, b, c)
					.Concat(
					opcodes["lli"].Translate(a, b, c))
					.ToList();
			}));

			opcodes.Add(".fill", new OPCode(OPCode.OPFormat.I, (a, b, c) => {
				return new List<short>() {
						a
					};
			}));

			opcodes.Add(".space", new OPCode(OPCode.OPFormat.I, (a, b, c) => {
				return Enumerable.Repeat<short>(0, a).ToList();
			}));

			using var streamReader = new StreamReader(args[0]);

			var inputStream = new AntlrInputStream(streamReader);
			var lexer = new RasmLexer(inputStream);
			var tokens = new CommonTokenStream(lexer);
			var parser = new RasmParser(tokens);

			var tree = parser.file();

			var listener = new MyVisitor();
			ParseTreeWalker.Default.Walk(listener, tree);
			// } catch (Exception e) {
			// 	// Can't have errors if you 'try-catch' the entire program
			// 	Console.WriteLine(e.Message);
			// }
		}
	}
}
