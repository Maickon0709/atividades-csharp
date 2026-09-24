namespace Aula17;

public class Program
{
    public static void Main(string[] args)
    {
        // Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pera"
        };

        // Adicionando novos elementos
        fruits.Add("Uva");
        fruits.Add("Melancia");
        fruits.AddRange(new List<string>() { "Kiwi", "Maracujá" });

        // Removendo elementos
        fruits.Remove("Abacate");
        fruits.RemoveAt(0);
        fruits.RemoveAll(fruit => fruit.StartsWith("M"));

        // Modificando elementos
        fruits[0] = "Morango";
        int index = fruits.FindIndex(fruit => fruit == "Kiwi");
        if (index != -1)
        {
            fruits[index] = "Kiwi Dourado";
        }

        Console.WriteLine($"Antes de limpar: {fruits.Count} itens");

        // Limpando a lista inteira
        fruits.Clear();

        Console.WriteLine($"Depois de limpar: {fruits.Count} itens");

        string separator = "------------------";
        Console.WriteLine(separator);

        // Percorrendo a lista (não imprime nada, pois está vazia)
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}