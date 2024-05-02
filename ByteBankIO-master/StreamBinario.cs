using ByteBank_IO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);           //n�mero da Ag�ncia
            escritor.Write(546544);   //n�mero da conta
            escritor.Write(4000.50); //Saldo
            escritor.Write("Gustavo Braga");
        }
    }
}
