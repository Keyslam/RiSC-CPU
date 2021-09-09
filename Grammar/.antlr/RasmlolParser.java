// Generated from c:\Users\Laptop-Justin\Documents\Stage ISA-Lab\Onderzoek\RiSC-CPU\Grammar\Rasmlol.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class RasmlolParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		KEYWORD=1, SPECIAL_KEYWORD=2, LABEL=3, ARG=4, WORD=5, OCTAL=6, DECIMAL=7, 
		HEXADECIMAL=8, COMMENT=9, NL=10, WS=11;
	public static final int
		RULE_file = 0, RULE_statement = 1, RULE_labelDef = 2, RULE_line = 3;
	private static String[] makeRuleNames() {
		return new String[] {
			"file", "statement", "labelDef", "line"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "KEYWORD", "SPECIAL_KEYWORD", "LABEL", "ARG", "WORD", "OCTAL", 
			"DECIMAL", "HEXADECIMAL", "COMMENT", "NL", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Rasmlol.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public RasmlolParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class FileContext extends ParserRuleContext {
		public List<LineContext> line() {
			return getRuleContexts(LineContext.class);
		}
		public LineContext line(int i) {
			return getRuleContext(LineContext.class,i);
		}
		public List<TerminalNode> NL() { return getTokens(RasmlolParser.NL); }
		public TerminalNode NL(int i) {
			return getToken(RasmlolParser.NL, i);
		}
		public FileContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_file; }
	}

	public final FileContext file() throws RecognitionException {
		FileContext _localctx = new FileContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(12);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << KEYWORD) | (1L << SPECIAL_KEYWORD) | (1L << LABEL) | (1L << NL))) != 0)) {
				{
				setState(10);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case KEYWORD:
				case SPECIAL_KEYWORD:
				case LABEL:
					{
					setState(8);
					line();
					}
					break;
				case NL:
					{
					setState(9);
					match(NL);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(14);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StatementContext extends ParserRuleContext {
		public TerminalNode KEYWORD() { return getToken(RasmlolParser.KEYWORD, 0); }
		public List<TerminalNode> ARG() { return getTokens(RasmlolParser.ARG); }
		public TerminalNode ARG(int i) {
			return getToken(RasmlolParser.ARG, i);
		}
		public TerminalNode SPECIAL_KEYWORD() { return getToken(RasmlolParser.SPECIAL_KEYWORD, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_statement);
		int _la;
		try {
			setState(27);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case KEYWORD:
				enterOuterAlt(_localctx, 1);
				{
				setState(15);
				match(KEYWORD);
				{
				setState(17);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
				case 1:
					{
					setState(16);
					match(ARG);
					}
					break;
				}
				setState(20);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
				case 1:
					{
					setState(19);
					match(ARG);
					}
					break;
				}
				setState(23);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==ARG) {
					{
					setState(22);
					match(ARG);
					}
				}

				}
				}
				break;
			case SPECIAL_KEYWORD:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(25);
				match(SPECIAL_KEYWORD);
				setState(26);
				match(ARG);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LabelDefContext extends ParserRuleContext {
		public TerminalNode LABEL() { return getToken(RasmlolParser.LABEL, 0); }
		public TerminalNode NL() { return getToken(RasmlolParser.NL, 0); }
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public LabelDefContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelDef; }
	}

	public final LabelDefContext labelDef() throws RecognitionException {
		LabelDefContext _localctx = new LabelDefContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_labelDef);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(29);
			match(LABEL);
			setState(31);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==NL) {
				{
				setState(30);
				match(NL);
				}
			}

			setState(34); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(33);
					statement();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(36); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,7,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LineContext extends ParserRuleContext {
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public LabelDefContext labelDef() {
			return getRuleContext(LabelDefContext.class,0);
		}
		public TerminalNode COMMENT() { return getToken(RasmlolParser.COMMENT, 0); }
		public TerminalNode NL() { return getToken(RasmlolParser.NL, 0); }
		public LineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_line; }
	}

	public final LineContext line() throws RecognitionException {
		LineContext _localctx = new LineContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_line);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(40);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case KEYWORD:
			case SPECIAL_KEYWORD:
				{
				setState(38);
				statement();
				}
				break;
			case LABEL:
				{
				setState(39);
				labelDef();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(43);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==COMMENT) {
				{
				setState(42);
				match(COMMENT);
				}
			}

			setState(46);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				{
				setState(45);
				match(NL);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\r\63\4\2\t\2\4\3"+
		"\t\3\4\4\t\4\4\5\t\5\3\2\3\2\7\2\r\n\2\f\2\16\2\20\13\2\3\3\3\3\5\3\24"+
		"\n\3\3\3\5\3\27\n\3\3\3\5\3\32\n\3\3\3\3\3\5\3\36\n\3\3\4\3\4\5\4\"\n"+
		"\4\3\4\6\4%\n\4\r\4\16\4&\3\5\3\5\5\5+\n\5\3\5\5\5.\n\5\3\5\5\5\61\n\5"+
		"\3\5\2\2\6\2\4\6\b\2\2\29\2\16\3\2\2\2\4\35\3\2\2\2\6\37\3\2\2\2\b*\3"+
		"\2\2\2\n\r\5\b\5\2\13\r\7\f\2\2\f\n\3\2\2\2\f\13\3\2\2\2\r\20\3\2\2\2"+
		"\16\f\3\2\2\2\16\17\3\2\2\2\17\3\3\2\2\2\20\16\3\2\2\2\21\23\7\3\2\2\22"+
		"\24\7\6\2\2\23\22\3\2\2\2\23\24\3\2\2\2\24\26\3\2\2\2\25\27\7\6\2\2\26"+
		"\25\3\2\2\2\26\27\3\2\2\2\27\31\3\2\2\2\30\32\7\6\2\2\31\30\3\2\2\2\31"+
		"\32\3\2\2\2\32\36\3\2\2\2\33\34\7\4\2\2\34\36\7\6\2\2\35\21\3\2\2\2\35"+
		"\33\3\2\2\2\36\5\3\2\2\2\37!\7\5\2\2 \"\7\f\2\2! \3\2\2\2!\"\3\2\2\2\""+
		"$\3\2\2\2#%\5\4\3\2$#\3\2\2\2%&\3\2\2\2&$\3\2\2\2&\'\3\2\2\2\'\7\3\2\2"+
		"\2(+\5\4\3\2)+\5\6\4\2*(\3\2\2\2*)\3\2\2\2+-\3\2\2\2,.\7\13\2\2-,\3\2"+
		"\2\2-.\3\2\2\2.\60\3\2\2\2/\61\7\f\2\2\60/\3\2\2\2\60\61\3\2\2\2\61\t"+
		"\3\2\2\2\r\f\16\23\26\31\35!&*-\60";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}