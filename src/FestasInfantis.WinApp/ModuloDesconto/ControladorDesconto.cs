namespace FestasInfantis.WinApp.ModuloDesconto
{
    public class ControladorDesconto
    {
        private RepositorioDesconto repositorioDesconto;
        public ControladorDesconto(RepositorioDesconto repoDesconto)
        {
            repositorioDesconto = repoDesconto;
        }

        public void ConfigurarDesconto()
        {
            TelaDescontoForm telaDesconto = new TelaDescontoForm();

            telaDesconto.Desconto = repositorioDesconto.RetornaDesconto();

            DialogResult resultado = telaDesconto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Desconto novoDesconto = telaDesconto.Desconto;

            repositorioDesconto.Cadastrar(novoDesconto);

            TelaPrincipalForm.Instancia.AtualizarRodape($"O desconto foi configurado com sucesso!");
        }
    }
}
