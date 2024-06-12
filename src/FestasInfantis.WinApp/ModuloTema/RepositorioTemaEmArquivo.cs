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

            List<Item> itens = new List<Item>();
            foreach (Item i in contexto.Itens)
            {
                foreach (Item it in tema.Itens)
                {
                    if (i.Id == it.Id)
                        itens.Add(it);
                }
            }

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

        public void AdicionarDependencia(Aluguel novoAluguel)
        {
            Tema tema = contexto.Temas.Find(i => i == novoAluguel.Tema);
            tema.Alugueis.Add(novoAluguel);
        }

        public void AtualizarDependencia(Aluguel aluguelSelecionado, Aluguel aluguelEditado)
        {
            Aluguel aluguelARemover = new Aluguel();

            foreach (Tema i in contexto.Temas)
            {
                foreach (Aluguel a in i.Alugueis)
                {
                    if (aluguelSelecionado.Tema.Nome == a.Tema.Nome)
                        aluguelARemover = a;
                    break;
                }
                if (aluguelARemover.Tema != null)
                    break;
            }

            Tema tema = contexto.Temas.Find(c => c.Alugueis.Contains(aluguelARemover));
            if (tema != null)
                tema.Alugueis.Remove(aluguelARemover);

            tema = contexto.Temas.Find(i => i == aluguelEditado.Tema);
            tema.Alugueis.Add(aluguelEditado);
        }
    }
}
