using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExemploBDD;

namespace ExemploBDD.Specs
{
    [Binding]
    public sealed class ConvTemperaturaStepDefinition
    {
        private double _temperaturaFahrenheit;
        private double _temperaturaCelsius;
        private double _temperaturaKelvin;

        [Given("que o valor da temperatura é de (.*) graus Fahrenheit")]
        public void CarregarTemperaturaFahrenheit(double temperatura)
        {
            this._temperaturaFahrenheit = temperatura;
        }

        [When("eu solicitar a conversão desta temperatura")]
        public void ProcessarConversaoTemperatura()
        {
            this._temperaturaCelsius = ConversorTemperatura.FahrenheitParaCelsius(this._temperaturaFahrenheit);
            this._temperaturaKelvin = ConversorTemperatura.FahrenheitParaKelvin(this._temperaturaFahrenheit);
        }

        [Then("o resultado da conversão para Celsius será de (.*) graus")]
        public void VerificarTemperaturaCelsius(double temperatura)
        {
            Assert.AreEqual(temperatura, this._temperaturaCelsius);
        }

        [Then("o resultado da conversão para Kelvin será de (.*) graus")]
        public void VerificarTemperaturaKelvin(double temperatura)
        {
            Assert.AreEqual(temperatura, this._temperaturaKelvin);
        }
    }
}