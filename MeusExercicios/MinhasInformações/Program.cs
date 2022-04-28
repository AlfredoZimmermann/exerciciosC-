using System;

namespace MinhasInformações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = ("Alfredo");
            int idade = 36;
            double peso = 71.7;


            Console.WriteLine("Digite seu nome:");
             nome = Console.ReadLine();

            Console.WriteLine("Qual é sua idade");
            int.TryParse(Console.ReadLine(), out idade);
           
            Console.WriteLine("Qual é seu peso:");
            Double.TryParse(Console.ReadLine(), out peso);




            Console.WriteLine("Seu nome e ");
            Console.WriteLine(nome);

            Console.WriteLine(" Sua idade e ");
            Console.WriteLine(idade);

            Console.WriteLine("Seu peso e ");
            Console.WriteLine(peso);








        }
    }
}
