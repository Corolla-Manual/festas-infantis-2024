using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    internal class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Alugueis.Any())
                contadorId = contexto.Alugueis.Max(i => i.Id) + 1;
        }
        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.Alugueis;
        }
        public override bool Excluir(int id)
        {
            Aluguel aluguel = SelecionarPorId(id);

            Cliente clienteRelacionados = contexto.Clientes.Find(x => x.Alugueis.Contains(aluguel));
            clienteRelacionados.Alugueis.Remove(aluguel);

            Tema temaRelacionado = contexto.Temas.Find(x => x.Alugueis.Contains(aluguel));
            temaRelacionado.Alugueis.Remove(aluguel);

            return base.Excluir(id);
        }
        public List<Aluguel> SelecionarAlugueisConcluidos()
        {
            List<Aluguel> alugueisConcluidos = new List<Aluguel>();

            foreach (Aluguel alguel in contexto.Alugueis)
            {
                if (alguel.Status == true)
                    alugueisConcluidos.Add(alguel);
            }

            return alugueisConcluidos;
        }

        public List<Aluguel> SelecionarAlugueisPendentes()
        {
            List<Aluguel> alugueisPendentes = new List<Aluguel>();

            foreach (Aluguel alguel in contexto.Alugueis)
            {
                if (alguel.Status == false)
                    alugueisPendentes.Add(alguel);
            }

            return alugueisPendentes;
        }

        public void AdicionarAluguelNasDependencias(Aluguel aluguel)
        {
            aluguel.Cliente.Alugueis.Add(aluguel);
            aluguel.Tema.Alugueis.Add(aluguel);
        }
        public void RemoverAluguelNasDependencias(Aluguel aluguel)
        {
            Aluguel aluguelRemover = aluguel;
            foreach (Aluguel a in aluguel.Cliente.Alugueis)
            {
                if (a.Cliente.Nome == aluguel.Cliente.Nome)
                {
                    aluguelRemover = a;
                }
            }
            aluguel.Cliente.Alugueis.Remove(aluguelRemover);

            foreach (Aluguel a in aluguel.Tema.Alugueis)
            {
                if (a.Tema.Nome == aluguel.Tema.Nome)
                {
                    aluguelRemover = a;
                }
            }
            aluguel.Tema.Alugueis.Remove(aluguelRemover);
        }
        public void EditarAluguelNasDependencias(Aluguel aluguelSelecionado, Aluguel aluguelEditado)
        {
            RemoverAluguelNasDependencias(aluguelSelecionado);
            AdicionarAluguelNasDependencias(aluguelEditado);
        }
    }
}
