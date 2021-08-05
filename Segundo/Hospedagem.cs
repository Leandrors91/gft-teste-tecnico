namespace Segundo
{
    public class Hospedagem
    {
        public double Valor { get; set; }

        public Hospedagem(double Valor)
        {
            this.Valor = Valor;
        }

        public virtual double print_Valor()
        {
            return Valor;
        }
    }
}