namespace Aula06
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("========Verificador de numeros pares ou ímpares=======");
            Console.WriteLine("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;

            if (result == 0)
            {
                Console.WriteLine("O número digitado é par! ");
            }
            else
            {
                Console.WriteLine("O número digita é ímpar! ");
            }
        }
    }
}
