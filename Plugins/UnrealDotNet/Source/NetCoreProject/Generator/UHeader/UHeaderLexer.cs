//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from UHeader.g4 by ANTLR 4.7

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class UHeaderLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, PtrQuant=9, 
		RefQuant=10, Private=11, Protected=12, Public=13, Inline=14, Virtual=15, 
		Class=16, Struct=17, Const=18, Static=19, Extern=20, Template=21, BracketsOpen=22, 
		BracketsClose=23, SingleLineDerective=24, MultiLineDerective=25, Identifier=26, 
		Literal=27, Skiped=28, Whitespace=29, Newline=30, BlockComment=31, LineComment=32;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "PtrQuant", 
		"RefQuant", "Private", "Protected", "Public", "Inline", "Virtual", "Class", 
		"Struct", "Const", "Static", "Extern", "Template", "BracketsOpen", "BracketsClose", 
		"SingleLineDerective", "MultiLineDerective", "Identifier", "NONDIGIT", 
		"DIGIT", "Literal", "RealDIGIT", "Schar", "Boolean", "SomeEscapeSequence", 
		"SIGN", "SpecalSymbol", "Skiped", "Whitespace", "Newline", "BlockComment", 
		"LineComment"
	};


	public UHeaderLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public UHeaderLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "':'", "'('", "')'", "','", "'='", "'<'", "'>'", "'*'", "'&'", 
		"'private'", "'protected'", "'public'", "'inline'", "'virtual'", "'class'", 
		"'struct'", "'const'", "'static'", "'extern'", "'template'", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, "PtrQuant", "RefQuant", 
		"Private", "Protected", "Public", "Inline", "Virtual", "Class", "Struct", 
		"Const", "Static", "Extern", "Template", "BracketsOpen", "BracketsClose", 
		"SingleLineDerective", "MultiLineDerective", "Identifier", "Literal", 
		"Skiped", "Whitespace", "Newline", "BlockComment", "LineComment"
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

	public override string GrammarFileName { get { return "UHeader.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static UHeaderLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\"', '\x15A', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', 
		'\x19', '\x6', '\x19', '\xC0', '\n', '\x19', '\r', '\x19', '\xE', '\x19', 
		'\xC1', '\x3', '\x1A', '\x3', '\x1A', '\a', '\x1A', '\xC6', '\n', '\x1A', 
		'\f', '\x1A', '\xE', '\x1A', '\xC9', '\v', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1A', '\x5', '\x1A', '\xCD', '\n', '\x1A', '\x3', '\x1A', '\x6', '\x1A', 
		'\xD0', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xD1', '\x3', '\x1A', 
		'\x6', '\x1A', '\xD5', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xD6', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\a', '\x1B', '\xDC', '\n', 
		'\x1B', '\f', '\x1B', '\xE', '\x1B', '\xDF', '\v', '\x1B', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1E', '\a', '\x1E', '\xE9', '\n', '\x1E', '\f', 
		'\x1E', '\xE', '\x1E', '\xEC', '\v', '\x1E', '\x3', '\x1E', '\x5', '\x1E', 
		'\xEF', '\n', '\x1E', '\x3', '\x1F', '\a', '\x1F', '\xF2', '\n', '\x1F', 
		'\f', '\x1F', '\xE', '\x1F', '\xF5', '\v', '\x1F', '\x3', '\x1F', '\x5', 
		'\x1F', '\xF8', '\n', '\x1F', '\x3', '\x1F', '\x6', '\x1F', '\xFB', '\n', 
		'\x1F', '\r', '\x1F', '\xE', '\x1F', '\xFC', '\x3', '\x1F', '\x5', '\x1F', 
		'\x100', '\n', '\x1F', '\x3', '\x1F', '\x6', '\x1F', '\x103', '\n', '\x1F', 
		'\r', '\x1F', '\xE', '\x1F', '\x104', '\x3', '\x1F', '\x3', '\x1F', '\x5', 
		'\x1F', '\x109', '\n', '\x1F', '\x5', '\x1F', '\x10B', '\n', '\x1F', '\x3', 
		' ', '\x3', ' ', '\x5', ' ', '\x10F', '\n', ' ', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x5', '!', '\x11A', '\n', '!', '\x3', '\"', '\x3', '\"', 
		'\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', 
		'\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x5', '\"', 
		'\x128', '\n', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', 
		'%', '\x3', '%', '\x5', '%', '\x130', '\n', '%', '\x3', '&', '\x6', '&', 
		'\x133', '\n', '&', '\r', '&', '\xE', '&', '\x134', '\x3', '&', '\x3', 
		'&', '\x3', '\'', '\x3', '\'', '\x5', '\'', '\x13B', '\n', '\'', '\x3', 
		'\'', '\x5', '\'', '\x13E', '\n', '\'', '\x3', '\'', '\x3', '\'', '\x3', 
		'(', '\x3', '(', '\x3', '(', '\x3', '(', '\a', '(', '\x146', '\n', '(', 
		'\f', '(', '\xE', '(', '\x149', '\v', '(', '\x3', '(', '\x3', '(', '\x3', 
		'(', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', 
		')', '\a', ')', '\x154', '\n', ')', '\f', ')', '\xE', ')', '\x157', '\v', 
		')', '\x3', ')', '\x3', ')', '\x4', '\xC7', '\x147', '\x2', '*', '\x3', 
		'\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', 
		'\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x2', 
		'\x39', '\x2', ';', '\x1D', '=', '\x2', '?', '\x2', '\x41', '\x2', '\x43', 
		'\x2', '\x45', '\x2', 'G', '\x2', 'I', '\x1E', 'K', '\x1F', 'M', ' ', 
		'O', '!', 'Q', '\"', '\x3', '\x2', '\n', '\x3', '\x2', '\f', '\f', '\x5', 
		'\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x3', '\x2', '\x32', 
		';', '\x6', '\x2', '\f', '\f', '\xF', '\xF', '$', '$', '^', '^', '\x4', 
		'\x2', '-', '-', '/', '/', '\v', '\x2', '\v', '\f', '\xF', '\xF', '\"', 
		'\"', '(', '(', ',', ',', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x4', '\x2', '\f', '\f', '\xF', 
		'\xF', '\x2', '\x16F', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x3', 'S', '\x3', '\x2', '\x2', '\x2', 
		'\x5', 'U', '\x3', '\x2', '\x2', '\x2', '\a', 'W', '\x3', '\x2', '\x2', 
		'\x2', '\t', 'Y', '\x3', '\x2', '\x2', '\x2', '\v', '[', '\x3', '\x2', 
		'\x2', '\x2', '\r', ']', '\x3', '\x2', '\x2', '\x2', '\xF', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x61', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x15', '\x65', '\x3', '\x2', '\x2', 
		'\x2', '\x17', 'g', '\x3', '\x2', '\x2', '\x2', '\x19', 'o', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', 'y', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x80', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '\x87', '\x3', '\x2', '\x2', '\x2', 
		'!', '\x8F', '\x3', '\x2', '\x2', '\x2', '#', '\x95', '\x3', '\x2', '\x2', 
		'\x2', '%', '\x9C', '\x3', '\x2', '\x2', '\x2', '\'', '\xA2', '\x3', '\x2', 
		'\x2', '\x2', ')', '\xA9', '\x3', '\x2', '\x2', '\x2', '+', '\xB0', '\x3', 
		'\x2', '\x2', '\x2', '-', '\xB9', '\x3', '\x2', '\x2', '\x2', '/', '\xBB', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\xBD', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\xC3', '\x3', '\x2', '\x2', '\x2', '\x35', '\xD8', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\xE0', '\x3', '\x2', '\x2', '\x2', '\x39', '\xE2', 
		'\x3', '\x2', '\x2', '\x2', ';', '\xEE', '\x3', '\x2', '\x2', '\x2', '=', 
		'\x10A', '\x3', '\x2', '\x2', '\x2', '?', '\x10E', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\x119', '\x3', '\x2', '\x2', '\x2', '\x43', '\x127', '\x3', 
		'\x2', '\x2', '\x2', '\x45', '\x129', '\x3', '\x2', '\x2', '\x2', 'G', 
		'\x12B', '\x3', '\x2', '\x2', '\x2', 'I', '\x12F', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\x132', '\x3', '\x2', '\x2', '\x2', 'M', '\x13D', '\x3', 
		'\x2', '\x2', '\x2', 'O', '\x141', '\x3', '\x2', '\x2', '\x2', 'Q', '\x14F', 
		'\x3', '\x2', '\x2', '\x2', 'S', 'T', '\a', '=', '\x2', '\x2', 'T', '\x4', 
		'\x3', '\x2', '\x2', '\x2', 'U', 'V', '\a', '<', '\x2', '\x2', 'V', '\x6', 
		'\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', '*', '\x2', '\x2', 'X', '\b', 
		'\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\a', '+', '\x2', '\x2', 'Z', '\n', 
		'\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', '.', '\x2', '\x2', '\\', 
		'\f', '\x3', '\x2', '\x2', '\x2', ']', '^', '\a', '?', '\x2', '\x2', '^', 
		'\xE', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', '>', '\x2', '\x2', 
		'`', '\x10', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', '\a', '@', '\x2', 
		'\x2', '\x62', '\x12', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', 
		',', '\x2', '\x2', '\x64', '\x14', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'\x66', '\a', '(', '\x2', '\x2', '\x66', '\x16', '\x3', '\x2', '\x2', 
		'\x2', 'g', 'h', '\a', 'r', '\x2', '\x2', 'h', 'i', '\a', 't', '\x2', 
		'\x2', 'i', 'j', '\a', 'k', '\x2', '\x2', 'j', 'k', '\a', 'x', '\x2', 
		'\x2', 'k', 'l', '\a', '\x63', '\x2', '\x2', 'l', 'm', '\a', 'v', '\x2', 
		'\x2', 'm', 'n', '\a', 'g', '\x2', '\x2', 'n', '\x18', '\x3', '\x2', '\x2', 
		'\x2', 'o', 'p', '\a', 'r', '\x2', '\x2', 'p', 'q', '\a', 't', '\x2', 
		'\x2', 'q', 'r', '\a', 'q', '\x2', '\x2', 'r', 's', '\a', 'v', '\x2', 
		'\x2', 's', 't', '\a', 'g', '\x2', '\x2', 't', 'u', '\a', '\x65', '\x2', 
		'\x2', 'u', 'v', '\a', 'v', '\x2', '\x2', 'v', 'w', '\a', 'g', '\x2', 
		'\x2', 'w', 'x', '\a', '\x66', '\x2', '\x2', 'x', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', 'y', 'z', '\a', 'r', '\x2', '\x2', 'z', '{', '\a', 'w', 
		'\x2', '\x2', '{', '|', '\a', '\x64', '\x2', '\x2', '|', '}', '\a', 'n', 
		'\x2', '\x2', '}', '~', '\a', 'k', '\x2', '\x2', '~', '\x7F', '\a', '\x65', 
		'\x2', '\x2', '\x7F', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', 
		'\a', 'k', '\x2', '\x2', '\x81', '\x82', '\a', 'p', '\x2', '\x2', '\x82', 
		'\x83', '\a', 'n', '\x2', '\x2', '\x83', '\x84', '\a', 'k', '\x2', '\x2', 
		'\x84', '\x85', '\a', 'p', '\x2', '\x2', '\x85', '\x86', '\a', 'g', '\x2', 
		'\x2', '\x86', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\a', 
		'x', '\x2', '\x2', '\x88', '\x89', '\a', 'k', '\x2', '\x2', '\x89', '\x8A', 
		'\a', 't', '\x2', '\x2', '\x8A', '\x8B', '\a', 'v', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', 'w', '\x2', '\x2', '\x8C', '\x8D', '\a', '\x63', '\x2', 
		'\x2', '\x8D', '\x8E', '\a', 'n', '\x2', '\x2', '\x8E', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x90', '\a', '\x65', '\x2', '\x2', '\x90', '\x91', 
		'\a', 'n', '\x2', '\x2', '\x91', '\x92', '\a', '\x63', '\x2', '\x2', '\x92', 
		'\x93', '\a', 'u', '\x2', '\x2', '\x93', '\x94', '\a', 'u', '\x2', '\x2', 
		'\x94', '\"', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\a', 'u', '\x2', 
		'\x2', '\x96', '\x97', '\a', 'v', '\x2', '\x2', '\x97', '\x98', '\a', 
		't', '\x2', '\x2', '\x98', '\x99', '\a', 'w', '\x2', '\x2', '\x99', '\x9A', 
		'\a', '\x65', '\x2', '\x2', '\x9A', '\x9B', '\a', 'v', '\x2', '\x2', '\x9B', 
		'$', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\a', '\x65', '\x2', 
		'\x2', '\x9D', '\x9E', '\a', 'q', '\x2', '\x2', '\x9E', '\x9F', '\a', 
		'p', '\x2', '\x2', '\x9F', '\xA0', '\a', 'u', '\x2', '\x2', '\xA0', '\xA1', 
		'\a', 'v', '\x2', '\x2', '\xA1', '&', '\x3', '\x2', '\x2', '\x2', '\xA2', 
		'\xA3', '\a', 'u', '\x2', '\x2', '\xA3', '\xA4', '\a', 'v', '\x2', '\x2', 
		'\xA4', '\xA5', '\a', '\x63', '\x2', '\x2', '\xA5', '\xA6', '\a', 'v', 
		'\x2', '\x2', '\xA6', '\xA7', '\a', 'k', '\x2', '\x2', '\xA7', '\xA8', 
		'\a', '\x65', '\x2', '\x2', '\xA8', '(', '\x3', '\x2', '\x2', '\x2', '\xA9', 
		'\xAA', '\a', 'g', '\x2', '\x2', '\xAA', '\xAB', '\a', 'z', '\x2', '\x2', 
		'\xAB', '\xAC', '\a', 'v', '\x2', '\x2', '\xAC', '\xAD', '\a', 'g', '\x2', 
		'\x2', '\xAD', '\xAE', '\a', 't', '\x2', '\x2', '\xAE', '\xAF', '\a', 
		'p', '\x2', '\x2', '\xAF', '*', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', 
		'\a', 'v', '\x2', '\x2', '\xB1', '\xB2', '\a', 'g', '\x2', '\x2', '\xB2', 
		'\xB3', '\a', 'o', '\x2', '\x2', '\xB3', '\xB4', '\a', 'r', '\x2', '\x2', 
		'\xB4', '\xB5', '\a', 'n', '\x2', '\x2', '\xB5', '\xB6', '\a', '\x63', 
		'\x2', '\x2', '\xB6', '\xB7', '\a', 'v', '\x2', '\x2', '\xB7', '\xB8', 
		'\a', 'g', '\x2', '\x2', '\xB8', ',', '\x3', '\x2', '\x2', '\x2', '\xB9', 
		'\xBA', '\a', '}', '\x2', '\x2', '\xBA', '.', '\x3', '\x2', '\x2', '\x2', 
		'\xBB', '\xBC', '\a', '\x7F', '\x2', '\x2', '\xBC', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\xBD', '\xBF', '\a', '%', '\x2', '\x2', '\xBE', '\xC0', 
		'\n', '\x2', '\x2', '\x2', '\xBF', '\xBE', '\x3', '\x2', '\x2', '\x2', 
		'\xC0', '\xC1', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xBF', '\x3', '\x2', 
		'\x2', '\x2', '\xC1', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC2', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\xC3', '\xCF', '\a', '%', '\x2', '\x2', '\xC4', 
		'\xC6', '\n', '\x2', '\x2', '\x2', '\xC5', '\xC4', '\x3', '\x2', '\x2', 
		'\x2', '\xC6', '\xC9', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\x3', 
		'\x2', '\x2', '\x2', '\xC7', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC8', 
		'\xCA', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xC7', '\x3', '\x2', '\x2', 
		'\x2', '\xCA', '\xCC', '\a', '^', '\x2', '\x2', '\xCB', '\xCD', '\a', 
		'\xF', '\x2', '\x2', '\xCC', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCC', 
		'\xCD', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCE', '\x3', '\x2', '\x2', 
		'\x2', '\xCE', '\xD0', '\a', '\f', '\x2', '\x2', '\xCF', '\xC7', '\x3', 
		'\x2', '\x2', '\x2', '\xD0', '\xD1', '\x3', '\x2', '\x2', '\x2', '\xD1', 
		'\xCF', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', '\x3', '\x2', '\x2', 
		'\x2', '\xD2', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD5', '\n', 
		'\x2', '\x2', '\x2', '\xD4', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD5', 
		'\xD6', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD4', '\x3', '\x2', '\x2', 
		'\x2', '\xD6', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xD7', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\xD8', '\xDD', '\x5', '\x37', '\x1C', '\x2', '\xD9', 
		'\xDC', '\x5', '\x37', '\x1C', '\x2', '\xDA', '\xDC', '\x5', '\x39', '\x1D', 
		'\x2', '\xDB', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDA', '\x3', 
		'\x2', '\x2', '\x2', '\xDC', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xDD', 
		'\xDB', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\x3', '\x2', '\x2', 
		'\x2', '\xDE', '\x36', '\x3', '\x2', '\x2', '\x2', '\xDF', '\xDD', '\x3', 
		'\x2', '\x2', '\x2', '\xE0', '\xE1', '\t', '\x3', '\x2', '\x2', '\xE1', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', '\t', '\x4', '\x2', 
		'\x2', '\xE3', ':', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xEF', '\x5', 
		'\x41', '!', '\x2', '\xE5', '\xEF', '\x5', '=', '\x1F', '\x2', '\xE6', 
		'\xEA', '\a', '$', '\x2', '\x2', '\xE7', '\xE9', '\x5', '?', ' ', '\x2', 
		'\xE8', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEC', '\x3', '\x2', 
		'\x2', '\x2', '\xEA', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xEB', 
		'\x3', '\x2', '\x2', '\x2', '\xEB', '\xED', '\x3', '\x2', '\x2', '\x2', 
		'\xEC', '\xEA', '\x3', '\x2', '\x2', '\x2', '\xED', '\xEF', '\a', '$', 
		'\x2', '\x2', '\xEE', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xE5', 
		'\x3', '\x2', '\x2', '\x2', '\xEE', '\xE6', '\x3', '\x2', '\x2', '\x2', 
		'\xEF', '<', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xF2', '\x5', '\x39', 
		'\x1D', '\x2', '\xF1', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF5', 
		'\x3', '\x2', '\x2', '\x2', '\xF3', '\xF1', '\x3', '\x2', '\x2', '\x2', 
		'\xF3', '\xF4', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF7', '\x3', '\x2', 
		'\x2', '\x2', '\xF5', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF6', '\xF8', 
		'\a', '\x30', '\x2', '\x2', '\xF7', '\xF6', '\x3', '\x2', '\x2', '\x2', 
		'\xF7', '\xF8', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xFA', '\x3', '\x2', 
		'\x2', '\x2', '\xF9', '\xFB', '\x5', '\x39', '\x1D', '\x2', '\xFA', '\xF9', 
		'\x3', '\x2', '\x2', '\x2', '\xFB', '\xFC', '\x3', '\x2', '\x2', '\x2', 
		'\xFC', '\xFA', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFD', '\x3', '\x2', 
		'\x2', '\x2', '\xFD', '\xFF', '\x3', '\x2', '\x2', '\x2', '\xFE', '\x100', 
		'\a', 'h', '\x2', '\x2', '\xFF', '\xFE', '\x3', '\x2', '\x2', '\x2', '\xFF', 
		'\x100', '\x3', '\x2', '\x2', '\x2', '\x100', '\x10B', '\x3', '\x2', '\x2', 
		'\x2', '\x101', '\x103', '\x5', '\x39', '\x1D', '\x2', '\x102', '\x101', 
		'\x3', '\x2', '\x2', '\x2', '\x103', '\x104', '\x3', '\x2', '\x2', '\x2', 
		'\x104', '\x102', '\x3', '\x2', '\x2', '\x2', '\x104', '\x105', '\x3', 
		'\x2', '\x2', '\x2', '\x105', '\x106', '\x3', '\x2', '\x2', '\x2', '\x106', 
		'\x108', '\a', '\x30', '\x2', '\x2', '\x107', '\x109', '\a', 'h', '\x2', 
		'\x2', '\x108', '\x107', '\x3', '\x2', '\x2', '\x2', '\x108', '\x109', 
		'\x3', '\x2', '\x2', '\x2', '\x109', '\x10B', '\x3', '\x2', '\x2', '\x2', 
		'\x10A', '\xF3', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x102', '\x3', 
		'\x2', '\x2', '\x2', '\x10B', '>', '\x3', '\x2', '\x2', '\x2', '\x10C', 
		'\x10F', '\n', '\x5', '\x2', '\x2', '\x10D', '\x10F', '\x5', '\x43', '\"', 
		'\x2', '\x10E', '\x10C', '\x3', '\x2', '\x2', '\x2', '\x10E', '\x10D', 
		'\x3', '\x2', '\x2', '\x2', '\x10F', '@', '\x3', '\x2', '\x2', '\x2', 
		'\x110', '\x111', '\a', 'v', '\x2', '\x2', '\x111', '\x112', '\a', 't', 
		'\x2', '\x2', '\x112', '\x113', '\a', 'w', '\x2', '\x2', '\x113', '\x11A', 
		'\a', 'g', '\x2', '\x2', '\x114', '\x115', '\a', 'h', '\x2', '\x2', '\x115', 
		'\x116', '\a', '\x63', '\x2', '\x2', '\x116', '\x117', '\a', 'n', '\x2', 
		'\x2', '\x117', '\x118', '\a', 'u', '\x2', '\x2', '\x118', '\x11A', '\a', 
		'g', '\x2', '\x2', '\x119', '\x110', '\x3', '\x2', '\x2', '\x2', '\x119', 
		'\x114', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x42', '\x3', '\x2', '\x2', 
		'\x2', '\x11B', '\x11C', '\a', '^', '\x2', '\x2', '\x11C', '\x128', '\a', 
		')', '\x2', '\x2', '\x11D', '\x11E', '\a', '^', '\x2', '\x2', '\x11E', 
		'\x128', '\a', '$', '\x2', '\x2', '\x11F', '\x120', '\a', '^', '\x2', 
		'\x2', '\x120', '\x128', '\a', '^', '\x2', '\x2', '\x121', '\x122', '\a', 
		'^', '\x2', '\x2', '\x122', '\x128', '\a', 'p', '\x2', '\x2', '\x123', 
		'\x124', '\a', '^', '\x2', '\x2', '\x124', '\x128', '\a', 't', '\x2', 
		'\x2', '\x125', '\x126', '\a', '^', '\x2', '\x2', '\x126', '\x128', '\a', 
		'v', '\x2', '\x2', '\x127', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x127', 
		'\x11D', '\x3', '\x2', '\x2', '\x2', '\x127', '\x11F', '\x3', '\x2', '\x2', 
		'\x2', '\x127', '\x121', '\x3', '\x2', '\x2', '\x2', '\x127', '\x123', 
		'\x3', '\x2', '\x2', '\x2', '\x127', '\x125', '\x3', '\x2', '\x2', '\x2', 
		'\x128', '\x44', '\x3', '\x2', '\x2', '\x2', '\x129', '\x12A', '\t', '\x6', 
		'\x2', '\x2', '\x12A', '\x46', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12C', 
		'\n', '\a', '\x2', '\x2', '\x12C', 'H', '\x3', '\x2', '\x2', '\x2', '\x12D', 
		'\x130', '\x5', 'G', '$', '\x2', '\x12E', '\x130', '\x5', '\x45', '#', 
		'\x2', '\x12F', '\x12D', '\x3', '\x2', '\x2', '\x2', '\x12F', '\x12E', 
		'\x3', '\x2', '\x2', '\x2', '\x130', 'J', '\x3', '\x2', '\x2', '\x2', 
		'\x131', '\x133', '\t', '\b', '\x2', '\x2', '\x132', '\x131', '\x3', '\x2', 
		'\x2', '\x2', '\x133', '\x134', '\x3', '\x2', '\x2', '\x2', '\x134', '\x132', 
		'\x3', '\x2', '\x2', '\x2', '\x134', '\x135', '\x3', '\x2', '\x2', '\x2', 
		'\x135', '\x136', '\x3', '\x2', '\x2', '\x2', '\x136', '\x137', '\b', 
		'&', '\x2', '\x2', '\x137', 'L', '\x3', '\x2', '\x2', '\x2', '\x138', 
		'\x13A', '\a', '\xF', '\x2', '\x2', '\x139', '\x13B', '\a', '\f', '\x2', 
		'\x2', '\x13A', '\x139', '\x3', '\x2', '\x2', '\x2', '\x13A', '\x13B', 
		'\x3', '\x2', '\x2', '\x2', '\x13B', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'\x13C', '\x13E', '\a', '\f', '\x2', '\x2', '\x13D', '\x138', '\x3', '\x2', 
		'\x2', '\x2', '\x13D', '\x13C', '\x3', '\x2', '\x2', '\x2', '\x13E', '\x13F', 
		'\x3', '\x2', '\x2', '\x2', '\x13F', '\x140', '\b', '\'', '\x2', '\x2', 
		'\x140', 'N', '\x3', '\x2', '\x2', '\x2', '\x141', '\x142', '\a', '\x31', 
		'\x2', '\x2', '\x142', '\x143', '\a', ',', '\x2', '\x2', '\x143', '\x147', 
		'\x3', '\x2', '\x2', '\x2', '\x144', '\x146', '\v', '\x2', '\x2', '\x2', 
		'\x145', '\x144', '\x3', '\x2', '\x2', '\x2', '\x146', '\x149', '\x3', 
		'\x2', '\x2', '\x2', '\x147', '\x148', '\x3', '\x2', '\x2', '\x2', '\x147', 
		'\x145', '\x3', '\x2', '\x2', '\x2', '\x148', '\x14A', '\x3', '\x2', '\x2', 
		'\x2', '\x149', '\x147', '\x3', '\x2', '\x2', '\x2', '\x14A', '\x14B', 
		'\a', ',', '\x2', '\x2', '\x14B', '\x14C', '\a', '\x31', '\x2', '\x2', 
		'\x14C', '\x14D', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14E', '\b', 
		'(', '\x2', '\x2', '\x14E', 'P', '\x3', '\x2', '\x2', '\x2', '\x14F', 
		'\x150', '\a', '\x31', '\x2', '\x2', '\x150', '\x151', '\a', '\x31', '\x2', 
		'\x2', '\x151', '\x155', '\x3', '\x2', '\x2', '\x2', '\x152', '\x154', 
		'\n', '\t', '\x2', '\x2', '\x153', '\x152', '\x3', '\x2', '\x2', '\x2', 
		'\x154', '\x157', '\x3', '\x2', '\x2', '\x2', '\x155', '\x153', '\x3', 
		'\x2', '\x2', '\x2', '\x155', '\x156', '\x3', '\x2', '\x2', '\x2', '\x156', 
		'\x158', '\x3', '\x2', '\x2', '\x2', '\x157', '\x155', '\x3', '\x2', '\x2', 
		'\x2', '\x158', '\x159', '\b', ')', '\x2', '\x2', '\x159', 'R', '\x3', 
		'\x2', '\x2', '\x2', '\x1C', '\x2', '\xC1', '\xC7', '\xCC', '\xD1', '\xD6', 
		'\xDB', '\xDD', '\xEA', '\xEE', '\xF3', '\xF7', '\xFC', '\xFF', '\x104', 
		'\x108', '\x10A', '\x10E', '\x119', '\x127', '\x12F', '\x134', '\x13A', 
		'\x13D', '\x147', '\x155', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}