using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    public class RepositorioItemEmMemoria : RepositorioBaseEmMemoria<Item>, IRepositorioItem
    {
        public void LimparDesmarcados(Tema tema)
        {
            foreach (Item item in registros)
            {
                if (item.Tema == tema)
                {
                    item.Tema = null;
                }

            }
        }
        public void AdicionarDependencia(Tema novoTema)
        {
        }

        public void LimparDesmarcados(string nome)
        {
            throw new NotImplementedException();
        }

        public void AtualizarDependencia(Tema antigoTema, Tema novoTema)
        {
            throw new NotImplementedException();
        }
    }
}
