using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
             double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
             double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual sera a operação? Mais(+), Menos(-), Vezes(x), Dividir(/)");
             string operacao = Console.ReadLine().ToLower();

            if (operacao == "+")
                {
                double res = n1 + n2;
               
                    Console.WriteLine("Resultado: " + res);

            }
            else if (operacao == "-")
            {
                double res = n1 - n2;
                Console.WriteLine("Resultado: " + res);
            }
            else if(operacao == "x")
            {
                double res = n1 * n2;
                Console.WriteLine("Resultado: " + res);
            }
            else if (operacao == "/")
            {
                double res = n1 / n2;
                Console.WriteLine("Resultado: "+ res);
            }
            else
            {
                Console.WriteLine("Operação invalida");
            }

            Console.ReadKey();

        }
    }
}
