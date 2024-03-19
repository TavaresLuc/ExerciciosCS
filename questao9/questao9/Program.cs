/* Questão 9: Implemente um algoritmo que possibilita que você adicione os 5 filmes ou seriados
que você mais gostou de assistir. Esse código deve impedir que registros sejam informados em duplicidade.
*/
class Program 
{
    static List<string> filmes = new List<string>();
    static void Main()
    {
        Console.WriteLine("Adicione um filme na sua lista ou digite 1 para ver sua lista:");
        

        string filme = Console.ReadLine() ?? string.Empty;
        
        if (filme == "1")
            VerLista();
        else
        {
            filmes.Add(filme);
            Main();
        }
    }

    static void VerLista() 
    {
        Console.WriteLine("Filmes na sua lista:");
        foreach (string i in filmes)         
            Console.WriteLine($"{i}");
    }
}


