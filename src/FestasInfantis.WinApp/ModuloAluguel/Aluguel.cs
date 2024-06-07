using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public bool Status { get; set; }
        public Pagamento Pagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public Festa Festa { get; set; }
        public DateTime DataPagamento { get; set; }
        public List<Item> Itens { get; set; }

        public Aluguel(Pagamento pagamento, Cliente cliente, Tema tema, Festa festa)
        {
            Status = false;
            Pagamento = pagamento;
            Cliente = cliente;
            Tema = tema;
            Festa = festa;
            Itens = tema.Itens;
        }
        public Aluguel()
        {

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel a = (Aluguel)novoRegistro;

            Status = a.Status;
            Pagamento = a.Pagamento;
            Cliente = a.Cliente;
            Tema = a.Tema;
            Festa = a.Festa;
            DataPagamento = a.DataPagamento;
            Itens = a.Itens;
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
