using System.Security;

internal class Program
{
    private static void Main(string[] args)
    {

        (string, string, double) brasil = ("Brasil", "Brasilia", 1268.11);
        Console.WriteLine($"O {brasil.Item1}, cuja sua capital é {brasil.Item2} tem rpc de R$ {brasil.Item3}");
    }
}