using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComMultiplasJanelas
{
    public class Venda
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int IdProduto { get; set; }
        [DisplayName("Id do Cliente")] public int IdCliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public decimal Desconto { get; set; }
        [DisplayName("Data da Compra")] public DateTime DataVenda { get; set; }
    }
}
