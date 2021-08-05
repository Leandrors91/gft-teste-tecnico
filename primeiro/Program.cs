using System;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            int contador = 0;

            if(entrada <= 9999 && entrada >= 1000)
            {
                
                string[] valores = entrada.ToString().Split();

                int primeiro_digito = int.Parse(valores[0]);
                int segundo_digito = int.Parse(valores[1]);
                int terceiro_digito = int.Parse(valores[2]);
                int quarto_digito = int.Parse(valores[3]);

                if(primeiro_digito % 2 == 0)
                {
                    contador++;
                }


                if(segundo_digito % 2 == 0)
                {
                    contador++;
                }


                if(terceiro_digito % 2 == 0)
                {
                    contador++;
                }


                if(quarto_digito % 2 == 0)
                {
                    contador++;
                }
                
                Console.WriteLine(contador);

            }
        }
    }
}
