using FestasInfantis.WinApp.ModuloCliente;
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
    public partial class ListagemAluguelControl : UserControl
    {
        public ListagemAluguelControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            listAlugueis.Items.Clear();

            foreach (Aluguel aluguel in alugueis)
                listAlugueis.Items.Add(aluguel);
        }

        public Aluguel ObterRegistroSelecionado()
        {
            if (listAlugueis.SelectedItem == null)
                return null;

            return (Aluguel)listAlugueis.SelectedItem;
        }
    }
}
