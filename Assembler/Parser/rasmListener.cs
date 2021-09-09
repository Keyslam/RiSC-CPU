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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="RasmParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IRasmListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] RasmParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] RasmParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] RasmParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] RasmParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.labelDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelDef([NotNull] RasmParser.LabelDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.labelDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelDef([NotNull] RasmParser.LabelDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] RasmParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] RasmParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] RasmParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] RasmParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.special_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecial_keyword([NotNull] RasmParser.Special_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.special_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecial_keyword([NotNull] RasmParser.Special_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RasmParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArg([NotNull] RasmParser.ArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RasmParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArg([NotNull] RasmParser.ArgContext context);
}
