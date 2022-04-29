using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Desenvolver uma calculadora que vai ler um numero, depois vai ler o segundo numero , depois vai ler o operador como resposta e vai responder o resultado da operaçao */

            // ler o primeiro numero
            // ler o segundo numero
            // ler o operador + - * /
            // verificar o tipo do operador
            // realizar a operação conforme o tipo verificado
            // imprimir resultado




            Console.Write("Digite um numero: ");
            double N1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um operador: ");
            string operador = Console.ReadLine();

            Console.Write("Digite outro numero: ");
            double N2 = Convert.ToDouble(Console.ReadLine());

           
            if (operador == "+")
            {
                Console.WriteLine(N1 + N2);
            }
            else if (operador == "-")
            {
                Console.WriteLine(N1 - N2);
            }
            else if (operador == "*")
            {
                Console.WriteLine(N1 * N2);
            }
            else if (operador == "/")
            {
                Console.WriteLine(N1 / N2);
            }
            else
            {
                //se o operador e invalido digite ("erro")
                Console.WriteLine("erro");
            }
        }
           


















   
            
    }
}
