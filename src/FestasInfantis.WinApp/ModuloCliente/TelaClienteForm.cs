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
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public Cliente Cliente
        {
            set
            {
                txtIdCliente.Text = value.Id.ToString();
                txtNomeCliente.Text = value.Nome;
                txtTelefoneCliente.Text = value.Telefone;
                txtCpfCliente.Text =value.Cpf;
            }
            get
            {
                return cliente;
            }
        }

        public TelaClienteForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text;
            string telefone = txtTelefoneCliente.Text;
            string cpf = txtCpfCliente.Text;

            cliente = new Cliente(nome, telefone, cpf);

            List<string> erros = cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
