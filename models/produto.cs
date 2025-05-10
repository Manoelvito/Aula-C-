using System;

namespace BANCO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void ExibirProduto()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R$ {Preco:F2}");
        }
    }
}
