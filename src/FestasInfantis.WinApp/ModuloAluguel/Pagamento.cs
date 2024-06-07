namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Pagamento
    {
        public double ValorTema { get; set; }
        public double ValorTemaDesconto { get; set; }
        public double ValorPendente { get; set; }
        public int PorcentagemEntrada { get; set; }
        public double PorcentagemDesconto { get; set; }
        public double ValorEntrada { get; set; }
        public Pagamento(double valorTema, double valorTemaDesconto, double valorPendente, int porcentagemEntrada, double porcentagemDesconto, double valorEntrada)
        {
            ValorTema = valorTema;
            ValorEntrada = valorEntrada;
            ValorTemaDesconto = valorTemaDesconto;
            ValorPendente = valorPendente;
            PorcentagemEntrada = porcentagemEntrada;
            PorcentagemDesconto = porcentagemDesconto;
        }
    }
}
