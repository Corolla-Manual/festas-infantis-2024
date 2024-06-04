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
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtIdAluguel.Text = value.Id.ToString();
                comboBoxCliente.Text = value.Cliente.ToString();

            }
            get
            {
                return aluguel;
            }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        private void btnGravarAluguel_Click(object sender, EventArgs e)
        {

        }

        private void btnGravarFesta_Click(object sender, EventArgs e)
        {

        }
    }
}
