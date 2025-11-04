using System.Diagnostics.CodeAnalysis;

namespace OverloadingOperators
{
    public struct Fraction(int whole = 0, int numerator = 0, int denominator = 1)
    {
        public int WholeNumber { get; set; } = whole;
        public int Numerator { get; set; } = numerator;
        private int denominator = denominator;

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0) throw new ArgumentException("The denominator cannot be 0.");
                denominator = value;
            }
        }

        public static int GCD(int m, int n)
        {
            if (n == 0) return m;
            return GCD(n, m % n);
        }

        public void MakeImproper()
        {
            Numerator += WholeNumber * Denominator;
            WholeNumber = 0;
        }

        public void MakeProper()
        {
            if (Numerator >= denominator)
            {
                WholeNumber++;
                Numerator -= denominator;
                MakeProper();
            }
        }

        public void Reduce()
        {
            int divisor = GCD(Numerator, denominator);
            Numerator /= divisor;
            denominator /= divisor;
        }

        public void Simplify()
        {
            MakeProper();
            Reduce();
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f3 = new();
            PrepareForOperation(ref f1, ref f2);
            f3.Numerator = f1.Numerator + f2.Numerator;
            f3.Denominator = f1.Denominator;
            // Make f3 Proper and Reduced for output
            f3.Simplify();
            return f3;
        }


        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction f3 = new();
            PrepareForOperation(ref f1, ref f2);
            f3.Numerator = f1.Numerator - f2.Numerator;
            f3.Denominator = f1.Denominator;
            // Make f3 Proper and Reduced for output
            f3.Simplify();
            return f3;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f3 = new();
            PrepareForOperation(ref f1, ref f2);
            f3.Numerator = f1.Numerator * f2.Numerator;
            f3.denominator = f1.denominator * f2.denominator;
            // Make f3 Proper and Reduced for output
            f3.Simplify();
            return f3;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f3 = new();
            PrepareForOperation(ref f1, ref f2);
            f2.FlipFrac();
            f3.Numerator = f1.Numerator * f2.Numerator;
            f3.denominator = f1.denominator * f2.denominator;
            // Make f3 Proper and Reduced for output
            f3.Simplify();
            return f3;
        }

        public static bool operator == (Fraction f1, Fraction f2)
        {
            f1.MakeImproper(); f2.MakeImproper(); f1.Reduce(); f2.Reduce();
            return ((f1.Numerator == f2.Numerator) && (f1.Denominator == f2.Denominator));
        }

        public static bool operator != (Fraction f1, Fraction f2) { return !(f1 == f2); }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is Fraction other)
            {
                return this == other;
            }
            return false;
        }

        public override string ToString()
        {
            if (Numerator == 0) return $"{WholeNumber}";
            else if (WholeNumber == 0) return $"{Numerator}/{denominator}";
            
            return $"{WholeNumber} {Numerator}/{denominator}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Private Helper Methods (Lessen Repeating Code)
        private static void PrepareForOperation(ref Fraction f1, ref Fraction f2)
        {
            if (f1.denominator != f2.denominator)
            {
                int denom = f1.denominator; // Storing

                // f1 modifications using f2
                f1.Numerator *= f2.denominator;
                f1.denominator *= f2.denominator;

                // f2 modifications using the stored state of f1
                f2.Numerator *= denom;
                f2.denominator *= denom;
            }
            // Make f1 & f2 Improper for operation
            f1.MakeImproper();
            f2.MakeImproper();
        }

        // Just wanted the '/' operator to have less stuff, So this is now its own fraction
        private void FlipFrac()
        {
            int storeState = denominator;
            denominator = Numerator;
            Numerator = storeState;
        }
    }
}
