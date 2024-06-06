using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public bool Status { get; set; }
        public double ValorPendente { get; set; }
        public int PorcentagemEntrada { get; set; }
        public double PorcentagemDesconto { get; set; }
        public DateTime DataPagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public Festa Festa { get; set; }

        public Aluguel(int porcentagemEntrada, double porcentagemDesconto, double valorPendente, Cliente cliente, Tema tema, Festa festa)
        {
            Status = false;
            PorcentagemEntrada = porcentagemEntrada;
            PorcentagemDesconto = porcentagemDesconto;
            Cliente = cliente;
            Tema = tema;
            Festa = festa;
            ValorPendente = valorPendente;
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
            Festa = a.Festa;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            return erros;
        }

        public override string ToString()
        {
            return $"Id: {Id}";
        }

    }
}
