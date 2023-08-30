using exercicioEncapsulamento;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cadastro Erickbancos:");
        Console.WriteLine("Não se esqueça que o numero da conta não pode ser mudado mas o nome sim");
        Console.Write("Número da conta:");


        double numeroC = double.Parse(Console.ReadLine());
        Console.Write("Nome do titular: ");
        string nome = Console.ReadLine();
        Console.Write("Haverá deposito incial? (s/n) ");
        char sim = char.Parse(Console.ReadLine());
        double saldo = 0;
        Conta c = new Conta(numeroC, nome, saldo);


        if (sim == 's') 
        {
            Console.Write("Digite o depósito inicial em R$: ");
            c.DepInicial();
        }
        else { }
        Console.WriteLine($"Dados da conta: {c}");
        Console.WriteLine("Deseja fazer um deposito ou saque em dinheiro? (dep/saq)");
        bool dep = Console.ReadLine() == "dep";
        if (dep == true)
        {
            Console.Write("Entre um valor para deposito: ");
            c.Deposito();
        }
        else
        {
            Console.Write("Digite a quantidade em R$ de saque: ");
            c.Saque();
        }
        Console.WriteLine($"dados atualizados: {c}");

        Console.Write("Deseja mudar seu nome? (s/n)");
        bool mudarN = Console.ReadLine() == "s";
        if(mudarN == true)
        {
            Console.Write("Digite seu novo nome: ");
            c.MudarN();
        }
        else { }
        Console.WriteLine($"Dados atualizados {c}");
        Console.WriteLine($"Agradecemos por escolher nosso banco, {nome}! Até a proxima!");
    }
}