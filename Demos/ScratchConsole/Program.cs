#region Accessibility Modifiers
// In C# there are 6 accessibility modifiers
// public - visible to anything
// private - visible to nothing (only it can see itself)
// protected - visible to itself and subclasses
// internal - visible within the same assembly [DEFAULT]
// protected internal - [UNION] of protected internal (Less Restrictive) (same assembly & subclasses)
// private protected - [INTERSECTION] of internal & protected (subclasses w/in the same assembly)
#endregion

using ScratchConsole.Weeks;

internal class Program
{
    private static void Main(string[] args)
    {
        Week06.Run();
    }
}