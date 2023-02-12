internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> p1 = new Stack<int>(); 
        p1.Push(1);
        p1.Push(2);
        p1.Push(3);
        p1.Push(4);
        p1.Push(5);
        p1.Push(6);
        p1.Push(7);
        p1.Push(8);
        p1.Push(9);
         
        Console.WriteLine($"A pilha tem {p1.Count} itens.");
        Console.WriteLine(p1.ToArray().GetValue(5)); 
        p1.Pop();
        Console.WriteLine(p1.Peek());
        p1.Clear();   
    }
}