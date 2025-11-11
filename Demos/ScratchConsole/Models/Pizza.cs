namespace ScratchConsole.Models
{
    public enum Sauce
    {
        NoSauce,
        Marinara,
        Alfredo,
        BBQ,
        SweetChili,
        Ranch,
        GarlicAioli,
        Tomato
    }

    public class Pizza
    {
        public string? Cheese { get; set; }
        public List<string> Toppings { get; set; } = [];
        //public float Radius { get; set; }
        private float radius = 3.0f;
        public float Radius
        {
            get { return radius; }
            set
            {
                if (value >= 3.0f) radius = value;
            }
        }
        public Sauce Sauce { get; set; } = Sauce.NoSauce;

        public Pizza(string? cheese, Sauce sauce, List<string> toppings, float radius)
        {
            Radius = radius;
            Sauce = sauce;
            Toppings = toppings;
            Cheese = cheese;
        }

        public override string ToString()
        {
            return $"Pizza ({Sauce}) Radius: {Radius}";
        }

    }
}
