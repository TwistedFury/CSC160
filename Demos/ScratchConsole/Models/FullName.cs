namespace ScratchConsole.Models
{
    // A class is a custom reference type
    // A struct is a custom value type
    // Because struct is a value type, it is not NULLable without the ?
    public struct FullName
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";

        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string ToLastNameFirstString()
        {
            return $"{LastName}, {FirstName}";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public static FullName operator +(FullName left, FullName right)
        {
            string returnFName = left.FirstName + "-" + right.FirstName;
            string returnLName = left.LastName + "-" + right.LastName;
            return new FullName(returnFName, returnLName);
        }
    }
}
