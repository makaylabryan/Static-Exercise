namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = TempConverter.CelsiusToFahrenheit(45);
            Console.WriteLine($"{fahrenheit} fahrenheit");

            var celsius = TempConverter.FahrenheitToCelsius(89);
            Console.WriteLine($"{celsius} celsius");
            
            
        }
    }
}
