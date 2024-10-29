using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComMultiplasJanelas
{
    public partial class FormNovaVenda : Form
    {
        private BindingList<Cliente> Clientes {  get; set; }
        private Cliente Cliente { get { return Clientes.FirstOrDefault(f => f.Id == (int)comboBoxCliente.SelectedValue); } }
        public int IdCliente { get { return (int)comboBoxCliente.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownDesconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoVenda; } }
        private decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto /100)); } }


        public FormNovaVenda(BindingList<Cliente> clientes, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Clientes = clientes;
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.DisplayMember = "NomeEmpresa";
            comboBoxCliente.DataSource = Clientes;
            comboBoxCliente.SelectedIndex = 0;

            Produtos = produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.DataSource = Produtos;
            comboBoxProduto.SelectedIndex = 0;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
