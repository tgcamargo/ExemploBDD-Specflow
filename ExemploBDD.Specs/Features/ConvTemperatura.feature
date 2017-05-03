Funcionalidade: Conversão de Temperaturas em Fahrenheit
	Para facilitar a conversão de temperaturas em Fahrenheit
	Como um usuário de um aplicativo que simplifica isto
	Eu quero os valores convertidos a partir desta medida

Cenário: SimulacaoTemperatura01
	Dado que o valor da temperatura é de 32 graus Fahrenheit
	Quando eu solicitar a conversão desta temperatura
	Então o resultado da conversão para Celsius será de 0 graus
	E o resultado da conversão para Kelvin será de 273,15 graus

Cenário: SimulacaoTemperatura02
	Dado que o valor da temperatura é de 86 graus Fahrenheit
	Quando eu solicitar a conversão desta temperatura
	Então o resultado da conversão para Celsius será de 30 graus
	E o resultado da conversão para Kelvin será de 303,15 graus

Cenário: SimulacaoTemperatura03
	Dado que o valor da temperatura é de 90,5 graus Fahrenheit
	Quando eu solicitar a conversão desta temperatura
	Então o resultado da conversão para Celsius será de 32,5 graus
	E o resultado da conversão para Kelvin será de 305,65 graus

Cenário: SimulacaoTemperatura04
	Dado que o valor da temperatura é de 212 graus Fahrenheit
	Quando eu solicitar a conversão desta temperatura
	Então o resultado da conversão para Celsius será de 100 graus
	E o resultado da conversão para Kelvin será de 373,15 graus
