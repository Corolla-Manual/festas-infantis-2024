using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
                grid.Rows.Add(
                    aluguel.Id, aluguel.Cliente, aluguel.Tema,
                    aluguel.Pagamento.PorcentagemEntrada + "%", aluguel.Pagamento.PorcentagemDesconto + "%",
                    aluguel.Status ? "Concluído" : "Em Aberto",
                    aluguel.DataPagamento == DateTime.MinValue ? "" : aluguel.DataPagamento.ToShortDateString()
                    );
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Porcentagem de Entrada", HeaderText = "Porcentagem de Entrada" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Porcentagem de Desconto", HeaderText = "Porcentagem de Desconto" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data de Pagamento", HeaderText = "Data de Pagamento" },

                //new DataGridViewTextBoxColumn { DataPropertyName = "Festa", HeaderText = "Festa" },
                        };
        }
    }
}
