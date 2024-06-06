using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    public class RepositorioItemEmMemoria : RepositorioBaseEmMemoria<Item>, IRepositorioItem
    {
        public void LimparDesmarcados(string nome)
        {
            foreach (Item item in registros)
            {
                if (item.Tema == nome)
                {
                    item.Tema = null;
                }

            }
        }
    }
}
