using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();


            Console.WriteLine("Hola Mundo");
            Console.WriteLine("soy " + Nombre);

            /* La diferencia es que en WriteLine hace un salto de linea mientras que el Write no lo hace. */

            Console.Write("Hola Mundo ");
            Console.Write("soy " + Nombre);
            Console.ReadKey();
        }
    }
}
