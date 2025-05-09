using System;

namespace BANCO
{
    public class Cliente
    {
        // Propriedades do cliente
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        
        // Construtor
        public Cliente(string nome, string cpf, string endereco)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
        }
        
        // Método para exibir informações do cliente
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Endereço: {Endereco}");
        }
    }
}