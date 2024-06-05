namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaFiltroAluguelForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            rdbAlugueisConcluidos = new RadioButton();
            rdbTodosAlugueis = new RadioButton();
            rdbAlugueisPendentes = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(170, 173);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(106, 35);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(282, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbAlugueisConcluidos);
            groupBox1.Controls.Add(rdbTodosAlugueis);
            groupBox1.Controls.Add(rdbAlugueisPendentes);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 155);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um Filtro:";
            // 
            // rdbAlugueisConcluidos
            // 
            rdbAlugueisConcluidos.AutoSize = true;
            rdbAlugueisConcluidos.Location = new Point(28, 111);
            rdbAlugueisConcluidos.Name = "rdbAlugueisConcluidos";
            rdbAlugueisConcluidos.Size = new Size(161, 24);
            rdbAlugueisConcluidos.TabIndex = 0;
            rdbAlugueisConcluidos.TabStop = true;
            rdbAlugueisConcluidos.Text = "Aluguéis Concluidos";
            rdbAlugueisConcluidos.UseVisualStyleBackColor = true;
            // 
            // rdbTodosAlugueis
            // 
            rdbTodosAlugueis.AutoSize = true;
            rdbTodosAlugueis.Location = new Point(29, 35);
            rdbTodosAlugueis.Name = "rdbTodosAlugueis";
            rdbTodosAlugueis.Size = new Size(147, 24);
            rdbTodosAlugueis.TabIndex = 0;
            rdbTodosAlugueis.TabStop = true;
            rdbTodosAlugueis.Text = "Todos os Aluguéis";
            rdbTodosAlugueis.UseVisualStyleBackColor = true;
            // 
            // rdbAlugueisPendentes
            // 
            rdbAlugueisPendentes.AutoSize = true;
            rdbAlugueisPendentes.Location = new Point(28, 72);
            rdbAlugueisPendentes.Name = "rdbAlugueisPendentes";
            rdbAlugueisPendentes.Size = new Size(155, 24);
            rdbAlugueisPendentes.TabIndex = 0;
            rdbAlugueisPendentes.TabStop = true;
            rdbAlugueisPendentes.Text = "Aluguéis Pendentes";
            rdbAlugueisPendentes.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 220);
            Controls.Add(groupBox1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de Aluguéis";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private RadioButton rdbAlugueisConcluidos;
        private RadioButton rdbAlugueisPendentes;
        private RadioButton rdbTodosAlugueis;
    }
}