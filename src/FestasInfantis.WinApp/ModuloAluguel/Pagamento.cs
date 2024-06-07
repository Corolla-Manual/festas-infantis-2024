namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Pagamento
    {
        public double ValorTotalTema {  get; set; }
        public double ValorTemaDesconto {  get; set; }
        public double ValorPendente { get; set; }
        public int PorcentagemEntrada { get; set; }
        public double PorcentagemDesconto { get; set; }

        public Pagamento(double valorTotaLTema, double valorTemaDesconto,double valorPendente, int porcentagemEntrada, double porcentagemDesconto)
        { 
            ValorTotalTema = valorTotaLTema;
            ValorTemaDesconto = valorTemaDesconto;
            ValorPendente = valorPendente;
            PorcentagemEntrada = porcentagemEntrada;
            PorcentagemDesconto = porcentagemDesconto;
        }
    }
}
