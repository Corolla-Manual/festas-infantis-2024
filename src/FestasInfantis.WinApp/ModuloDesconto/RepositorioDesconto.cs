using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloDesconto
{
    public class RepositorioDesconto
    {
        private Desconto desconto;
        private ContextoDados contextoDados;

        public RepositorioDesconto(ContextoDados contexto)
        {
            desconto = contexto.Desconto;
            contextoDados = contexto;
        }

        public bool ExisteDesconto()
        {
            return desconto != null;
        }
        public Desconto RetornaDesconto()
        {
            return desconto;
        }
        public void Cadastrar(Desconto descontoNovo)
        {
            desconto.AtualizarRegistro(descontoNovo);

            contextoDados.Gravar();
        }

    }
}