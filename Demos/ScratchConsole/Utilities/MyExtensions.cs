namespace ScratchConsole.Utilities
{
    /*
     * Rules for Declaring Extension Methods
     * 1. Must be declared within a static, non-nested, non-generic class
     * 2. ALL extension methods must be static
     * 3. ALL extension methods must have at least one parameter
     * 4. The first parameter of an extension method is ALWAYS the "this" parameter
     */
    public static class MyExtensions
    {
        public static int GetRandom(this int max, int min = 0)
        {
            Random random = new Random();
            return random.Next(max - min + 1) + min;
        }
    }
}
