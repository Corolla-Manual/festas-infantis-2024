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

            Aluguel alguelARemover = new Aluguel();

            foreach (Cliente i in contexto.Clientes)
            {
                foreach (Aluguel a in i.Alugueis)
                {
                    if (aluguel.Id == a.Id)
                        alguelARemover = a;
                }
            }
            Cliente cliente = contexto.Clientes.Find(c => c.Alugueis.Contains(alguelARemover));
            cliente.Alugueis.Remove(alguelARemover);

            foreach (Tema i in contexto.Temas)
            {
                foreach (Aluguel a in i.Alugueis)
                {
                    if (aluguel.Id == a.Id)
                        alguelARemover = a;
                }
            }
            Tema tema = contexto.Temas.Find(c => c.Alugueis.Contains(alguelARemover));
            tema.Alugueis.Remove(alguelARemover);

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
