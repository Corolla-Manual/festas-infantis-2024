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

            if (repositorioDesconto.ExisteDesconto())
                telaDesconto.Desconto = repositorioDesconto.SelecionarPorId(1);


            DialogResult resultado = telaDesconto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Desconto novoDesconto = telaDesconto.Desconto;

            if (repositorioDesconto.ExisteDesconto())
                repositorioDesconto.Editar(1, novoDesconto);

            repositorioDesconto.Cadastrar(novoDesconto);
            TelaPrincipalForm.Instancia.AtualizarRodape($"O desconto foi configurado com sucesso!");
        }
    }
}
