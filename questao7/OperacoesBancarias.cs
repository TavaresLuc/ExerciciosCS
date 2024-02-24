public class OperacoesBancarias
{
    public static void opcaoDepositar(Correntista correntista)
    {
        do
        {
            decimal depositoAceito;
            string deposito = Console.ReadLine() ?? string.Empty;

            if (decimal.TryParse(deposito, out depositoAceito))
            {
                Console.WriteLine($"\nSeu depósito foi de: {depositoAceito} ");
                Operacoes.Depositar(correntista, depositoAceito);
                Operacoes.Restart();
                break;
            }
            else
                Console.WriteLine("Valor Inválido, digite novamente.");
        } while (true);
    }

    public static void opcaoSacar(Correntista correntista)
    {
        do {
            decimal saqueAceito;
            string saque = Console.ReadLine() ?? string.Empty;

            if (decimal.TryParse(saque, out saqueAceito))
            {
                Console.WriteLine($"\nSeu saque foi de: {saqueAceito} ");

                if (saqueAceito > correntista.Saldo)
                {
                    Console.WriteLine("Saque não realizado, valor maior do que o saldo.");
                    break;
                }

                Operacoes.Sacar(correntista, saqueAceito);
                Operacoes.Restart();
                break;
            }
            else              
            Console.WriteLine("Valor inválido, digite novamente.");
        } while(true);
    }

    public static void opcaoComprar(Correntista correntista)
    {
        do {
            decimal compraAceita;
            string compra = Console.ReadLine() ?? string.Empty;

            if (decimal.TryParse(compra, out compraAceita))
            {
                if (compraAceita > correntista.Saldo) 
                {
                    Console.WriteLine("\n Compra recusada, SALDO INSUFICIENTE!");
                    break;
                    } else {
                        Console.WriteLine("\n Compra aprovada!");
                        Operacoes.Comprar(correntista, compraAceita);
                        Operacoes.Restart();
                        break;
                        
                    } 
            }
        }while(true);
    }

    public static void consultarCompras(Correntista correntista)
    {
        Console.WriteLine($"Suas compras realizadas: \n");

         
        foreach (decimal compra in correntista.Compras)
        {             
            for (int i = 1; i < correntista.Compras.Count; i++) {   
                Console.Write($"Compra {i}: {compra:C} ||");
            }
        }
    }
}
