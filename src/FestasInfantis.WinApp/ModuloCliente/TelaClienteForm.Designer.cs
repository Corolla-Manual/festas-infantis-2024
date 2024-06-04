namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTelefoneCliente = new MaskedTextBox();
            txtTelefone = new Label();
            txtId = new Label();
            txtIdCliente = new TextBox();
            txtNome = new Label();
            txtNomeCliente = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtCpfCliente = new MaskedTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(102, 98);
            txtTelefoneCliente.Mask = "(00) 0 0000-0000";
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(98, 23);
            txtTelefoneCliente.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.AutoSize = true;
            txtTelefone.Location = new Point(42, 98);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(54, 15);
            txtTelefone.TabIndex = 1;
            txtTelefone.Text = "Telefone:";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(76, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(20, 15);
            txtId.TabIndex = 1;
            txtId.Text = "Id:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(102, 40);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(58, 23);
            txtIdCliente.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(53, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(43, 15);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(102, 69);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(274, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(323, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(211, 164);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(106, 35);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(102, 127);
            txtCpfCliente.Mask = "000\\.000\\.000-00";
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(98, 23);
            txtCpfCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 130);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Cpf:";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 211);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpfCliente);
            Controls.Add(txtTelefoneCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtTelefoneCliente;
        private Label txtTelefone;
        private Label txtId;
        private TextBox txtIdCliente;
        private Label txtNome;
        private TextBox txtNomeCliente;
        private Button btnCancelar;
        private Button btnGravar;
        private MaskedTextBox txtCpfCliente;
        private Label label2;
    }
}