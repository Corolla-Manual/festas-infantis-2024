using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cliente in clientes)
                grid.Rows.Add(cliente.Id, cliente.Nome, cliente.Telefone, cliente.Cpf, cliente.Alugueis.Count);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "Cpf" },
                                new DataGridViewTextBoxColumn { DataPropertyName = "NAlugueis", HeaderText = "Nº de Aluguéis" }
                        };
        }
    }
}
