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
                Program.Restart();
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
                Program.Restart();
                break;
            }
            else              
            Console.WriteLine("Valor inválido, digite novamente.");
        } while(true);
    }
}
