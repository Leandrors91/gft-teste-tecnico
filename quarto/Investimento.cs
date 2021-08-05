namespace quarto
{
    public class Investimento
    {
        public double valorInicial { get; set; }
        public double jurosMensais { get; set; }

        public Investimento(double valorInicial, double jurosMensais)
        {
            this.jurosMensais = jurosMensais;
            this.valorInicial = valorInicial;
        } 

        public virtual double calcularLucro(int meses)
        {
            double retorno = valorInicial * Math.Pow((1 + jurosMensais), meses) - valorInicial;
            return retorno;
        }
    }
}