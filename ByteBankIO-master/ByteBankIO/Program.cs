using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {

        /*UsarStreamDeEntrada();
        Console.WriteLine("Aplicação Finalizada ...");*/

        /* var caminhoNovoArquivo = "testaEscrita.txt";

         using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
         using (var escritor = new StreamWriter(fluxoDeArquivo))
         {
             escritor.WriteLine(true);
             escritor.WriteLine(false);
         escritor.WriteLine(1777177717);
         }

     Console.WriteLine("Aplicação finalizada");
     */


        /*var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);*/
       /* foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }*/
        /*var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");*/
        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");
        File.WriteAllText("escrevendoCOmAClasseFile.txt", "Testando File.WriteLine");
        Console.ReadLine();
    }  
}