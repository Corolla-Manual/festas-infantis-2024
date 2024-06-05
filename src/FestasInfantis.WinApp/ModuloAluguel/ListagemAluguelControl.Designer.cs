namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class ListagemAluguelControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            listAlugueis = new ListBox();
            SuspendLayout();
            // 
            // listAlugueis
            // 
            listAlugueis.FormattingEnabled = true;
            listAlugueis.ItemHeight = 15;
            listAlugueis.Location = new Point(0, 0);
            listAlugueis.Name = "listAlugueis";
            listAlugueis.Size = new Size(300, 229);
            listAlugueis.TabIndex = 0;
            // 
            // ListagemAluguelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listAlugueis);
            Name = "ListagemAluguelControl";
            Size = new Size(303, 231);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listAlugueis;
    }
}
