using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        double resultado = EjecutarEjercicio();
        Console.WriteLine("resultado: " + resultado);
        ConvertirTemperaturas(resultado);
        ManipularCadenas();
    }

    static double EjecutarEjercicio()
    {
        Console.WriteLine("Introduce el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        int division = numero1 / numero2;
        int modulo = numero1 % numero2; 
        double potencia = Math.Pow(numero1, numero2);

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
        Console.WriteLine("Módulo: " + modulo);
        Console.WriteLine("Potencia: " + potencia);
        double result = suma+resta + multiplicacion;
        return(result);
    }

    static void ConvertirTemperaturas(double result)
    {
        Console.WriteLine("Introduce la temperatura en Celsius:");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            celsius = celsius + result;
            Console.WriteLine("a ceslius se sumo el resultado "+celsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.WriteLine("Kelvin: " + kelvin);
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }
    }

    static void ManipularCadenas()
    {
        Console.WriteLine("Introduce una cadena de texto:");
        string? cadena = Console.ReadLine();

        if (cadena != null)
        {
            Console.WriteLine("Longitud de la cadena: " + cadena.Length);
            Console.WriteLine("En mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("En minúsculas: " + cadena.ToLower());

            Console.WriteLine("Introduce una subcadena para buscar:");
            string? subcadena = Console.ReadLine();

            if (subcadena != null)
            {
                bool contieneSubcadena = cadena.Contains(subcadena);
                Console.WriteLine("¿Contiene la subcadena? " + contieneSubcadena);
            }
            else
            {
                Console.WriteLine("No se introdujo una subcadena válida.");
            }
        }
        else
        {
            Console.WriteLine("No se introdujo una cadena válida.");
        }
    }
}
