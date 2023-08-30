using System;

namespace exercicioEncapsulamento
{
    class Conta
    {
        private string Nome { get; set; }
        public double NumeroC { get; private set; }
        public double Saldo { get; private set; }

        public Conta()
        {
        }

        public Conta(double numeroC, string nome, double saldo)
        {
            NumeroC = numeroC;
            Nome = nome;
            Saldo = saldo;
        }

        public void DepInicial()
        {
            Saldo += double.Parse(Console.ReadLine());
        }

        public void Deposito()
        {
            Saldo += double.Parse(Console.ReadLine());
        }

        public void Saque()
        {
            Saldo -= 5 + double.Parse(Console.ReadLine());
        }

        public void MudarN()
        {
            Nome = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Numero da conta: {NumeroC.ToString()}, Nome do titular: {Nome}, Saldo: R${Saldo.ToString("F2")}";
        }
    }
}
