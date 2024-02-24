/*Questão 7: 
Considere objeto de correntistas
A) Implemente uma função de depositar, a qual deve incrementar o valor do saldo;
B) Implemente uma função de sacar, a qual deve subtraia o valor do saldo;
C) Implemente uma função comprar que deve adicionar o valor da compra na array compras
do respectivo correntista.
*/
public class Program
{
    static Correntista correntista = new Correntista("Dimitri", 6998, 1500.90m);
    public static void Main()
    {
        Menu(correntista);

        static void Menu(Correntista correntista){
            
            int opcao;
            do
            {           
                Console.WriteLine("\nOlá, bem vindo ao Sistema Bancário do Tavares!");
                Console.WriteLine("Escolha as opções abaixo:");
                Console.WriteLine("1 - Para depositar, aperte a tecla 1;");
                Console.WriteLine("2 - Para Sacar, aperte a tecla 2.");

                
                string resposta = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(resposta, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("\nVocê escolheu a opção DEPÓSITO, digite o valor:");
                            OperacoesBancarias.opcaoDepositar(correntista);
                        break;

                        case 2:
                            Console.WriteLine("\nVocê escolheu a opção SACAR, digite o valor:");
                            OperacoesBancarias.opcaoSacar(correntista);
                        break;

                        case 3:
                            Console.WriteLine("Compra realizada com sucesso!");
                        break;

                        default:
                            Console.WriteLine("Por favor, digite um número entre 1 e 3.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número entre 1 e 3.");
                }
            } while (opcao != 1 && opcao != 2 && opcao != 3);
        }
    }

     public static void Restart()
    {
        Console.WriteLine("Digite qualquer tecla para continuar!");
        Console.ReadLine();
        Console.Clear();
        Main();
    }   
}

