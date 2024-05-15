using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //INGRESAR NUMERO BINARIO EN DIGITOS SEPARADOS
            Console.WriteLine("ingresar por digito");
            int b0 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int b4 = int.Parse(Console.ReadLine());
            //OPERACION MATEMATICA
            int d0 = (b0 * 16);
            int d1 = (b0 * 8);
            int d2 = (b0 * 4);
            int d3 = (b0 * 2);
            int d4 = (b0 * 1);
            //RESULTADO FINAL
            int DECIMAL = (d0 + d1 + d2 + d3 + d4); Console.WriteLine("LA CONVERSION A DECIMAL ES:" + DECIMAL);
        }
    }
}
