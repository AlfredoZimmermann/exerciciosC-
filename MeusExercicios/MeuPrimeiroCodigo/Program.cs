﻿using System;

namespace MeuPrimeiroCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3;
            double media;

            Console.WriteLine("Digite a nota 1:");
            Double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Digite a nota 2:");
            Double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("Digite a nota 3:");
            Double.TryParse(Console.ReadLine(), out nota3);

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Sua media :");
            Console.WriteLine(media);

            if(media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }


           
        }
    }
}
