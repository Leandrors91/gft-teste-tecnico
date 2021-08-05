namespace quarto
{
    public class InvestimentoSemIR : Investimento
    {
        public override double calcularLucro(int meses)
        {
            if(valorInicial < 1000)
            {
                Console.WriteLine("O valor Inicial não pode ser menor que R$1000");
                retorno = 0;
            }

            return base.calcularLucro(meses);
        }
    }
}