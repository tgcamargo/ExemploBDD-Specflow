Funcionalidade: Calculadora

Esquema do Cenario: Adicição de dois números
	Dado que eu insiro o número <Number1> na calculadora
	E eu também insiro o número <Number2> na calculadora
	Quando eu pressiono adicionar
	Então o resultado mostrado na tela será <Result>

Exemplos: 
	| Number1 | Number2 | Result |
	| 70      | 50      | 120    |
	| -70     | -50     | -120   |
	| 10      | -10     | 0	     |
	| -42     | 13      | -29    |


Esquema do Cenario: Subtração de dois números
	Dado que eu insiro o número <Number1> na calculadora
	E eu também insiro o número <Number2> na calculadora
	Quando eu pressiono subtrair
	Então o resultado mostrado na tela será <Result>

Exemplos: 
	| Number1 | Number2 | Result |
	| -70     | -50     | -20    |
	| 10      | 2       | 8      |
	| 10      | -10     | 20     |
	| -42     | 13      | -55    |

Esquema do Cenario: Multiplicação de dois números
	Dado que eu insiro o número <Number1> na calculadora
	E eu também insiro o número <Number2> na calculadora
	Quando eu pressiono multiplicar
	Então o resultado mostrado na tela será <Result>

Exemplos: 
	| Number1 | Number2 | Result |
	| -1      | -50     | 50     |
	| 0       | 2       | 0      |
	| 10      | 22      | 220    |
	| -42     | 13      | -546   |

Esquema do Cenario: Divisão de dois números
	Dado que eu insiro o número <Number1> na calculadora
	E eu também insiro o número <Number2> na calculadora
	Quando eu pressiono dividir
	Então o resultado mostrado na tela será <Result>

Exemplos: 
	| Number1 | Number2 | Result |
	| -70     | 7       | -10    |
	| 10      | 10      | 1      |
	| 22      | 1       | 22     |
	| 49      | 7       | 7      |

	Esquema do Cenario: exponente de dois numeros
	Dado que eu insiro o número <Number1> na calculadora
	E eu também insiro o número <Number2> na calculadora
	Quando eu pressiono exponente
	Então o resultado mostrado na tela será <Result>
	Exemplos: 
	| Number1 | Number2 | Result |
	| 9		  | 2       | 81     |
	| 2       | 3       | 8      |