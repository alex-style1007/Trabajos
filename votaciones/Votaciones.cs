using System;

namespace tutoria
{
    class Program
    {
        static void Main(string[] args)
        {//ingreso de datos
            int a= int.Parse(Console.ReadLine());//votos partido 1
            int B = int.Parse(Console.ReadLine());//votos partido 2
            int blancos = int.Parse(Console.ReadLine());//votos en blanco
            int anulados = int.Parse(Console.ReadLine());//votos anulados
            int n = int.Parse(Console.ReadLine());//total de la poblacion
            double p = int.Parse(Console.ReadLine());//porcentaje mayor de edad

            int abs = (int)(n * p) - (a + B + blancos + anulados);
            bool C1 = anulados <(a+B)*0.3;
            bool C2 = (a * B) > blancos;
            bool C3 =  abs< n;
            if ((C1 || C2) && C3)
            {
                Console.WriteLine("LAS VOTACIONES FUERON EXITOSAS");
                if (a > B) { Console.WriteLine("El partido 1 es el ganador"); 
                }
                else { Console.WriteLine("El partido 2 es el ganador"); }
                
            }
            
        }
    }
}
