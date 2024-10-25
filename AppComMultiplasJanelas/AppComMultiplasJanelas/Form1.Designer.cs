namespace AppComMultiplasJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionarProduto = new Button();
            buttonDeletarProduto = new Button();
            dataGridView1 = new DataGridView();
            buttonProdutos = new Button();
            buttonFornecedores = new Button();
            buttonClientes = new Button();
            buttonCompras = new Button();
            buttonVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonDeletarFornecedor = new Button();
            buttonAdicionarCliente = new Button();
            buttonDeletarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.Location = new Point(12, 69);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(121, 36);
            buttonAdicionarProduto.TabIndex = 0;
            buttonAdicionarProduto.Text = "Novo Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.Location = new Point(12, 107);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(118, 38);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = true;
            buttonDeletarProduto.Click += buttonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 382);
            dataGridView1.TabIndex = 2;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Location = new Point(12, 12);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(118, 36);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.Location = new Point(136, 12);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(129, 34);
            buttonFornecedores.TabIndex = 4;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = true;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(271, 12);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(118, 34);
            buttonClientes.TabIndex = 5;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonCompras
            // 
            buttonCompras.Location = new Point(395, 12);
            buttonCompras.Name = "buttonCompras";
            buttonCompras.Size = new Size(121, 34);
            buttonCompras.TabIndex = 6;
            buttonCompras.Text = "Compras";
            buttonCompras.UseVisualStyleBackColor = true;
            buttonCompras.Click += buttonCompras_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.Location = new Point(522, 12);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(113, 34);
            buttonVendas.TabIndex = 7;
            buttonVendas.Text = "Vendas";
            buttonVendas.UseVisualStyleBackColor = true;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.Location = new Point(136, 67);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(129, 36);
            buttonAdicionarFornecedor.TabIndex = 8;
            buttonAdicionarFornecedor.Text = "Novo Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = true;
            buttonAdicionarFornecedor.Click += buttonNovoFornecedor_Click;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.Location = new Point(139, 109);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(126, 36);
            buttonDeletarFornecedor.TabIndex = 9;
            buttonDeletarFornecedor.Text = "Deletar";
            buttonDeletarFornecedor.UseVisualStyleBackColor = true;
            buttonDeletarFornecedor.Click += buttonDeletarFornecedor_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.Location = new Point(271, 67);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(118, 36);
            buttonAdicionarCliente.TabIndex = 10;
            buttonAdicionarCliente.Text = "Novo Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            buttonAdicionarCliente.Click += butttonAdicionarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.Location = new Point(271, 109);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(118, 36);
            buttonDeletarCliente.TabIndex = 11;
            buttonDeletarCliente.Text = "Deletar";
            buttonDeletarCliente.UseVisualStyleBackColor = true;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 545);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonDeletarFornecedor);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonVendas);
            Controls.Add(buttonCompras);
            Controls.Add(buttonClientes);
            Controls.Add(buttonFornecedores);
            Controls.Add(buttonProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeletarProduto);
            Controls.Add(buttonAdicionarProduto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
        private Button buttonDeletarProduto;
        private DataGridView dataGridView1;
        private Button buttonProdutos;
        private Button buttonFornecedores;
        private Button buttonClientes;
        private Button buttonCompras;
        private Button buttonVendas;
        private Button buttonAdicionarFornecedor;
        private Button buttonDeletarFornecedor;
        private Button buttonAdicionarCliente;
        private Button buttonDeletarCliente;
    }
}
