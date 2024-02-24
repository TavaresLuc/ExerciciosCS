public class Correntista 
{
    public string Nome { get; set;}
    public int NumeroConta { get; set;}
    public decimal Saldo { get; set;}
    public List<decimal> Compras { get; set;}

    public Correntista(string nome, int numeroConta, decimal saldo)
    {
        Nome = nome;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Compras = new List<decimal>();
        
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

    public void Comprar(decimal valor)
    {
        Saldo -= valor;
        Compras.Add(valor);
    }
}
