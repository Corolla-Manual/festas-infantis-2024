namespace FestasInfantis.WinApp.ModuloDesconto
{
    public class RepositorioDesconto
    {
        private Desconto desconto;

        public RepositorioDesconto()
        {
            desconto = new(0, 0);
        }

        public bool ExisteDesconto()
        {
            return desconto != null;
        }
        public Desconto RetornaDesconto()
        {
            return desconto;
        }
        public void Editar(Desconto novoDesconto)
        {
            desconto = novoDesconto;
        }
    }
}