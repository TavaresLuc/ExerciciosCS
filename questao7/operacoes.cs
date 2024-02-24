public class Operacoes
{
    public static void Depositar(Correntista correntista, decimal valor)
    {
        correntista.Depositar(valor);
        ExibirSaldo(correntista);
    }

    public static void Sacar(Correntista correntista, decimal valor)
    {
        correntista.Sacar(valor);
        ExibirSaldo(correntista);
    }

    public static void ExibirSaldo(Correntista correntista)
    {
        Console.WriteLine($"Nome: {correntista.Nome}, Número da Conta: {correntista.NumeroConta}, Saldo: {correntista.Saldo:C}");
    }
}

