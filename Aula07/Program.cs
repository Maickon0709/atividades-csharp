namespace Aula07;
public class Program
{
    static void Main()
    {
        Console.WriteLine("==========Operadores de Atribuição==========");

        //inicar a variável

        int x = 10;
        Console.WriteLine("Valor inical da variável de x: " + x);

        //Operador de atribuição Simples (=)

        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("\nNovo valor de x: " + x);

        //Atribuição Composta = incremento (++)
        x++; //Equivale a x = x + 1;

        Console.WriteLine("\nAtribuição Composta de incremento (++)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (+=)
        x += 10; // Equivale x = x + 10

        Console.WriteLine("\nAtribuição Composta (+=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (-=)
        x -= 10; //Equivale x = x - 10

        Console.WriteLine("\nAtribuição Composta (-=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (*=)
        x *= 10; //Equivale x = x * 10

        Console.WriteLine("\nAtribuição Composta (*=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (/=)
        x /= 10; //Equivale x = x / 10

        Console.WriteLine("\nAtribuição Composta (/=)");
        Console.WriteLine("Novo valor de x: " + x);
    }
}