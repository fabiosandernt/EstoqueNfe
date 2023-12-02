namespace EstoqueNfe
{
    public class Item
    {
        public int Quantidade {  get; set; }    
        public decimal ValorTotal { get; set; }
        //item tem um produto
        public Produto Produto { get; set; }
    }
}
