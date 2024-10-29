namespace AppComMultiplasJanelas
{
    partial class FormNovaVenda
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxProduto = new ComboBox();
            comboBoxCliente = new ComboBox();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            textBoxPrecoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxTotalDesconto = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 144);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço Unitario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 173);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 202);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 6;
            label7.Text = "Total de Desconto:";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(122, 20);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(144, 23);
            comboBoxProduto.TabIndex = 7;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(122, 49);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(144, 23);
            comboBoxCliente.TabIndex = 8;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownQuantidade.Location = new Point(122, 78);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(144, 23);
            numericUpDownQuantidade.TabIndex = 9;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownDesconto.Location = new Point(122, 107);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(144, 23);
            numericUpDownDesconto.TabIndex = 10;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(122, 136);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(144, 23);
            textBoxPrecoUnitario.TabIndex = 11;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(122, 165);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(144, 23);
            textBoxValorTotal.TabIndex = 12;
            // 
            // textBoxTotalDesconto
            // 
            textBoxTotalDesconto.Location = new Point(122, 194);
            textBoxTotalDesconto.Name = "textBoxTotalDesconto";
            textBoxTotalDesconto.Size = new Size(144, 23);
            textBoxTotalDesconto.TabIndex = 13;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(66, 243);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 14;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(179, 243);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormNovaVenda
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(337, 295);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxTotalDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(comboBoxCliente);
            Controls.Add(comboBoxProduto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNovaVenda";
            Text = "FormNovaVenda";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxCliente;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private TextBox textBoxTotalDesconto;
        private Button buttonOk;
        private Button buttonCancel;
    }
}