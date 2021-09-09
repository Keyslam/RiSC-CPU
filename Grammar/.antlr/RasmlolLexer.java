// Generated from c:\Users\Laptop-Justin\Documents\Stage ISA-Lab\Onderzoek\RiSC-CPU\Grammar\Rasm.g4 by ANTLR 4.8
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class RasmlolLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		KEYWORD=1, SPECIAL_KEYWORD=2, LABEL=3, ARG=4, WORD=5, OCTAL=6, DECIMAL=7, 
		HEXADECIMAL=8, COMMENT=9, NL=10, WS=11;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"KEYWORD", "SPECIAL_KEYWORD", "LABEL", "ARG", "WORD", "OCTAL", "DECIMAL", 
			"HEXADECIMAL", "COMMENT", "NL", "WS"
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


	public RasmlolLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Rasm.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\r\u0089\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2"+
		"\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3"+
		"\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\5\2A\n\2\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3"+
		"\3\3\3\3\3\3\3\5\3N\n\3\3\4\6\4Q\n\4\r\4\16\4R\3\4\3\4\3\5\3\5\3\5\3\5"+
		"\5\5[\n\5\3\6\6\6^\n\6\r\6\16\6_\3\7\3\7\3\7\7\7e\n\7\f\7\16\7h\13\7\3"+
		"\b\5\bk\n\b\3\b\6\bn\n\b\r\b\16\bo\3\t\3\t\3\t\3\t\6\tv\n\t\r\t\16\tw"+
		"\3\n\3\n\7\n|\n\n\f\n\16\n\177\13\n\3\13\5\13\u0082\n\13\3\13\3\13\3\f"+
		"\3\f\3\f\3\f\2\2\r\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r"+
		"\3\2\n\5\2\62;C\\c|\4\2C\\c|\3\2\639\3\2\629\3\2\62;\5\2\62;CHch\4\2\f"+
		"\f\17\17\5\2\13\f\17\17\"\"\2\u009f\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2"+
		"\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23"+
		"\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\3@\3\2\2\2\5M\3\2\2\2\7P\3\2\2\2\t"+
		"Z\3\2\2\2\13]\3\2\2\2\ra\3\2\2\2\17j\3\2\2\2\21q\3\2\2\2\23y\3\2\2\2\25"+
		"\u0081\3\2\2\2\27\u0085\3\2\2\2\31\32\7c\2\2\32\33\7f\2\2\33A\7f\2\2\34"+
		"\35\7c\2\2\35\36\7f\2\2\36\37\7f\2\2\37A\7k\2\2 !\7p\2\2!\"\7c\2\2\"#"+
		"\7p\2\2#A\7f\2\2$%\7n\2\2%&\7w\2\2&A\7k\2\2\'(\7u\2\2(A\7y\2\2)*\7n\2"+
		"\2*A\7y\2\2+,\7d\2\2,-\7g\2\2-A\7s\2\2./\7l\2\2/\60\7c\2\2\60\61\7n\2"+
		"\2\61A\7t\2\2\62\63\7p\2\2\63\64\7q\2\2\64A\7r\2\2\65\66\7j\2\2\66\67"+
		"\7c\2\2\678\7n\2\28A\7v\2\29:\7n\2\2:;\7n\2\2;A\7k\2\2<=\7o\2\2=>\7q\2"+
		"\2>?\7x\2\2?A\7k\2\2@\31\3\2\2\2@\34\3\2\2\2@ \3\2\2\2@$\3\2\2\2@\'\3"+
		"\2\2\2@)\3\2\2\2@+\3\2\2\2@.\3\2\2\2@\62\3\2\2\2@\65\3\2\2\2@9\3\2\2\2"+
		"@<\3\2\2\2A\4\3\2\2\2BC\7\60\2\2CD\7h\2\2DE\7k\2\2EF\7n\2\2FN\7n\2\2G"+
		"H\7\60\2\2HI\7u\2\2IJ\7r\2\2JK\7c\2\2KL\7e\2\2LN\7g\2\2MB\3\2\2\2MG\3"+
		"\2\2\2N\6\3\2\2\2OQ\t\2\2\2PO\3\2\2\2QR\3\2\2\2RP\3\2\2\2RS\3\2\2\2ST"+
		"\3\2\2\2TU\7<\2\2U\b\3\2\2\2V[\5\r\7\2W[\5\17\b\2X[\5\21\t\2Y[\5\13\6"+
		"\2ZV\3\2\2\2ZW\3\2\2\2ZX\3\2\2\2ZY\3\2\2\2[\n\3\2\2\2\\^\t\3\2\2]\\\3"+
		"\2\2\2^_\3\2\2\2_]\3\2\2\2_`\3\2\2\2`\f\3\2\2\2ab\7\62\2\2bf\t\4\2\2c"+
		"e\t\5\2\2dc\3\2\2\2eh\3\2\2\2fd\3\2\2\2fg\3\2\2\2g\16\3\2\2\2hf\3\2\2"+
		"\2ik\7/\2\2ji\3\2\2\2jk\3\2\2\2km\3\2\2\2ln\t\6\2\2ml\3\2\2\2no\3\2\2"+
		"\2om\3\2\2\2op\3\2\2\2p\20\3\2\2\2qr\7\62\2\2rs\7z\2\2su\3\2\2\2tv\t\7"+
		"\2\2ut\3\2\2\2vw\3\2\2\2wu\3\2\2\2wx\3\2\2\2x\22\3\2\2\2y}\7%\2\2z|\n"+
		"\b\2\2{z\3\2\2\2|\177\3\2\2\2}{\3\2\2\2}~\3\2\2\2~\24\3\2\2\2\177}\3\2"+
		"\2\2\u0080\u0082\7\17\2\2\u0081\u0080\3\2\2\2\u0081\u0082\3\2\2\2\u0082"+
		"\u0083\3\2\2\2\u0083\u0084\7\f\2\2\u0084\26\3\2\2\2\u0085\u0086\t\t\2"+
		"\2\u0086\u0087\3\2\2\2\u0087\u0088\b\f\2\2\u0088\30\3\2\2\2\16\2@MRZ_"+
		"fjow}\u0081\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}