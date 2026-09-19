namespace aula05
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("=====Calcular=====");
            Console.WriteLine("Digite o numero 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            

            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            int module = number1 % number2; // resto da divisão
            Console.WriteLine("o valor da soma dos dois numeros é: " + sum);
            Console.WriteLine("O valor da Subtração dos dois numeros é: " + subtraction);
            Console.WriteLine("O valor da Multiplicação dos dois numeros é: " + multiplication);
            Console.WriteLine("O valor da divisão dos dois numeros é: " + division);
            Console.WriteLine("O Resto da divisão dos dois numeros é: " + module);
        }
    }
}