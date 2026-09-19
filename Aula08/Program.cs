namespace Aula08
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("=====Operadores Relacionais=====\n");
            Console.WriteLine("Digite o primeiro número:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //Operador de igualdade(==)
            if (x == y)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x é diferente de y";
            }
            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de diferença(!=) (x != y)
            if (x != y)
            {
                result = "x é diferente de y";
            }
            else
            {
                result = "x é igual a y";
            }
            Console.WriteLine("\nDiferença (!=): " + result);

            //Operador de maior que (>)if (x > y)
            if (x > y)
            {
                result = "x é maior que y";
            }
            else
            {
                result = "x não é maior que y";

            //Operador de menor que (<)if (x < y)
            if (x < y)
                {
                    result = "x é menor que y";
                }
                else
                {
                    result = "x não é menor que y";

                    //Operador de maior ou igual que (>=)if (x >= y)
                    if (x >= y)
                    {
                        result = "x é maior ou igual a y";
                    }
                    else
                    {
                        result = "x não é maior ou igual a y";
                    }
                }
            }
        }
    }
}
