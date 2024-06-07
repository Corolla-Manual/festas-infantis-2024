namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaConclusaoAluguelForm
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
            label1 = new Label();
            button1 = new Button();
            btnConcluirConclusaoAluguel = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            labelTema = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label10 = new Label();
            labelValorPendente = new Label();
            label3 = new Label();
            labelValorTotalTema = new Label();
            labelCliente = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor total do Tema:";
            // 
            // button1
            // 
            button1.Location = new Point(340, 591);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 2;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnConcluirConclusaoAluguel
            // 
            btnConcluirConclusaoAluguel.DialogResult = DialogResult.OK;
            btnConcluirConclusaoAluguel.Location = new Point(244, 591);
            btnConcluirConclusaoAluguel.Name = "btnConcluirConclusaoAluguel";
            btnConcluirConclusaoAluguel.Size = new Size(89, 32);
            btnConcluirConclusaoAluguel.TabIndex = 2;
            btnConcluirConclusaoAluguel.Text = "Concluir";
            btnConcluirConclusaoAluguel.UseVisualStyleBackColor = true;
            btnConcluirConclusaoAluguel.Click += btnConcluirConclusaoAluguel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 87);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "% de Entrada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 48);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 0;
            label5.Text = "Valor Pendente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 87);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 0;
            label6.Text = "% de Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 25);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 0;
            label7.Text = "Cliente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 29);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 0;
            label8.Text = "Tema:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labelCliente);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 111);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(labelTema);
            groupBox2.Location = new Point(3, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 129);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Location = new Point(79, 29);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(38, 15);
            labelTema.TabIndex = 2;
            labelTema.Text = "label2";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(3, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 138);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(labelValorPendente);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(labelValorTotalTema);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(3, 408);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(425, 166);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(132, 87);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 2;
            label10.Text = "label2";
            // 
            // labelValorPendente
            // 
            labelValorPendente.AutoSize = true;
            labelValorPendente.Location = new Point(320, 48);
            labelValorPendente.Name = "labelValorPendente";
            labelValorPendente.Size = new Size(38, 15);
            labelValorPendente.TabIndex = 2;
            labelValorPendente.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 87);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label2";
            // 
            // labelValorTotalTema
            // 
            labelValorTotalTema.AutoSize = true;
            labelValorTotalTema.Location = new Point(132, 48);
            labelValorTotalTema.Name = "labelValorTotalTema";
            labelValorTotalTema.Size = new Size(38, 15);
            labelValorTotalTema.TabIndex = 2;
            labelValorTotalTema.Text = "label2";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(79, 25);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(38, 15);
            labelCliente.TabIndex = 2;
            labelCliente.Text = "label2";
            // 
            // TelaConclusaoAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 635);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnConcluirConclusaoAluguel);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaConclusaoAluguelForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Conclusão de Aluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnConcluirConclusaoAluguel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label labelTema;
        private Label label10;
        private Label labelValorPendente;
        private Label label3;
        private Label labelValorTotalTema;
        private Label labelCliente;
    }
}