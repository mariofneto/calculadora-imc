class Program
{
    static void Main(string[] args) //necessário decorar
    {
        Pessoa Mario = new Pessoa();
        Console.Write("Escreva seu peso: ");
        Mario.peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escreva sua altura: ");
        Mario.altura = Convert.ToDouble(Console.ReadLine());
        Mario.mensagem();
    }
}