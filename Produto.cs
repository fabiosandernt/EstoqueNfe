﻿
namespace EstoqueNfe
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();   

    }
}
