using System;
using System.Globalization;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
            

        { Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

        Console.WriteLine("Escreva aqui o primeiro lado do triângulo x:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva aqui o segundo lado do triângulo x:");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva aqui o terceiro lado do triângulo x:");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva aqui o primeiro lado do triângulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva aqui o segundo lado do triângulo y:");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva aqui o terceiro lado do triângulo y:");
           y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area_x = x.Area();
            double area_y = y.Area();


            Console.WriteLine(" A área do triângulo x é: " + area_x + " e a área de Y é: " + area_y);

            if (area_x>area_y)
            {
                Console.WriteLine("A área do triângulo X é maior que a do Y.");
            }
            else
            {
                Console.WriteLine("A área do triângulo Y é maior que a do X.");
            }
        }
    }
}
