using System;

namespace ExemploBDD
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return Math.Round((temperatura - 32) / 1.8, 2);
        }

        public static double FahrenheitParaKelvin(double temperatura)
        {
            return FahrenheitParaCelsius(temperatura) + 273.15;
        }
    }
}