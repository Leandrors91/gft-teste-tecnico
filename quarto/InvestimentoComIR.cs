namespace quarto
{
    public class InvestimentoComIR : Investimento
    {
        public override double calcularLucro(int meses)
        {
            double desconto = 0;

            if(meses < 6)
            {
                desconto = 22.5 / 100;
                retorno *= desconto;
            }

            else if(meses >= 6 && meses < 12)
            {
                desconto = 20 / 100;
                retorno *= desconto;
            }

            else if(meses >= 12 && meses < 24)
            {
                desconto = 17.5 / 100;
                retorno *= desconto;
            }

            else if(meses >= 24)
            {
                desconto = 15 / 100;
                retorno *= desconto;
            }

            else if(meses >= 6 && meses < 12)
            {
                desconto = 20 / 100;
                retorno *= desconto;
            }
            
            return base.calcularLucro(meses);
        }
    }
}