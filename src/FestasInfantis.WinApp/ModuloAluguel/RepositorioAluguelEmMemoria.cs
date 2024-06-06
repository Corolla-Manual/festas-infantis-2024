using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguelEmMemoria : RepositorioBaseEmMemoria<Aluguel>, IRepositorioAluguel
    {
        public List<Aluguel> SelecionarAlugueisConcluidos()
        {
            List<Aluguel> alugueisConcluidos = new List<Aluguel>();

            foreach (Aluguel alguel in registros)
            {
                if (alguel.Status == true)
                    alugueisConcluidos.Add(alguel);
            }

            return alugueisConcluidos;
        }

        public List<Aluguel> SelecionarAlugueisPendentes()
        {
            List<Aluguel> alugueisPendentes = new List<Aluguel>();

            foreach (Aluguel alguel in registros)
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
