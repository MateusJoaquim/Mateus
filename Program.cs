
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Qual seu nome? ");
        var nome = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Olá, {nome} em {currentDate:d} às {currentDate:t} hs!");
        Console.WriteLine("Número do cadastro");
        int cadastro = Console.Read();

        Console.WriteLine("Cadastro encontrado");


        Console.WriteLine($"{Environment.NewLine}Pressione o teclado para sair");
        Console.ReadKey(true);
    }
}