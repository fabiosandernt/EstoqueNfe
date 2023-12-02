using EstoqueNfe;

namespace Program
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Criar produtos
            Produto produto1 = new Produto { Id = 1, Nome = "Produto1", Preco = 50 };
            Produto produto2 = new Produto { Id = 2, Nome = "Produto2", Preco = 20 };

            //criar nota fiscal
            NotaFiscal notaFiscal = new NotaFiscal { Id = 1, Numero = 156, Data = DateTime.Now };

            NotaFiscal notaFiscal2 = new NotaFiscal { Id = 2, Numero = 2050, Data = DateTime.Now };

            Item Item1 = new Item{ Quantidade = 2, ValorTotal = produto1.Preco, Produto = produto1,};
            Item Item2 = new Item { Quantidade = 3, ValorTotal = produto2.Preco, Produto = produto2, };

            notaFiscal.Items.Add(Item1);
            notaFiscal.Items.Add(Item2);

            notaFiscal2.Items.Add(Item1);
            notaFiscal2.Items.Add(Item2);

            //exibir
            PrintNotaFiscal(notaFiscal);


        }
        static void PrintNotaFiscal(NotaFiscal notaFiscal)
        {
            Console.WriteLine($"Nota Fiscal {notaFiscal.Numero}");
            Console.WriteLine($"Data: {notaFiscal.Data}");

            foreach (var item in notaFiscal.Items)
            {
                Console.WriteLine($"Produto: {item.Produto.Nome}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Valor Total: {item.ValorTotal}");
                Console.WriteLine("-------------");
            }
        }
       
    }
}