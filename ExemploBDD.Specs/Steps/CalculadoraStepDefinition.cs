using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ExemploBDD.Specs.Steps
{
    [Binding]
    public sealed class CalculadoraStepDefinition
    {
        private readonly Calculator _calculator;

        public CalculadoraStepDefinition(Calculator calculator)
        {
            _calculator = calculator;
        }

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"que eu insiro o número (.*) na calculadora")]
        public void DadoQueEuInsiroONumeroNaCalculadora(int firstNumber)
        {
            _calculator.FirstNumber = firstNumber;
        }

        [Given(@"eu também insiro o número (.*) na calculadora")]
        public void DadoEuTambemInsiroONumeroNaCalculadora(int secondNumber)
        {
            _calculator.SecondNumber = secondNumber;
        }
               
        [Then(@"o resultado mostrado na tela será (.*)")]
        public void EntaoOResultadoMostradoNaTelaSera(int expectedResult)
        {
            Assert.AreEqual(expected: expectedResult, actual: _calculator.Result);
        }

        [When(@"eu pressiono adicionar")]
        public void QuandoEuPressionoAdicionar()
        {
            _calculator.Add();
        }

        [When(@"eu pressiono subtrair")]
        public void QuandoEuPressionoSubtrair()
        {
            _calculator.Subtract();
        }

        [When(@"eu pressiono multiplicar")]
        public void QuandoEuPressionoMultiplicar()
        {
            _calculator.Multiply();
        }

        [When(@"eu pressiono dividir")]
        public void QuandoEuPressionoDividir()
        {
            _calculator.Divide();
        }
    }
}
