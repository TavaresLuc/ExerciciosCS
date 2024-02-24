public class Correntista 
{
    public string Nome { get; set;}
    public int NumeroConta { get; set;}
    public decimal Saldo { get; set;}
    
    public Correntista(string nome, int numeroConta, decimal saldo)
    {
        Nome = nome;
        NumeroConta = numeroConta;
        Saldo = saldo;
        
    }

    // Depositar
    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
    
    public void Sacar(decimal valor)
    {
        Saldo -= valor;
    }
}