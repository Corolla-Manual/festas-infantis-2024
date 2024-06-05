namespace FestasInfantis.WinApp.ModuloDesconto
{
    partial class TelaDescontoForm
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
            groupBox1 = new GroupBox();
            nudPorcentagemMaxima = new NumericUpDown();
            nudPorcentagemUnitaria = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorcentagemMaxima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPorcentagemUnitaria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudPorcentagemMaxima);
            groupBox1.Controls.Add(nudPorcentagemUnitaria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porcentagens de Desconto:";
            // 
            // nudPorcentagemMaxima
            // 
            nudPorcentagemMaxima.DecimalPlaces = 2;
            nudPorcentagemMaxima.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPorcentagemMaxima.Location = new Point(171, 78);
            nudPorcentagemMaxima.Name = "nudPorcentagemMaxima";
            nudPorcentagemMaxima.Size = new Size(66, 23);
            nudPorcentagemMaxima.TabIndex = 2;
            // 
            // nudPorcentagemUnitaria
            // 
            nudPorcentagemUnitaria.DecimalPlaces = 2;
            nudPorcentagemUnitaria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPorcentagemUnitaria.Location = new Point(173, 33);
            nudPorcentagemUnitaria.Name = "nudPorcentagemUnitaria";
            nudPorcentagemUnitaria.Size = new Size(66, 23);
            nudPorcentagemUnitaria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 74);
            label2.MaximumSize = new Size(150, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 1;
            label2.Text = "Máximo de Porcentagem de Desconto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Porcentagem por Aluguel:";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(134, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(215, 150);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaDescontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 187);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDescontoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configuração de Descontos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorcentagemMaxima).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPorcentagemUnitaria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown nudPorcentagemMaxima;
        private NumericUpDown nudPorcentagemUnitaria;
        private Button button1;
        private Button button2;
    }
}