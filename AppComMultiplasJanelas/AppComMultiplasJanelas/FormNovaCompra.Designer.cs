namespace AppComMultiplasJanelas
{
    partial class FormNovaCompra
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
            comboBoxFornecedor = new ComboBox();
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
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 278);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 6;
            label7.Text = "Total Com Desconto:";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(182, 24);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(121, 23);
            comboBoxProduto.TabIndex = 7;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(182, 66);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(121, 23);
            comboBoxFornecedor.TabIndex = 8;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(182, 103);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 9;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Location = new Point(183, 141);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(120, 23);
            numericUpDownDesconto.TabIndex = 10;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(182, 186);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(120, 23);
            textBoxPrecoUnitario.TabIndex = 11;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(182, 229);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(120, 23);
            textBoxValorTotal.TabIndex = 12;
            // 
            // textBoxTotalDesconto
            // 
            textBoxTotalDesconto.Location = new Point(183, 270);
            textBoxTotalDesconto.Name = "textBoxTotalDesconto";
            textBoxTotalDesconto.Size = new Size(120, 23);
            textBoxTotalDesconto.TabIndex = 13;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(91, 333);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 14;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(208, 333);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormNovaCompra
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(351, 381);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxTotalDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNovaCompra";
            Text = "FormNovaCompra";
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
        private ComboBox comboBoxFornecedor;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private TextBox textBoxTotalDesconto;
        private Button buttonOk;
        private Button buttonCancel;
    }
}