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
            label12 = new Label();
            label9 = new Label();
            lblClienteTelefone = new Label();
            lblClienteCPF = new Label();
            lblClienteNome = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            listItens = new ListBox();
            label11 = new Label();
            lblTemaValor = new Label();
            lblTemaNome = new Label();
            groupBox3 = new GroupBox();
            lblFestaEstado = new Label();
            lblFestaNumero = new Label();
            lblFestaTermino = new Label();
            lblFestaInicio = new Label();
            lblFestaCidade = new Label();
            lblFestaBairro = new Label();
            lblFestaRua = new Label();
            label26 = new Label();
            label24 = new Label();
            label22 = new Label();
            label20 = new Label();
            label18 = new Label();
            label28 = new Label();
            label14 = new Label();
            lblFestaData = new Label();
            label13 = new Label();
            groupBox4 = new GroupBox();
            lblPagamentoValorEntrada = new Label();
            lblPagamentoPorcentagemEntrada = new Label();
            lblPagamentoPendente = new Label();
            lblPagamentoPorcentagemDesconto = new Label();
            lblPagamentoTema = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 35);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 0;
            label1.Text = "Tema com desconto:";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(335, 564);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 2;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnConcluirConclusaoAluguel
            // 
            btnConcluirConclusaoAluguel.DialogResult = DialogResult.OK;
            btnConcluirConclusaoAluguel.Location = new Point(239, 564);
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
            label4.Location = new Point(22, 69);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 0;
            label4.Text = "% de Entrada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 107);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 0;
            label5.Text = "Valor Pendente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 35);
            label6.Name = "label6";
            label6.Size = new Size(100, 17);
            label6.TabIndex = 0;
            label6.Text = "% de Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 25);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 0;
            label7.Text = "Nome:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 29);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 0;
            label8.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblClienteTelefone);
            groupBox1.Controls.Add(lblClienteCPF);
            groupBox1.Controls.Add(lblClienteNome);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Cliente:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(243, 25);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 0;
            label12.Text = "Telefone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 51);
            label9.Name = "label9";
            label9.Size = new Size(32, 17);
            label9.TabIndex = 0;
            label9.Text = "CPF:";
            // 
            // lblClienteTelefone
            // 
            lblClienteTelefone.AutoSize = true;
            lblClienteTelefone.Location = new Point(308, 25);
            lblClienteTelefone.Name = "lblClienteTelefone";
            lblClienteTelefone.Size = new Size(43, 17);
            lblClienteTelefone.TabIndex = 2;
            lblClienteTelefone.Text = "label2";
            // 
            // lblClienteCPF
            // 
            lblClienteCPF.AutoSize = true;
            lblClienteCPF.Location = new Point(74, 51);
            lblClienteCPF.Name = "lblClienteCPF";
            lblClienteCPF.Size = new Size(43, 17);
            lblClienteCPF.TabIndex = 2;
            lblClienteCPF.Text = "label2";
            // 
            // lblClienteNome
            // 
            lblClienteNome.AutoSize = true;
            lblClienteNome.Location = new Point(74, 25);
            lblClienteNome.Name = "lblClienteNome";
            lblClienteNome.Size = new Size(43, 17);
            lblClienteNome.TabIndex = 2;
            lblClienteNome.Text = "label2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(listItens);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lblTemaValor);
            groupBox2.Controls.Add(lblTemaNome);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 134);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações do Tema:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 84);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 4;
            label3.Text = "Itens:";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 17;
            listItens.Location = new Point(74, 56);
            listItens.Name = "listItens";
            listItens.SelectionMode = SelectionMode.None;
            listItens.Size = new Size(319, 72);
            listItens.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(304, 29);
            label11.Name = "label11";
            label11.Size = new Size(41, 17);
            label11.TabIndex = 0;
            label11.Text = "Valor:";
            // 
            // lblTemaValor
            // 
            lblTemaValor.AutoSize = true;
            lblTemaValor.Location = new Point(350, 29);
            lblTemaValor.Name = "lblTemaValor";
            lblTemaValor.Size = new Size(43, 17);
            lblTemaValor.TabIndex = 2;
            lblTemaValor.Text = "label2";
            // 
            // lblTemaNome
            // 
            lblTemaNome.AutoSize = true;
            lblTemaNome.Location = new Point(74, 29);
            lblTemaNome.Name = "lblTemaNome";
            lblTemaNome.Size = new Size(43, 17);
            lblTemaNome.TabIndex = 2;
            lblTemaNome.Text = "label2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblFestaEstado);
            groupBox3.Controls.Add(lblFestaNumero);
            groupBox3.Controls.Add(lblFestaTermino);
            groupBox3.Controls.Add(lblFestaInicio);
            groupBox3.Controls.Add(lblFestaCidade);
            groupBox3.Controls.Add(lblFestaBairro);
            groupBox3.Controls.Add(lblFestaRua);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblFestaData);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 173);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informações da Festa:";
            // 
            // lblFestaEstado
            // 
            lblFestaEstado.AutoSize = true;
            lblFestaEstado.Location = new Point(260, 142);
            lblFestaEstado.Name = "lblFestaEstado";
            lblFestaEstado.Size = new Size(43, 17);
            lblFestaEstado.TabIndex = 9;
            lblFestaEstado.Text = "label3";
            // 
            // lblFestaNumero
            // 
            lblFestaNumero.AutoSize = true;
            lblFestaNumero.Location = new Point(350, 109);
            lblFestaNumero.Name = "lblFestaNumero";
            lblFestaNumero.Size = new Size(43, 17);
            lblFestaNumero.TabIndex = 8;
            lblFestaNumero.Text = "label3";
            // 
            // lblFestaTermino
            // 
            lblFestaTermino.AutoSize = true;
            lblFestaTermino.Location = new Point(350, 36);
            lblFestaTermino.Name = "lblFestaTermino";
            lblFestaTermino.Size = new Size(43, 17);
            lblFestaTermino.TabIndex = 7;
            lblFestaTermino.Text = "label3";
            // 
            // lblFestaInicio
            // 
            lblFestaInicio.AutoSize = true;
            lblFestaInicio.Location = new Point(204, 36);
            lblFestaInicio.Name = "lblFestaInicio";
            lblFestaInicio.Size = new Size(43, 17);
            lblFestaInicio.TabIndex = 6;
            lblFestaInicio.Text = "label3";
            // 
            // lblFestaCidade
            // 
            lblFestaCidade.AutoSize = true;
            lblFestaCidade.Location = new Point(74, 142);
            lblFestaCidade.Name = "lblFestaCidade";
            lblFestaCidade.Size = new Size(43, 17);
            lblFestaCidade.TabIndex = 5;
            lblFestaCidade.Text = "label3";
            // 
            // lblFestaBairro
            // 
            lblFestaBairro.AutoSize = true;
            lblFestaBairro.Location = new Point(74, 109);
            lblFestaBairro.Name = "lblFestaBairro";
            lblFestaBairro.Size = new Size(43, 17);
            lblFestaBairro.TabIndex = 4;
            lblFestaBairro.Text = "label3";
            // 
            // lblFestaRua
            // 
            lblFestaRua.AutoSize = true;
            lblFestaRua.Location = new Point(74, 77);
            lblFestaRua.Name = "lblFestaRua";
            lblFestaRua.Size = new Size(43, 17);
            lblFestaRua.TabIndex = 3;
            lblFestaRua.Text = "label3";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(286, 109);
            label26.Name = "label26";
            label26.Size = new Size(59, 17);
            label26.TabIndex = 0;
            label26.Text = "Número:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(204, 142);
            label24.Name = "label24";
            label24.Size = new Size(51, 17);
            label24.TabIndex = 0;
            label24.Text = "Estado:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(16, 142);
            label22.Name = "label22";
            label22.Size = new Size(52, 17);
            label22.TabIndex = 0;
            label22.Text = "Cidade:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(22, 109);
            label20.Name = "label20";
            label20.Size = new Size(46, 17);
            label20.TabIndex = 0;
            label20.Text = "Bairro:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(35, 77);
            label18.Name = "label18";
            label18.Size = new Size(33, 17);
            label18.TabIndex = 0;
            label18.Text = "Rua:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(287, 36);
            label28.Name = "label28";
            label28.Size = new Size(58, 17);
            label28.TabIndex = 0;
            label28.Text = "Término:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(159, 36);
            label14.Name = "label14";
            label14.Size = new Size(41, 17);
            label14.TabIndex = 0;
            label14.Text = "Início:";
            // 
            // lblFestaData
            // 
            lblFestaData.AutoSize = true;
            lblFestaData.Location = new Point(74, 36);
            lblFestaData.Name = "lblFestaData";
            lblFestaData.Size = new Size(43, 17);
            lblFestaData.TabIndex = 2;
            lblFestaData.Text = "label2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 36);
            label13.Name = "label13";
            label13.Size = new Size(38, 17);
            label13.TabIndex = 0;
            label13.Text = "Data:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblPagamentoValorEntrada);
            groupBox4.Controls.Add(lblPagamentoPorcentagemEntrada);
            groupBox4.Controls.Add(lblPagamentoPendente);
            groupBox4.Controls.Add(lblPagamentoPorcentagemDesconto);
            groupBox4.Controls.Add(lblPagamentoTema);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(3, 422);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(421, 136);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informações de Pagamento:";
            // 
            // lblPagamentoValorEntrada
            // 
            lblPagamentoValorEntrada.AutoSize = true;
            lblPagamentoValorEntrada.Location = new Point(336, 69);
            lblPagamentoValorEntrada.Name = "lblPagamentoValorEntrada";
            lblPagamentoValorEntrada.Size = new Size(43, 17);
            lblPagamentoValorEntrada.TabIndex = 2;
            lblPagamentoValorEntrada.Text = "label2";
            // 
            // lblPagamentoPorcentagemEntrada
            // 
            lblPagamentoPorcentagemEntrada.AutoSize = true;
            lblPagamentoPorcentagemEntrada.Location = new Point(118, 69);
            lblPagamentoPorcentagemEntrada.Name = "lblPagamentoPorcentagemEntrada";
            lblPagamentoPorcentagemEntrada.Size = new Size(43, 17);
            lblPagamentoPorcentagemEntrada.TabIndex = 2;
            lblPagamentoPorcentagemEntrada.Text = "label2";
            // 
            // lblPagamentoPendente
            // 
            lblPagamentoPendente.AutoSize = true;
            lblPagamentoPendente.Location = new Point(118, 107);
            lblPagamentoPendente.Name = "lblPagamentoPendente";
            lblPagamentoPendente.Size = new Size(43, 17);
            lblPagamentoPendente.TabIndex = 2;
            lblPagamentoPendente.Text = "label2";
            // 
            // lblPagamentoPorcentagemDesconto
            // 
            lblPagamentoPorcentagemDesconto.AutoSize = true;
            lblPagamentoPorcentagemDesconto.Location = new Point(118, 35);
            lblPagamentoPorcentagemDesconto.Name = "lblPagamentoPorcentagemDesconto";
            lblPagamentoPorcentagemDesconto.Size = new Size(43, 17);
            lblPagamentoPorcentagemDesconto.TabIndex = 2;
            lblPagamentoPorcentagemDesconto.Text = "label2";
            // 
            // lblPagamentoTema
            // 
            lblPagamentoTema.AutoSize = true;
            lblPagamentoTema.Location = new Point(336, 35);
            lblPagamentoTema.Name = "lblPagamentoTema";
            lblPagamentoTema.Size = new Size(43, 17);
            lblPagamentoTema.TabIndex = 2;
            lblPagamentoTema.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 69);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 0;
            label2.Text = "Valor da Entrada:";
            // 
            // TelaConclusaoAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 600);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Label lblTemaNome;
        private Label lblPagamentoPorcentagemEntrada;
        private Label lblPagamentoPendente;
        private Label lblPagamentoPorcentagemDesconto;
        private Label lblPagamentoTema;
        private Label lblClienteNome;
        private Label label12;
        private Label label9;
        private Label lblClienteTelefone;
        private Label lblClienteCPF;
        private Label label11;
        private Label lblTemaValor;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label29;
        private Label label17;
        private Label label28;
        private Label label16;
        private Label label14;
        private Label lblFestaData;
        private Label label13;
        private Label lblPagamentoValorEntrada;
        private Label label2;
        private Label lblFestaBairro;
        private Label lblFestaRua;
        private Label lblFestaEstado;
        private Label lblFestaNumero;
        private Label lblFestaTermino;
        private Label lblFestaInicio;
        private Label lblFestaCidade;
        private Label label3;
        private ListBox listItens;
    }
}