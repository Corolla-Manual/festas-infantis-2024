using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public Tema(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
        //public List<Item> Itens { get; set; }
        //public List<Aluguel> Alugueis { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema tema = (Tema)novoRegistro;
            Nome = tema.Nome;
            Valor = tema.Valor;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
