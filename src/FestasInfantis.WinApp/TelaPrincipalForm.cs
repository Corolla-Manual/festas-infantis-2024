using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloDesconto;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloTema.ModuloItens;


namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        ContextoDados contexto;

        IRepositorioItem repositorioItem;
        IRepositorioTema repositorioTema;
        IRepositorioCliente repositorioCliente;
        RepositorioDesconto repositorioDesconto;
        IRepositorioAluguel repositorioAluguel;
        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            contexto = new(carregarDados: true);

            repositorioItem = new RepositorioItemEmArquivo(contexto);
            repositorioTema = new RepositorioTemaEmArquivo(contexto);
            repositorioCliente = new RepositorioClienteEmArquivo(contexto);
            repositorioAluguel = new RepositorioAluguelEmArquivo(contexto);
            repositorioDesconto = new(contexto);

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }

        private void ItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem(repositorioItem);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }

        private void TemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema, repositorioItem);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }

        private void AluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioCliente, repositorioTema, repositorioDesconto);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;
            btnVisualizarAlugueis.Enabled = controladorSelecionado is IControladorAluguelVisualizavel;

            btnConcluirAluguel.Enabled = controladorSelecionado is IControladorConclusaoAluguel;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controladorSelecionado is IControladorAluguelVisualizavel controladorAluguelVisualizavel)
                btnVisualizarAlugueis.ToolTipText = controladorAluguelVisualizavel.ToolTipVisualizarAluguel;

            if (controladorSelecionado is IControladorConclusaoAluguel controladorConclusaoAluguel)
                btnConcluirAluguel.ToolTipText = controladorConclusaoAluguel.ToolTipConclusaoAluguel;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorFiltravel controladorFiltravel)
                controladorFiltravel.Filtrar();
        }

        private void TelaPrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfigurarDescontos_Click(object sender, EventArgs e)
        {
            ControladorDesconto controladorDesconto = new(repositorioDesconto);
            controladorDesconto.ConfigurarDesconto();
        }

        private void btnVisualizarAlugueis_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorAluguelVisualizavel controladorAluguelVisualizavel)
                controladorAluguelVisualizavel.VisualizarAluguel();
        }

        private void btnConcluirAluguel_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorConclusaoAluguel controladorConclusaoAluguel)
                controladorConclusaoAluguel.Concluir();
        }
    }
}
