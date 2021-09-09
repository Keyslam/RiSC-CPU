//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Rasm.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class RasmLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, LABEL=15, WORD=16, OCTAL=17, 
		DECIMAL=18, HEXADECIMAL=19, COMMENT=20, NL=21, WS=22;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "LABEL", "WORD", "OCTAL", 
		"DECIMAL", "HEXADECIMAL", "COMMENT", "NL", "WS"
	};


	public RasmLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RasmLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'add'", "'addi'", "'nand'", "'lui'", "'sw'", "'lw'", "'beq'", "'jalr'", 
		"'nop'", "'halt'", "'lli'", "'movi'", "'.fill'", "'.space'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "LABEL", "WORD", "OCTAL", "DECIMAL", "HEXADECIMAL", 
		"COMMENT", "NL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Rasm.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static RasmLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x18', '\xA3', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x6', '\x10', 'q', '\n', '\x10', '\r', '\x10', '\xE', '\x10', 
		'r', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x6', '\x11', 'x', 
		'\n', '\x11', '\r', '\x11', '\xE', '\x11', 'y', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\a', '\x12', '\x7F', '\n', '\x12', '\f', '\x12', 
		'\xE', '\x12', '\x82', '\v', '\x12', '\x3', '\x13', '\x5', '\x13', '\x85', 
		'\n', '\x13', '\x3', '\x13', '\x6', '\x13', '\x88', '\n', '\x13', '\r', 
		'\x13', '\xE', '\x13', '\x89', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x6', '\x14', '\x90', '\n', '\x14', '\r', '\x14', '\xE', 
		'\x14', '\x91', '\x3', '\x15', '\x3', '\x15', '\a', '\x15', '\x96', '\n', 
		'\x15', '\f', '\x15', '\xE', '\x15', '\x99', '\v', '\x15', '\x3', '\x16', 
		'\x5', '\x16', '\x9C', '\n', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x2', '\x2', '\x18', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', 
		'\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', 
		'#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', 
		'\x18', '\x3', '\x2', '\n', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', 
		'|', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x3', '\x2', '\x33', '\x39', 
		'\x3', '\x2', '\x32', '\x39', '\x3', '\x2', '\x32', ';', '\x5', '\x2', 
		'\x32', ';', '\x43', 'H', '\x63', 'h', '\x4', '\x2', '\f', '\f', '\xF', 
		'\xF', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\xAA', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x3', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '\x33', '\x3', '\x2', '\x2', '\x2', '\a', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\t', '=', '\x3', '\x2', '\x2', '\x2', '\v', '\x41', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x44', '\x3', '\x2', '\x2', '\x2', 
		'\xF', 'G', '\x3', '\x2', '\x2', '\x2', '\x11', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x13', 'P', '\x3', '\x2', '\x2', '\x2', '\x15', 'T', '\x3', '\x2', 
		'\x2', '\x2', '\x17', 'Y', '\x3', '\x2', '\x2', '\x2', '\x19', ']', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x62', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'h', '\x3', '\x2', '\x2', '\x2', '\x1F', 'p', '\x3', '\x2', '\x2', '\x2', 
		'!', 'w', '\x3', '\x2', '\x2', '\x2', '#', '{', '\x3', '\x2', '\x2', '\x2', 
		'%', '\x84', '\x3', '\x2', '\x2', '\x2', '\'', '\x8B', '\x3', '\x2', '\x2', 
		'\x2', ')', '\x93', '\x3', '\x2', '\x2', '\x2', '+', '\x9B', '\x3', '\x2', 
		'\x2', '\x2', '-', '\x9F', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', 
		'\x63', '\x2', '\x2', '\x30', '\x31', '\a', '\x66', '\x2', '\x2', '\x31', 
		'\x32', '\a', '\x66', '\x2', '\x2', '\x32', '\x4', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\x34', '\a', '\x63', '\x2', '\x2', '\x34', '\x35', '\a', 
		'\x66', '\x2', '\x2', '\x35', '\x36', '\a', '\x66', '\x2', '\x2', '\x36', 
		'\x37', '\a', 'k', '\x2', '\x2', '\x37', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'\x38', '\x39', '\a', 'p', '\x2', '\x2', '\x39', ':', '\a', '\x63', '\x2', 
		'\x2', ':', ';', '\a', 'p', '\x2', '\x2', ';', '<', '\a', '\x66', '\x2', 
		'\x2', '<', '\b', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', 'n', '\x2', 
		'\x2', '>', '?', '\a', 'w', '\x2', '\x2', '?', '@', '\a', 'k', '\x2', 
		'\x2', '@', '\n', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', 'u', 
		'\x2', '\x2', '\x42', '\x43', '\a', 'y', '\x2', '\x2', '\x43', '\f', '\x3', 
		'\x2', '\x2', '\x2', '\x44', '\x45', '\a', 'n', '\x2', '\x2', '\x45', 
		'\x46', '\a', 'y', '\x2', '\x2', '\x46', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'G', 'H', '\a', '\x64', '\x2', '\x2', 'H', 'I', '\a', 'g', '\x2', '\x2', 
		'I', 'J', '\a', 's', '\x2', '\x2', 'J', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'K', 'L', '\a', 'l', '\x2', '\x2', 'L', 'M', '\a', '\x63', '\x2', '\x2', 
		'M', 'N', '\a', 'n', '\x2', '\x2', 'N', 'O', '\a', 't', '\x2', '\x2', 
		'O', '\x12', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\a', 'p', '\x2', '\x2', 
		'Q', 'R', '\a', 'q', '\x2', '\x2', 'R', 'S', '\a', 'r', '\x2', '\x2', 
		'S', '\x14', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\a', 'j', '\x2', '\x2', 
		'U', 'V', '\a', '\x63', '\x2', '\x2', 'V', 'W', '\a', 'n', '\x2', '\x2', 
		'W', 'X', '\a', 'v', '\x2', '\x2', 'X', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'Y', 'Z', '\a', 'n', '\x2', '\x2', 'Z', '[', '\a', 'n', '\x2', '\x2', 
		'[', '\\', '\a', 'k', '\x2', '\x2', '\\', '\x18', '\x3', '\x2', '\x2', 
		'\x2', ']', '^', '\a', 'o', '\x2', '\x2', '^', '_', '\a', 'q', '\x2', 
		'\x2', '_', '`', '\a', 'x', '\x2', '\x2', '`', '\x61', '\a', 'k', '\x2', 
		'\x2', '\x61', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', 
		'\x30', '\x2', '\x2', '\x63', '\x64', '\a', 'h', '\x2', '\x2', '\x64', 
		'\x65', '\a', 'k', '\x2', '\x2', '\x65', '\x66', '\a', 'n', '\x2', '\x2', 
		'\x66', 'g', '\a', 'n', '\x2', '\x2', 'g', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'i', '\a', '\x30', '\x2', '\x2', 'i', 'j', '\a', 'u', '\x2', 
		'\x2', 'j', 'k', '\a', 'r', '\x2', '\x2', 'k', 'l', '\a', '\x63', '\x2', 
		'\x2', 'l', 'm', '\a', '\x65', '\x2', '\x2', 'm', 'n', '\a', 'g', '\x2', 
		'\x2', 'n', '\x1E', '\x3', '\x2', '\x2', '\x2', 'o', 'q', '\t', '\x2', 
		'\x2', '\x2', 'p', 'o', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\x3', '\x2', 
		'\x2', '\x2', 'r', 'p', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\x3', '\x2', 
		'\x2', '\x2', 's', 't', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', '<', 
		'\x2', '\x2', 'u', ' ', '\x3', '\x2', '\x2', '\x2', 'v', 'x', '\t', '\x3', 
		'\x2', '\x2', 'w', 'v', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\x3', '\x2', 
		'\x2', '\x2', 'y', 'w', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\x3', '\x2', 
		'\x2', '\x2', 'z', '\"', '\x3', '\x2', '\x2', '\x2', '{', '|', '\a', '\x32', 
		'\x2', '\x2', '|', '\x80', '\t', '\x4', '\x2', '\x2', '}', '\x7F', '\t', 
		'\x5', '\x2', '\x2', '~', '}', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x82', 
		'\x3', '\x2', '\x2', '\x2', '\x80', '~', '\x3', '\x2', '\x2', '\x2', '\x80', 
		'\x81', '\x3', '\x2', '\x2', '\x2', '\x81', '$', '\x3', '\x2', '\x2', 
		'\x2', '\x82', '\x80', '\x3', '\x2', '\x2', '\x2', '\x83', '\x85', '\a', 
		'/', '\x2', '\x2', '\x84', '\x83', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x85', '\x3', '\x2', '\x2', '\x2', '\x85', '\x87', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x88', '\t', '\x6', '\x2', '\x2', '\x87', '\x86', '\x3', 
		'\x2', '\x2', '\x2', '\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x87', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x8A', '&', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8C', '\a', 
		'\x32', '\x2', '\x2', '\x8C', '\x8D', '\a', 'z', '\x2', '\x2', '\x8D', 
		'\x8F', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x90', '\t', '\a', '\x2', 
		'\x2', '\x8F', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x91', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x92', '(', '\x3', '\x2', '\x2', 
		'\x2', '\x93', '\x97', '\a', '%', '\x2', '\x2', '\x94', '\x96', '\n', 
		'\b', '\x2', '\x2', '\x95', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x99', '\x3', '\x2', '\x2', '\x2', '\x97', '\x95', '\x3', '\x2', '\x2', 
		'\x2', '\x97', '\x98', '\x3', '\x2', '\x2', '\x2', '\x98', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x99', '\x97', '\x3', '\x2', '\x2', '\x2', '\x9A', 
		'\x9C', '\a', '\xF', '\x2', '\x2', '\x9B', '\x9A', '\x3', '\x2', '\x2', 
		'\x2', '\x9B', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', 
		'\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', '\f', '\x2', '\x2', '\x9E', 
		',', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\t', '\t', '\x2', '\x2', 
		'\xA0', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA1', '\xA2', '\b', '\x17', 
		'\x2', '\x2', '\xA2', '.', '\x3', '\x2', '\x2', '\x2', '\v', '\x2', 'r', 
		'y', '\x80', '\x84', '\x89', '\x91', '\x97', '\x9B', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
