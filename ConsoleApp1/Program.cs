using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Declarar las variables
            int num1;
            int num2;
            int resSuma;
            int resResta;
            int resMulti;
            int resDiv;
            //2.Pedir datos del usuario
            Console.WriteLine("ingresa el primer numero: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa el segundo numero: ");
            num2=Convert.ToInt32(Console.ReadLine());
            //3.Realizar operaciones
            resSuma = num1 + num2;
            resResta = num1 - num2;
            resMulti = num1 * num2;
            resDiv = num1 / num2;
            //4. Mostrar resultados
            Console.WriteLine("suma: " + resSuma);
            Console.WriteLine("resta: " + resResta);
            Console.WriteLine("multiplicacion: " + resMulti);
            Console.WriteLine("division: " + resDiv);
            Console.ReadLine();


        }
    }
}
