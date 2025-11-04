using OverloadingOperators;

namespace OverloadingOperatorsLibTest
{
    public class FractionTests
    {
        // 4 Rules to Automated Testing
        // 1. Every test should think it's the ONLY test
        // 2. Every test should start from a place of newness
        // 3. Every test should test ONE thing
        // 4. Test EVERYTHING

        // MakeImproper ; MakeProper ; Reduce ; Simplify ; GCD covered in other tests (wouldn't work otherwise)
        // Leaving GCD in as template, also doesn't hurt
        
        [Theory]
        [InlineData(15, 3, 3)]
        [InlineData(3, 15, 3)]
        [InlineData(30, 40, 10)]
        [InlineData(35, 35, 35)]
        public void GCD_ReturnsCorrectValue(int m, int n, int expected)
        {
            // Act
            int actual = Fraction.GCD(m, n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 5, 12, 0, 7, 12, 1, 0, 1)] // Same base, Reduced properly
        [InlineData(0, 8, 13, 0, 9, 13, 1, 4, 13)] // Same base, Reduced properly with left-over
        [InlineData(0, 1, 2, 0, 1, 4, 0, 3, 4)] // Different base, Reduced
        [InlineData(0, 3, 4, 0, 7, 8, 1, 5, 8)] // Different base, Reduced (Whole Number)
        [InlineData(1, 3, 4, 1, 1, 2, 3, 1, 4)] // Whole Numbers, Reduced
        [InlineData(1, 6, 13, 1, 6, 13, 2, 12, 13)] // Whole Numbers, cannot be reduced
        public void AddOverload_ReturnsCorrectValue(int m1, int m2, int m3, int n1, int n2, int n3, int e1, int e2, int e3)
        {
            Fraction expected = new Fraction(e1, e2, e3);

            Fraction m = new Fraction(m1, m2, m3);
            Fraction n = new Fraction(n1, n2, n3);
            Fraction actual = m + n;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, 4, 0, 1, 4, 0, 1, 2)] // Same Base, Reduced
        [InlineData(0, 12, 13, 0, 1, 2, 0, 11, 26)] // Different Base (No Reduction Possible)
        [InlineData(1, 1, 2, 0, 3, 4, 0, 3, 4)] // Whole Number on one side
        [InlineData(2, 4, 9, 1, 5, 8, 0, 59, 72)] // Whole Number (Both Sides) No reduction possible
        [InlineData(4, 1, 2, 1, 1, 2, 3, 0, 1)] // Whole Number (Both Sides) Reduced and Simplified
        public void SubtractOverload_ReturnsCorrectValue(int m1, int m2, int m3, int n1, int n2, int n3, int e1, int e2, int e3)
        {
            Fraction expected = new Fraction(e1, e2, e3);

            Fraction m = new Fraction(m1, m2, m3);
            Fraction n = new Fraction(n1, n2, n3);
            Fraction actual = m - n;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1, 2, 0, 1, 2, 0, 1, 4)] // No Whole Numbers
        [InlineData(1, 2, 4, 4, 6, 9, 7, 0, 1)] // Whole Numbers (accidental perfect result)
        [InlineData(1, 4, 9, 3, 2, 7, 4, 47, 63)] // Whole Numbers (Reduced)
        public void MultiplyOverload_ReturnsCorrectValue(int m1, int m2, int m3, int n1, int n2, int n3, int e1, int e2, int e3)
        {
            Fraction expected = new Fraction(e1, e2, e3);

            Fraction m = new Fraction(m1, m2, m3);
            Fraction n = new Fraction(n1, n2, n3);
            Fraction actual = m * n;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, 7, 0, 2, 5, 1, 1, 14)] // No Whole Numbers
        [InlineData(1, 3, 4, 3, 9, 19, 0, 133, 264)] // Whole Numbers
        [InlineData(12, 4, 63, 3, 9, 10, 3, 229, 2457)] // Whole Numbers (Bigger)
        public void DivideOverload_ReturnsCorrectValue(int m1, int m2, int m3, int n1, int n2, int n3, int e1, int e2, int e3)
        {
            Fraction expected = new(e1, e2, e3);

            Fraction m = new(m1, m2, m3);
            Fraction n = new(n1, n2, n3);
            Fraction actual = m / n;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 1, 4, 6, true)]
        [InlineData(1, 2, 3, 1, 2, 6, false)]
        public void Equal_ReturnsCorrectValue(int m1, int m2, int m3, int n1, int n2, int n3, bool shouldBeTrue)
        {
            Fraction m = new(m1, m2, m3);
            Fraction n = new(n1, n2, n3);
            if (shouldBeTrue) Assert.True(m == n);
            else Assert.False(m == n);
        }

        [Theory]
        [InlineData(1, 3, 4, 3, 2, 5, true)]
        [InlineData(1, 2, 3, 1, 4, 6, false)]
        public void NotEqual_ReturnsCorrectValue(int m1, int m2, int m3, int n1, int n2, int n3, bool shouldBeTrue)
        {
            Fraction m = new(m1, m2, m3);
            Fraction n = new(n1, n2, n3);
            if (shouldBeTrue) Assert.True(m != n);
            else Assert.False(m != n);
        }

        [Theory]
        [InlineData(0, 3, 2, "3/2")]
        [InlineData(1, 2, 12, "1 2/12")]
        [InlineData(3, 0, 3, "3")]
        [InlineData(0, 0, 3, "0")]
        public void ToString_ReturnsCorrectValue(int m1, int m2, int m3, string expected)
        {
            Fraction m = new(m1, m2, m3);
            Assert.Equal(m.ToString(), expected);
        }
    }
}
