using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    class Program
    {
        static void Main(string[] args)

        {

            long num=1;
            int digitos=0;
            string str;
            while (num != 0)
            {
                Console.WriteLine("Ingrese un numero: ");
                str = Console.ReadLine();
                if(long.TryParse(str, out num))
                    digitos = num.CantidadDeDigitos();
                Console.WriteLine("Numero de          " + digitos.ToString() + " Digitos");
                
            }
            Console.ReadKey();

        }
    }
}
