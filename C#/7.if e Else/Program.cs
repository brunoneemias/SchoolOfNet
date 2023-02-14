using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        double gastosmensais, salario = 0;
        bool decimo = false; 

        Console.WriteLine("Informe seu salário: "); 
        salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe seus gastos mensais: "); 
        gastosmensais = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Tem décimo terceiro? ");
        Boolean.TryParse(Console.ReadLine(), out decimo);   

        if (decimo)
        {
            salario += salario; 
        }

        if (gastosmensais > salario)
        {
            Console.WriteLine("Precisa economizar!");

        }
        else
        {
            Console.WriteLine("Legal! Sobrou dinheiro para comprar BTC!!!");
           
        }

    }
}