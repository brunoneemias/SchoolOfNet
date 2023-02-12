internal class Program
{
    private static void Main(string[] args)
    {
        int[] x = new int[3];
        x[0] = 5;
        x[1] = 6;
        x[2] = 7;   

        Console.WriteLine(1);
        Console.WriteLine(2);  
        Console.WriteLine(3);

        string[] nomes = new string[3];
        nomes[0] = "Tainha";
        nomes[1] = "Vinho";
        nomes[2] = "Sexo";

        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes[1]);
        Console.WriteLine(nomes[2]);

        string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };
        Console.WriteLine(diasSemanas[2]);
    }
}