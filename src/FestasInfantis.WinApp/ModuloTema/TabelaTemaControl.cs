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
            string itens = "";
            grid.Rows.Clear();

            foreach (Tema t in temas)
            {
                itens = String.Join(", \n", t.Itens);
                grid.Rows.Add(t.Id, t.Nome, "R$" + t.Valor, itens);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" }
                       };
        }
    }
}
