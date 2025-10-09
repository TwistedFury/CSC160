// In C# there are 6 accessibility modifiers
// public
// private
// protected - owning class and any subclasses
// internal - all classes within the same assembly (DEFAULT)
// protected internal
// private protected

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}