using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBase<Aluguel>
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
    }
}
