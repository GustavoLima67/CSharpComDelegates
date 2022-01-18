using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        //Delegates serve pra meio que deixar o codigo fechado para alterãções.
        public delegate double MatematicaBinaria(double x, double y);

        public static double Soma(double x, double y)
        {
            double total = x + y;
            Console.WriteLine($"A soma dos numeros [{x}] e [{y}]: são [{total}]");
            return total;
        }

        public static double Sub(double x, double y)
        {
            double total = x - y;
            Console.WriteLine($"A subtração dos numeros [{x}] e [{y}]: são [{total}]");
            return total;
        }

        public static double Mult(double x, double y)
        {
            double total = x * y;
            Console.WriteLine($"A multiplicação dos numeros [{x}] e [{y}]: são [{total}]");
            return total;
        }

        public static double Div(double x, double y)
        {
            double total = x / y;
            Console.WriteLine($"A divisão dos numeros [{x}] e [{y}]: são [{total}]");
            return total;
        }

        static void Main(string[] args)
        {
            MatematicaBinaria mb = new MatematicaBinaria(Soma);
            Console.Write("Digite o primero numero: ");
            double numeros = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: \n");
            mb(numeros, numeros);
        }
    }
}
