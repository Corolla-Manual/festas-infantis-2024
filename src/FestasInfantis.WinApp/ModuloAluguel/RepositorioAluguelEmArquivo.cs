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

            Cliente clienteRelacionado = contexto.Clientes.Find(x => x.Alugueis.Contains(aluguel));
            if (clienteRelacionado != null)
                clienteRelacionado.Alugueis.Remove(aluguel);

            Tema temaRelacionado = contexto.Temas.Find(x => x.Alugueis.Contains(aluguel));
            if (temaRelacionado != null)
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

    }
}
