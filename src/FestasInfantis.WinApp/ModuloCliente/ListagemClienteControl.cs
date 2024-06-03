using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class ListagemClienteControl : UserControl
    {
        public ListagemClienteControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            listClientes.Items.Clear();

            foreach (Cliente cliente in clientes)
                listClientes.Items.Add(cliente);
        }
        public Cliente ObterRegistroSelecionado()
        {
            if (listClientes.SelectedItem == null)
                return null;

            return (Cliente)listClientes.SelectedItem;
        }
    }
}
