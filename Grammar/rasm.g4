grammar Rasm;

file: (line | NL)*; 

statement: keyword (arg? arg? arg?) | (special_keyword arg);
labelDef: LABEL NL? statement+;
line: (statement | labelDef) COMMENT? NL?;

keyword: 'add' | 'addi' | 'nand' | 'lui' | 'sw' | 'lw' | 'beq' | 'jalr' | 'nop' | 'halt' | 'lli' | 'movi';
special_keyword: '.fill' | '.space';

arg: OCTAL | DECIMAL | HEXADECIMAL | WORD;

LABEL: [a-zA-Z0-9]+':';
WORD: [a-zA-Z]+;

OCTAL : '0' [1-7] ([0-7])*;
DECIMAL : ('-')? ([0-9])+;
HEXADECIMAL : '0x' ([a-fA-F0-9])+;

COMMENT:  '#' ~( '\r' | '\n' )*;
NL: '\r'? '\n';
WS: [ \t\n\r] -> skip;