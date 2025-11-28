class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Exercício 2- Fixando o laço wile");

        Console.WriteLine("Digite seu nome ");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá " + nome); Console.WriteLine("Digite a sua idade");
        int idade = Console.Read();
        Console.Read();
        int.TryParse(Console.ReadLine(), out idade);

       

        Console.WriteLine("tecle enter para fechar");
        Console.ReadLine();



    }
}


