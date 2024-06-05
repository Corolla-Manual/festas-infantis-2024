﻿using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase, IControladorFiltravel
    {
        private ListagemAluguelControl listagemAluguel;

        private RepositorioAluguel repositorioAluguel;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(RepositorioAluguel repAluguel)
        {
            repositorioAluguel = repAluguel;
        }

        public override string TipoCadastro { get { return "Aluguéis"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Aluguel";} }

        public override string ToolTipEditar { get { return "Editar um Aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Aluguel existente"; } }

        public string ToolTipFiltrar { get { return "Filtrar Aluguéis"; } }

        public override void Adicionar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel novoAluguel = telaAluguel.Aluguel;

            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoAluguel}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possivel realizar esta ação sem selecionar algo",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            telaAluguel.Aluguel = aluguelSelecionado;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel aluguelEditado = telaAluguel.Aluguel;

            repositorioAluguel.Editar(idSelecionado, aluguelEditado);

            CarregarAlugueis();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{aluguelEditado}\" foi criado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação sem um registro selecionado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{aluguelSelecionado}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioAluguel.Excluir(aluguelSelecionado.Id);

            CarregarAlugueis();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{aluguelSelecionado}\" foi criado com sucesso!");
        }

        public void Filtrar()
        {
            TelaFiltroAluguelForm telaFiltro = new TelaFiltroAluguelForm();

            DialogResult resultado = telaFiltro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            TipoFiltroAluguelEnum filtroSelecionado = telaFiltro.FitlroEscolhido;

            List<Aluguel> alugueisSelecionados;

            if (filtroSelecionado == TipoFiltroAluguelEnum.Concluidos)
                alugueisSelecionados = repositorioAluguel.SelecionarAlugueisConcluidos();
          
            else if (filtroSelecionado == TipoFiltroAluguelEnum.Pendentes)
                alugueisSelecionados = repositorioAluguel.SelecionarAlugueisPendentes();

            else 
                alugueisSelecionados = repositorioAluguel.SelecionarTodos();

            listagemAluguel.AtualizarRegistros(alugueisSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueisSelecionados.Count} registros...");
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);

            return tabelaAluguel;
        }
    }
}