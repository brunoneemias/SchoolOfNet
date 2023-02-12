using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue fila = new Queue();
        fila.Enqueue("Bruno");
        fila.Enqueue("Amanda");
        fila.Enqueue("Tony");
        Console.WriteLine(fila.Peek());
        Console.WriteLine($"A fila tem {fila.Count} itens");
        Console.WriteLine($"O item {fila.Dequeue()} foi retirado");
        Console.WriteLine($"A fila tem {fila.Count} itens");
    }
}