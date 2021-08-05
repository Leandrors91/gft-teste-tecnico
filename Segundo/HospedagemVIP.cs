namespace Segundo
{
    public class HospedagemVIP : Hospedagem
    {
        public double Valor_Acrescido { get; set; }

        public HospedagemVIP(double Valor_Acrescido, double Valor)
        {
            this.Valor = Valor;
            this.Valor_Acrescido = Valor_Acrescido;
        }

        public override double print_Valor() {
            return Valor_Acrescido + Valor;
        }
    }
}