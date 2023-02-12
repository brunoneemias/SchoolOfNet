internal class Program
{
    private static void Main(string[] args)
    {
        /* 
         Tipos de variaveis em C# 
        https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-types
         */

        char status = 'A';
        int idade = 20;
        string nome = "Davi";
        
        // Get type mostra qual é o tipo da variavel. 
        Console.WriteLine(idade.GetType()); 
        Console.ReadKey();

        //IsPrimitive mostra se é primitivo ou não 
        Console.WriteLine(idade.GetType().IsPrimitive);
        Console.ReadKey();

        //---------------------------------------
        //          Operadores básicos 
        //---------------------------------------
        //Operação de soma(+), subtração(-), divisão(/), multiplicação(*), módulo(resto da divisão) %, 
        var x = 10;
        var y = 5;
        var soma = x + y;
        Console.WriteLine(soma); 

        //++i pré incrementado 
        //i++ pós incrementado 

    }
}

