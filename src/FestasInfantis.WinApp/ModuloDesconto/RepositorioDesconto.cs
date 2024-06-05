using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloDesconto
{
    public class RepositorioDesconto : RepositorioBase<Desconto>
    {
        public bool ExisteDesconto()
        {
            return registros.Count > 0;
        }
        public Desconto RetornaDesconto()
        {
            if (!ExisteDesconto())
                return null;
            return registros[0];
        }
    }
}