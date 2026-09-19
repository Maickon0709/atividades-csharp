namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========Operadores Lógicos=========");
        bool isLogged = true;
        bool hasAdminAcess = false;

        Console.WriteLine("\nInformações do Usuário: ");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso de administrador: " + hasAdminAcess);

        Console.WriteLine("\nPermissões de Acesso: ");

        //Operador(||) - OU
        if (isLogged || hasAdminAcess)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }

        //Operador(&&) - E
        if (isLogged && hasAdminAcess)
        {
            Console.WriteLine("Acesso concedido!");
        }
        else
        {
            Console.WriteLine("Acesso negado");

        //Operador(!) - NÃO
        if (!isLogged)
            {
                Console.WriteLine("Usuário não está Logado");
            }
        else
            {
                Console.WriteLine("Usuário está Logado");
            }
        }
    }
}