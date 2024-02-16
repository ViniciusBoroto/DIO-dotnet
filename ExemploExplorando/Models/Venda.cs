using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string item, string preco)
        {
            Id = id;
            Item = item;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Item { get; set; }
        public decimal Preco { get; set; }
    }
}