//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Ava.Frontend.Generated/DianaScript.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Ava.Frontend {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DianaScriptParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public interface IDianaScriptListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] DianaScriptParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] DianaScriptParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt([NotNull] DianaScriptParser.StmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt([NotNull] DianaScriptParser.StmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewline([NotNull] DianaScriptParser.NewlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewline([NotNull] DianaScriptParser.NewlineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] DianaScriptParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] DianaScriptParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__line_wrap_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__line_wrap_expr([NotNull] DianaScriptParser.Gen__line_wrap_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__line_wrap_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__line_wrap_expr([NotNull] DianaScriptParser.Gen__line_wrap_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__optional_newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__optional_newline([NotNull] DianaScriptParser.Gen__optional_newlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__optional_newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__optional_newline([NotNull] DianaScriptParser.Gen__optional_newlineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__nullable_gen__seplist__L44__name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__nullable_gen__seplist__L44__name([NotNull] DianaScriptParser.Gen__nullable_gen__seplist__L44__nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__nullable_gen__seplist__L44__name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__nullable_gen__seplist__L44__name([NotNull] DianaScriptParser.Gen__nullable_gen__seplist__L44__nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__seplist__L44__name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__seplist__L44__name([NotNull] DianaScriptParser.Gen__seplist__L44__nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__seplist__L44__name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__seplist__L44__name([NotNull] DianaScriptParser.Gen__seplist__L44__nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__optional_gen__blockOf_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__optional_gen__blockOf_else([NotNull] DianaScriptParser.Gen__optional_gen__blockOf_elseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__optional_gen__blockOf_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__optional_gen__blockOf_else([NotNull] DianaScriptParser.Gen__optional_gen__blockOf_elseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__blockOf_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__blockOf_else([NotNull] DianaScriptParser.Gen__blockOf_elseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__blockOf_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__blockOf_else([NotNull] DianaScriptParser.Gen__blockOf_elseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__nullable_gen__list_gen__snd_elif__elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__nullable_gen__list_gen__snd_elif__elifBlock([NotNull] DianaScriptParser.Gen__nullable_gen__list_gen__snd_elif__elifBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__nullable_gen__list_gen__snd_elif__elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__nullable_gen__list_gen__snd_elif__elifBlock([NotNull] DianaScriptParser.Gen__nullable_gen__list_gen__snd_elif__elifBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__list_gen__snd_elif__elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__list_gen__snd_elif__elifBlock([NotNull] DianaScriptParser.Gen__list_gen__snd_elif__elifBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__list_gen__snd_elif__elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__list_gen__snd_elif__elifBlock([NotNull] DianaScriptParser.Gen__list_gen__snd_elif__elifBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__snd_elif__elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__snd_elif__elifBlock([NotNull] DianaScriptParser.Gen__snd_elif__elifBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__snd_elif__elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__snd_elif__elifBlock([NotNull] DianaScriptParser.Gen__snd_elif__elifBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__closelist__L44__pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__closelist__L44__pair([NotNull] DianaScriptParser.Gen__closelist__L44__pairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__closelist__L44__pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__closelist__L44__pair([NotNull] DianaScriptParser.Gen__closelist__L44__pairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen___closelist__L44__pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen___closelist__L44__pair([NotNull] DianaScriptParser.Gen___closelist__L44__pairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen___closelist__L44__pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen___closelist__L44__pair([NotNull] DianaScriptParser.Gen___closelist__L44__pairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__closelist__L44__expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__closelist__L44__expr([NotNull] DianaScriptParser.Gen__closelist__L44__exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__closelist__L44__expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__closelist__L44__expr([NotNull] DianaScriptParser.Gen__closelist__L44__exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen___closelist__L44__expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen___closelist__L44__expr([NotNull] DianaScriptParser.Gen___closelist__L44__exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen___closelist__L44__expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen___closelist__L44__expr([NotNull] DianaScriptParser.Gen___closelist__L44__exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPair([NotNull] DianaScriptParser.PairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPair([NotNull] DianaScriptParser.PairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__line_wrap__L58"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__line_wrap__L58([NotNull] DianaScriptParser.Gen__line_wrap__L58Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__line_wrap__L58"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__line_wrap__L58([NotNull] DianaScriptParser.Gen__line_wrap__L58Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.trailer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrailer([NotNull] DianaScriptParser.TrailerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.trailer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrailer([NotNull] DianaScriptParser.TrailerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.bin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBin([NotNull] DianaScriptParser.BinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.bin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBin([NotNull] DianaScriptParser.BinContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.binseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinseq([NotNull] DianaScriptParser.BinseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.binseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinseq([NotNull] DianaScriptParser.BinseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.ibin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIbin([NotNull] DianaScriptParser.IbinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.ibin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIbin([NotNull] DianaScriptParser.IbinContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.ibinop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIbinop([NotNull] DianaScriptParser.IbinopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.ibinop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIbinop([NotNull] DianaScriptParser.IbinopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.binop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinop([NotNull] DianaScriptParser.BinopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.binop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinop([NotNull] DianaScriptParser.BinopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNot([NotNull] DianaScriptParser.NotContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNot([NotNull] DianaScriptParser.NotContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.and_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd_expr([NotNull] DianaScriptParser.And_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.and_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd_expr([NotNull] DianaScriptParser.And_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.or_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOr_expr([NotNull] DianaScriptParser.Or_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.or_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOr_expr([NotNull] DianaScriptParser.Or_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] DianaScriptParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] DianaScriptParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__filter_stmt__gen__or___L59__newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__filter_stmt__gen__or___L59__newline([NotNull] DianaScriptParser.Gen__filter_stmt__gen__or___L59__newlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__filter_stmt__gen__or___L59__newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__filter_stmt__gen__or___L59__newline([NotNull] DianaScriptParser.Gen__filter_stmt__gen__or___L59__newlineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__or___L59__newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__or___L59__newline([NotNull] DianaScriptParser.Gen__or___L59__newlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__or___L59__newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__or___L59__newline([NotNull] DianaScriptParser.Gen__or___L59__newlineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.lhs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLhs([NotNull] DianaScriptParser.LhsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.lhs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLhs([NotNull] DianaScriptParser.LhsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.do"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDo([NotNull] DianaScriptParser.DoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.do"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDo([NotNull] DianaScriptParser.DoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.then"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThen([NotNull] DianaScriptParser.ThenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.then"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThen([NotNull] DianaScriptParser.ThenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__blockOf_do"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__blockOf_do([NotNull] DianaScriptParser.Gen__blockOf_doContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__blockOf_do"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__blockOf_do([NotNull] DianaScriptParser.Gen__blockOf_doContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] DianaScriptParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] DianaScriptParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElifBlock([NotNull] DianaScriptParser.ElifBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElifBlock([NotNull] DianaScriptParser.ElifBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__blockOf_then"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__blockOf_then([NotNull] DianaScriptParser.Gen__blockOf_thenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__blockOf_then"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__blockOf_then([NotNull] DianaScriptParser.Gen__blockOf_thenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.lhs_seq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLhs_seq([NotNull] DianaScriptParser.Lhs_seqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.lhs_seq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLhs_seq([NotNull] DianaScriptParser.Lhs_seqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] DianaScriptParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] DianaScriptParser.StartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__nullable_gen__seplist_newline__stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__nullable_gen__seplist_newline__stmt([NotNull] DianaScriptParser.Gen__nullable_gen__seplist_newline__stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__nullable_gen__seplist_newline__stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__nullable_gen__seplist_newline__stmt([NotNull] DianaScriptParser.Gen__nullable_gen__seplist_newline__stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DianaScriptParser.gen__seplist_newline__stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__seplist_newline__stmt([NotNull] DianaScriptParser.Gen__seplist_newline__stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DianaScriptParser.gen__seplist_newline__stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__seplist_newline__stmt([NotNull] DianaScriptParser.Gen__seplist_newline__stmtContext context);
}
} // namespace Ava.Frontend
