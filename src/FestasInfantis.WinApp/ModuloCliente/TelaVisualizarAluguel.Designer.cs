namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaVisualizarAluguel
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
            pnlAluguel = new Panel();
            SuspendLayout();
            // 
            // pnlAluguel
            // 
            pnlAluguel.Dock = DockStyle.Fill;
            pnlAluguel.Location = new Point(0, 0);
            pnlAluguel.Name = "pnlAluguel";
            pnlAluguel.Size = new Size(715, 255);
            pnlAluguel.TabIndex = 0;
            // 
            // TelaVisualizarAluguel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 255);
            Controls.Add(pnlAluguel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizarAluguel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualizar Aluguéis";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAluguel;
    }
}