grammar rasm;

file: (line | NL)*; 

statement: KEYWORD (ARG? ARG? ARG?) | (SPECIAL_KEYWORD ARG);
labelDef: LABEL NL? statement+;
line: (statement | labelDef) COMMENT? NL?;

KEYWORD: 'add' | 'addi' | 'nand' | 'lui' | 'sw' | 'lw' | 'beq' | 'jalr' | 'nop' | 'halt' | 'lli' | 'movi';
SPECIAL_KEYWORD: '.fill' | '.space';

LABEL: [a-zA-Z0-9]+':';
ARG: OCTAL | DECIMAL | HEXADECIMAL | WORD;
WORD: [a-zA-Z]+;

OCTAL : '0' [1-7] ([0-7])*;
DECIMAL : ('-')? ([0-9])+;
HEXADECIMAL : '0x' ([a-fA-F0-9])+;

COMMENT:  '#' ~( '\r' | '\n' )*;
NL: '\r'? '\n';
WS: [ \t\n\r] -> skip;