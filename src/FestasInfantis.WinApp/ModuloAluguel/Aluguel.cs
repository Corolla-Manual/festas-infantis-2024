using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public bool Status {  get; set; }
        public double PorcentagemEntrada { get; set; }
        public double PorcentagemDesconto { get; set; }
        public DateTime DataPagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        //public Festa Festa { get; set; }

        public Aluguel(bool status, double porcentagemEntrada, double porcentagemDesconto, DateTime dataPagamento, Cliente cliente, Tema tema)
        {
            status = Status;
            porcentagemEntrada = PorcentagemEntrada;
            porcentagemDesconto = PorcentagemDesconto;
            dataPagamento = DataPagamento;
            cliente = Cliente;
            tema = Tema;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel a = (Aluguel)novoRegistro;

            Status = a.Status;
            PorcentagemEntrada = a.PorcentagemEntrada;
            PorcentagemDesconto = a.PorcentagemDesconto;
            DataPagamento = a.DataPagamento;
            Cliente = a.Cliente;
            Tema = a.Tema;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            return erros;
        }

        public override string ToString()
        {
            return $"Status: {Status}, Porcentagem de Entrada: {PorcentagemEntrada}, Porcentagem de Desconto: {PorcentagemDesconto}," +
                $" Data de pagamento: {DataPagamento}, Clinete: {Cliente}, Tema: {Tema}";
        }
    }
}
