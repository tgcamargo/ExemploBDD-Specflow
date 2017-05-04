# ExemploBDD-Specflow
Solution contendo exemplos da utilização de BDD com Specflow:

- Calculadora simples, utilizando os arquivos "ExemploDBB/Calculator.cs", "ExemploBDD.Specs/Features/Calculadora.feature" e "ExemploBDD.Specs/Steps/CalculadoraStepDefinition.cs":
Os testes estão presentes na feature utilizando os passos que fazem chamada na classe "Calculator.cs".

- Conversor de temperatura simples, utilizando os arquivos "ExemploDBB/ConversorTemperatura.cs", "ExemploBDD.Specs/Features/ConvTemperatura.feature" e "ExemploBDD.Specs/Steps/ConvTemperaturaStepDefinition.cs":
Os testes estão presentes na feature utilizando os passos que fazem chamada na classe "ConversorTemperatura.cs".

- Teste da utilização do Specflow + Selenium, utilizando os arquivos "ExemploBDD.Specs/Features/ExemploBDDSelenium.feature" e  "ExemploBDD.Specs/Steps/ExemploBDDSeleniumStepDefinition.cs":
Os testes estão presentes na feature utilizando os passos que fazem chamada a funcionalidades do Selenium WebDriver.

- Teste de aplicação web utilizando Specflow + Selenium + PageObjects:
A aplicação se encontra no projeto "Calculator" e os testes estão presentes no projeto "Calculator.Tests/Features".
É possivel ver na parte de Steps do projeto que a chamado às funcionalidades do Selenium são realizadas através de PageObjects, deixando as features e steps mais simples.


Os exemplos foram encontrados na comunidade, adaptados e inseridos na mesma solution.
