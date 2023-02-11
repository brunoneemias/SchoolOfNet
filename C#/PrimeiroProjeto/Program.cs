// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 24;
            string nome = "Bruno Neemias";
            bool ativo = false;
            decimal salario = 5840.99m;
            float descontos = 1200.99f;

      
   
            Console.WriteLine($"O usuario {nome} tem {idade} anos de idade, esta {ativo} no sistema e ganha {salario}");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            dynamic x = "Essa variavel é uma string";
            Console.WriteLine(x);
            Console.WriteLine("---------------------------------------------------------------------------------------");
            x = 10;
            Console.WriteLine(x);
            x = true;
            Console.WriteLine(x);
        }
    } 
}

