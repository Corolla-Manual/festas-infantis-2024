using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    public class RepositorioItemEmArquivo : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Itens.Any())
                contadorId = contexto.Itens.Max(i => i.Id) + 1;

        }

        public void AdicionarDependencia(Tema novoTema)
        {
            List<Item> itens = contexto.Itens.FindAll(i => novoTema.Itens.Contains(i));

            foreach (Item i in itens)
            {
                i.Tema = novoTema;
                base.Editar(i.Id, i);
            }
        }
        public void AtualizarDependencia(Tema antigoTema, Tema novoTema)
        {

            List<Item> itensAntigos = contexto.Itens.FindAll(i => i.Tema == antigoTema);

            if (itensAntigos.Any())
                foreach (Item i in itensAntigos)
                {
                    i.Tema = null;
                }

            List<Item> itensNovos = contexto.Itens.FindAll(i => novoTema.Itens.Contains(i));

            foreach (Item i in itensNovos)
            {
                i.Tema = novoTema;
                base.Editar(i.Id, i);
            }
        }

        public override bool Excluir(int id)
        {
            Item item = SelecionarPorId(id);

            Tema temaRelacionados = contexto.Temas.Find(x => x.Itens.Contains(item));
            if (temaRelacionados != null)
                temaRelacionados.Itens.Remove(item);

            return base.Excluir(id);
        }

        public void LimparDesmarcados(Tema tema)
        {
            foreach (Item item in contexto.Itens)
            {
                if (item.Tema == tema)
                {
                    item.Tema = null;
                }

            }
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }
    }
}
