using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("num 1: ");
            int num1 = Int16.Parse(Console.ReadLine());

            Console.WriteLine("num 2: ");
            int num2 = Int32.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("La suma es: {0}", suma);
            //detener push
            Console.ReadLine();
        }
    }
}
