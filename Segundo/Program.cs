using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospedagem hospede_Normal = new Hospedagem(1000);

            HospedagemVIP hospede_Vip = new HospedagemVIP(1000);


            Console.WriteLine("Preco para hospede normal:\t{0}",hospede_Normal.print_Valor());
            Console.WriteLine("Preco para hospede vip:\t{0}",hospede_Vip.print_Valor_Acrescido());
        }
    }
}
