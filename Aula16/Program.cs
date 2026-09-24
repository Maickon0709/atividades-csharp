namespace Aula16;

public class Program
{
    public static void Main()
    {
        //1. Declaração de um array inicializando com valores
        string[] fruits = { "Maçã", "Banana", "Caju", "Manga" };

        //2.Acessar os valores
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //3. Contar de índicies
        Console.WriteLine("Quantidade de índices: " + fruits.Length);

        //4.Alterar os valores
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);

        fruits[1] = "Abacaxi";

        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        //5.Declaração sem inicializar
        int[] numbers = new int[2];
        numbers[0] = 10;
        numbers[1] = 20;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
