using System;

namespace terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.WriteLine("Informe a data de hoje (dia/mes/ano): ");

            string[] entrada = Console.ReadLine().Split('/');
            int dia = int.Parse(entrada[0]);
            int mes = int.Parse(entrada[1]);
            int ano = int.Parse(entrada[2]);
            

            if(dia <= 0 || dia > 31)
            {
                Console.WriteLine("O dia precisa estar no intervalo de 1 a 31");
            }

            if(mes <= 0 || mes > 12)
            {
                Console.WriteLine("A data precisa estar no intervalo de 1 a 12");
            }

            if(ano < 2021 || ano > 2021)
            {
                Console.WriteLine("O ano precisa ser 2021");
            }

            if(dia > 0 && dia <= 31 && mes > 0 && mes <= 12 && ano == 2021)
            {
                Console.WriteLine("O ano precisa ser 2021");
            }
        }
    }
}
