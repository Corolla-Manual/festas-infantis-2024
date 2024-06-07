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
        public override bool Excluir(int id)
        {
            Item item = SelecionarPorId(id);

            Tema temaRelacionados = contexto.Temas.Find(x => x.Itens.Contains(item));
            if (temaRelacionados != null)
                temaRelacionados.Itens.Remove(item);

            return base.Excluir(id);
        }

        public void LimparDesmarcados(string nome)
        {
            foreach (Item item in contexto.Itens)
            {
                if (item.Tema == nome)
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
