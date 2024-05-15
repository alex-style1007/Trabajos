using System;

namespace ecuacion_de_segundo_grado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coeficientes de la ecuación cuadrática (ax^2 + bx + c = 0):");

            Console.Write("Coeficiente a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Coeficiente b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Coeficiente c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calculamos el discriminante
            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                // Dos soluciones reales distintas
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Las soluciones reales son: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminante == 0)
            {
                // Una solución real doble
                double x = -b / (2 * a);
                Console.WriteLine($"La solución real doble es: x = {x}");
            }
            else
            {
                // Soluciones complejas
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine($"Las soluciones son complejas: {realPart} + {imaginaryPart}i y {realPart} - {imaginaryPart}i");
            }
        }
    }
}
