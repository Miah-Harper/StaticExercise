using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = TempConverter.FahrenheitToCelcius(78);
            var celsius = TempConverter.CelsiusToFahrenheit(67);

            Console.WriteLine($"It's {fahrenheit} degrees fahrenheit");
            Console.WriteLine($"It's {celsius} degrees celsius");
        }
    }
}

