namespace Aula10;
public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {
            //iniciando o programa

            Console.WriteLine("==========Calculadora==========");

            Console.WriteLine("Digite o primeiro valor: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //escolher a operação

            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("Digite o numero da operação desejada: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            //Condições if e else
            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Não é possivel dividir um numero por 0 ");
                }
            }
            else
            {
                Console.WriteLine("Operação Invalida");
            }
            Console.WriteLine("\nResultado : " + result + "\n");

            Console.WriteLine("Deseja realizar outra operção? (s/n) ");

            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }
        }

        Console.WriteLine("Obrigado por usar a calculadora");
    }
}

       