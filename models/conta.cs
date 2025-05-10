namespace Models
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta(int numero, Cliente titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
                return false;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("=== Dados da Conta ===");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Saldo: R$ {Saldo:F2}");
            Console.WriteLine("=== Dados do Titular ===");
            Titular.ExibirDados();
        }
    }
}
