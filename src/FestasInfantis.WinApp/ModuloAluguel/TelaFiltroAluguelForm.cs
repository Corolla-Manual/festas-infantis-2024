using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaFiltroAluguelForm : Form
    {
        public TipoFiltroAluguelEnum FitlroEscolhido { get; private set; }

        public TelaFiltroAluguelForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (rdbTodosAlugueis.Checked)
                FitlroEscolhido = TipoFiltroAluguelEnum.Todos;

            else if (rdbAlugueisConcluidos.Checked)
                FitlroEscolhido = TipoFiltroAluguelEnum.Concluidos;

            else if (rdbAlugueisPendentes.Checked)
                FitlroEscolhido = TipoFiltroAluguelEnum.Pendentes;
        }
    }
}
