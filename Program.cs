using System;
using Models;  // Referência à pasta Models onde estão as classes Conta e Cliente

class Program
{
    static void Main(string[] args)
    {
        // Criando alguns clientes
        Cliente cliente1 = new Cliente("João", "12345678900", "Rua A, 123");
        Cliente cliente2 = new Cliente("Maria", "98765432100", "Rua B, 456");
        Cliente cliente3 = new Cliente("Carlos", "45678912300", "Rua C, 789");
        Cliente cliente4 = new Cliente("Ana", "32165498700", "Rua D, 101");
        Cliente cliente5 = new Cliente("Roberto", "74125896300", "Rua E, 202");

        // Criando um array de 5 contas
        Conta[] contas = new Conta[5];

        // Preenchendo o array de contas com clientes e números de conta
        contas[0] = new Conta(101, cliente1);
        contas[1] = new Conta(102, cliente2);
        contas[2] = new Conta(103, cliente3);
        contas[3] = new Conta(104, cliente4);
        contas[4] = new Conta(105, cliente5);

        // Realizando depósitos e saques
        contas[0].Depositar(500.00);
        contas[1].Depositar(300.00);
        contas[2].Depositar(400.00);
        contas[3].Depositar(600.00);
        contas[4].Depositar(200.00);

        // Realizando saques
        contas[1].Sacar(50.00);
        contas[2].Sacar(100.00);
        contas[3].Sacar(200.00);
        contas[4].Sacar(50.00);

        // Exibindo dados das contas
        foreach (var conta in contas)
        {
            conta.ExibirDados();
            Console.WriteLine();
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
