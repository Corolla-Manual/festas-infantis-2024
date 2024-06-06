using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();

            foreach (Tema t in temas)
            {
                grid.Rows.Add(t.Id, t.Nome, "R$" + t.Valor, t.Itens.Count, t.Alugueis.Count);
            }
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "NItens", HeaderText = "Nº de Itens" },
                new DataGridViewTextBoxColumn { DataPropertyName = "NAlugueis", HeaderText = "Nº de Aluguéis" }
                       };
        }
    }
}
