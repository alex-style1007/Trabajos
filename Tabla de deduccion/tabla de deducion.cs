using System;

namespace tabla_salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            //datos a ingresar
            Console.WriteLine("SALARIO MENSUAL:");
            Double SMV = double.Parse(Console.ReadLine());

            Console.Write("Tipo De Contrato:");
            Console.Write("INGRESE 1 SI ES DEPENDIENTE Y 2 SI ES INDEPENDIENTE");
            Double TC = double.Parse(Console.ReadLine());

            if (TC == 2)
            {
                Console.Write("Ingrese su tipo de riesgo");
                Double TR = Double.Parse(Console.ReadLine());

                if (TR == 1)
                {
                    Double ARL = ((SMV * 0.4) * (0.00522));
                    Double Pension = ((SMV * 0.04) * (0.16));
                    Double Salud = ((SMV * 0.04) * (0.125));
                    Double SR = SMV - (Salud + Pension + ARL);
                    Double SA = SR * 12;
                    Console.Write("Salario Real:" + SR);
                    Console.Write("Salario Anual:" + SA);
                }
                else if (TR == 2)
                {
                    Double ARL = ((SMV * 0.4) * (0.01044));
                    Double Pension = ((SMV * 0.04) * (0.16));
                    Double Salud = ((SMV * 0.04) * (0.125));
                    Double SR = SMV - (Salud + Pension + ARL);
                    Double SA = SR * 12;
                    Console.Write("Salario Real:" + SR);
                    Console.Write("Salario Anual:" + SA);



                }
                else if (TR == 3)
                {
                    Double ARL = ((SMV * 0.4) * (0.02436));
                    Double Pension = ((SMV * 0.04) * (0.16));
                    Double Salud = ((SMV * 0.04) * (0.125));
                    Double SR = SMV - (Salud + Pension + ARL);
                    Double SA = SR * 12;
                    Console.Write("Salario Real:" + SR);
                    Console.Write("Salario Anual:" + SA);



                }
                else if (TR == 4)
                {
                    Double ARL = ((SMV * 0.4) * (0.04350));
                    Double Pension = ((SMV * 0.04) * (0.16));
                    Double Salud = ((SMV * 0.04) * (0.125));
                    Double SR = SMV - (Salud + Pension + ARL);
                    Double SA = SR * 12;
                    Console.Write("Salario Real:" + SR);
                    Console.Write("Salario Anual:" + SA);



                }
                else if (TR == 5)
                {
                    Double ARL = ((SMV * 0.4) * (0.06960));
                    Double Pension = ((SMV * 0.04) * (0.16));
                    Double Salud = ((SMV * 0.04) * (0.125));
                    Double SR = SMV - (Salud + Pension + ARL);
                    Double SA = SR * 12;
                    Console.Write("Salario Real:" + SR);
                    Console.Write("Salario Anual:" + SA);



                }
            }
            else
            {
                Double ARL = 0;
                Double Pension = ((SMV * 0.04) * (0.04));
                Double Salud = ((SMV * 0.04) * (0.04));
                Double SR = SMV - (Salud + Pension + ARL);
                Double SA = SR * 12;
                Console.Write("Salario Real:" + SR);
                Console.Write("Salario Anual:" + SA);



            }
        }

    }
}