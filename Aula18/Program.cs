namespace Aula18;

using System.IO;

public class Program
{
    public static void Main()
    {
        //1.Criar o arquivo
        //string content = "Hello Word!";

        //File.WriteAllText("file.txt", "Hello Word! ");

        //Console.WriteLine("Arquivo criado com sucesso! ");

        //2. Criar arquivo em um local especifico

        //string path = @"C:\\Projetos.Net\\DotNetVisualStudioCode\\Aula18\fileName.txt";

        //string content = "Hello World";

        //File.WriteAllText(path, content);

        //Console.WriteLine("Arquivo criado com sucesso! ");

        //3. Criar um arquivo Word
        //string path = @"C:\\Projetos.Net\\DotNetVisualStudioCode\\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filhePath = path + fileName;

        //string content = "Hello World";

        //File.WriteAllText(filhePath, content);

        //Console.WriteLine("Arquivo Wordcriado com sucesso! ");

        //4. Inserir um Paragrafo em um arquivo

        string path = @"C:\\Projetos.Net\\DotNetVisualStudioCode\\Aula18\";
        string fileName = "myDocument.Doc";
        string filePath = path + fileName;

        string aditionalContent = "| Curso de C# e .NET";

        File.AppendAllText(filePath, aditionalContent);

        Console.WriteLine("Arquivo atualizado com sucesso! ");

        //5. Ler o arquivo

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Conteudo do arquivo" + fileContent);


    }
}