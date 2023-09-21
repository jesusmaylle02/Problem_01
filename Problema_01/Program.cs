
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el numero 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = Multiply(num1, num2);
            Console.Write("El resultado de la multiplicación es: " + resultado);
            Console.ReadKey();
        }

        static int Multiply(int num1, int num2)
        {
            int resultado = 0;
            bool esNegativo = false;

            if (num2 < 0)
            {
                num2 = -num2;
                esNegativo = true;
            }

            for (int i = 0; i < num2; i++)
            {
                resultado += num1;
            }

            if (esNegativo)
            {
                resultado = -resultado;
            }

            return resultado;
        }
        
    }
}
