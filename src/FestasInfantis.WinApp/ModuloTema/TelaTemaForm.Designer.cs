namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            tabControl1 = new TabControl();
            DadosBasicos = new TabPage();
            txtNome = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SelecaoItens = new TabPage();
            listItens = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            tabControl1.SuspendLayout();
            DadosBasicos.SuspendLayout();
            SelecaoItens.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DadosBasicos);
            tabControl1.Controls.Add(SelecaoItens);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(446, 266);
            tabControl1.TabIndex = 0;
            // 
            // DadosBasicos
            // 
            DadosBasicos.Controls.Add(txtNome);
            DadosBasicos.Controls.Add(txtId);
            DadosBasicos.Controls.Add(label2);
            DadosBasicos.Controls.Add(label1);
            DadosBasicos.Location = new Point(4, 24);
            DadosBasicos.Name = "DadosBasicos";
            DadosBasicos.Padding = new Padding(3);
            DadosBasicos.Size = new Size(438, 238);
            DadosBasicos.TabIndex = 0;
            DadosBasicos.Text = "Dados Básicos";
            DadosBasicos.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(288, 23);
            txtNome.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(69, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 51);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // SelecaoItens
            // 
            SelecaoItens.Controls.Add(listItens);
            SelecaoItens.Location = new Point(4, 24);
            SelecaoItens.Name = "SelecaoItens";
            SelecaoItens.Padding = new Padding(3);
            SelecaoItens.Size = new Size(438, 238);
            SelecaoItens.TabIndex = 1;
            SelecaoItens.Text = "Seleção de Itens";
            SelecaoItens.UseVisualStyleBackColor = true;
            // 
            // listItens
            // 
            listItens.Dock = DockStyle.Fill;
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(3, 3);
            listItens.Name = "listItens";
            listItens.Size = new Size(432, 232);
            listItens.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(298, 284);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(379, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 328);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Tema";
            tabControl1.ResumeLayout(false);
            DadosBasicos.ResumeLayout(false);
            DadosBasicos.PerformLayout();
            SelecaoItens.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage DadosBasicos;
        private TabPage SelecaoItens;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private CheckedListBox listItens;
    }
}