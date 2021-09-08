using System.IO;
using System;
using Antlr4.Runtime;

namespace Assembler
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				using var streamReader = new StreamReader(args[0]);

                var inputStream = new AntlrInputStream(streamReader);
                var lexer = new rasmLexer(inputStream);
                var tokens = new CommonTokenStream(lexer);
                var parser = new rasmParser(tokens);

                var tree = parser.file();

                Console.WriteLine(tree.ToStringTree(parser));
			}
			catch (Exception e)
			{
                // Can't have errors if you 'try-catch' the entire program
				Console.WriteLine(e.Message);
			}
		}
	}
}
