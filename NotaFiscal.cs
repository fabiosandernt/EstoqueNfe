
namespace EstoqueNfe
{
    public class NotaFiscal
    {
        public int Id { get; set; } 
        public int Numero { get; set; }
        public  DateTime Data { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
