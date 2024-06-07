using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public List<Item> Itens { get; set; }
        public List<Aluguel> Alugueis { get; set; }

        public Tema()
        {

        }
        public Tema(string nome, List<Item> itens)
        {
            Nome = nome;
            Itens = itens;
            Valor = CalcularTotal();
            Alugueis = new List<Aluguel>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema tema = (Tema)novoRegistro;
            Nome = tema.Nome;
            Valor = tema.Valor;
            Itens = tema.Itens;
            Alugueis = tema.Alugueis;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");

            return erros;
        }

        internal double CalcularTotal()
        {
            double valor = 0;
            foreach (Item i in Itens)
            {
                valor += i.Valor;
            }
            return valor;
        }
        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
