using ScratchConsole.Models;

namespace ScratchConsole.Weeks
{
    public static class Week05
    {
        public static void Run()
        {
            DemoEncapsulation();
        }

        public static void DemoEncapsulation()
        {
            Pizza myPizza = new Pizza("Moose", Sauce.GarlicAioli, new List<string>{ "Bacon", "Ham", "Pineapple", "Apple", "Pen", "CapnCrunch" }, 0.5f );
            myPizza.Radius = 12;
        }
    }
}
