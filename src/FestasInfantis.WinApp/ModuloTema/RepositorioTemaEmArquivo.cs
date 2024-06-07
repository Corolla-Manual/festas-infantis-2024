using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Temas.Any())
                contadorId = contexto.Temas.Max(i => i.Id) + 1;
        }

        protected override List<Tema> ObterRegistros()
        {
            return contexto.Temas;
        }
        public override bool Excluir(int id)
        {
            Tema tema = SelecionarPorId(id);

            List<Item> itens = contexto.Itens.FindAll(i => i.Tema == tema.Nome);

            if (itens.Any())
                foreach (Item i in itens)
                {
                    i.Tema = null;
                }

            Aluguel aluguelRelacionados = contexto.Alugueis.Find(x => x.Tema == tema);
            if (aluguelRelacionados != null)
                aluguelRelacionados.Tema = null;

            return base.Excluir(id);
        }
    }
}
