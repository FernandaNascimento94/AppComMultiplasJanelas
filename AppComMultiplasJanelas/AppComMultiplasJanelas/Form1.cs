using System.ComponentModel;

namespace AppComMultiplasJanelas
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        private BindingList<Cliente> Clientes = new BindingList<Cliente>();
        private BindingList<Fornecedor> Fornecedores = new BindingList<Fornecedor>();
        private BindingList<Venda> Vendas = new BindingList<Venda>();
        private BindingList<Compra> Compras = new BindingList<Compra>();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Produtos;
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();
            DialogResult resultado = fnp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fnp.Nome;
                produto.Fabricante = fnp.Fabricante;
                produto.PrecoVenda = fnp.PrecoVenda;
                produto.PrecoCompra = fnp.PrecoCompra;

                Produtos.Add(produto);
            }
        }

        private void buttonDeletarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Produtos;
        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Fornecedores;
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Clientes;
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;
        }

        private void buttonDeletarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Fornecedores)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor fnf = new FormNovoFornecedor();
            var resultado = fnf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.NomeEmpresa = fnf.NomeEmpresa;
                fornecedor.NomeContato = fnf.NomeContato;
                fornecedor.Endere�o = fnf.Endereco;
                fornecedor.Email = fnf.Email;
                fornecedor.Telefone = fnf.Telefone;
                Fornecedores.Add(fornecedor);
            }
        }

        private void butttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente fnc = new FormNovoCliente();
            var resultado = fnc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (Clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Nome = fnc.Name;
                cliente.Endere�o = fnc.Endereco;
                cliente.Email = fnc.Email;
                cliente.Telefone = fnc.Telefone;
                Clientes.Add(cliente);
            }
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }
    }
}
