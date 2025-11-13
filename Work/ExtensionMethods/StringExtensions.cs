namespace Extensions
{
    // Only here to get rid of errors, nothing actually runs here
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public static class StringExtensions
    {
        public static string ToPigLatin(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;

            string[] words = s.Split(' ');
            List<string> pigLatinWords = new();

            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word) || word.Length == 1)
                {
                    pigLatinWords.Add(word);
                    continue;
                }

                bool isFirstUpper = char.IsUpper(word[0]);
                string rest = word.Substring(1);
                string pigWord = rest + char.ToLower(word[0]) + "ay";

                if (isFirstUpper) pigWord = char.ToUpper(pigWord[0]) + pigWord.Substring(1);
                pigLatinWords.Add(pigWord);
            }
            return string.Join(" ", pigLatinWords);
        }

        public static int WordCount(this string s)
        {
            return s.Split(" ").Length;
        }

        public static string ReverseWord(this string s)
        {
            string s1 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 += s[i];
            }
            return s1;
        }

        public static string ReverseWordOrder(this string s)
        {
            string[] words = s.Split(" ");
            return string.Join(" ", words.Reverse());
        }

        public static bool IsPalindrome(this string s)
        {
            string s1 = "";
            foreach (char c in s)
            {
                // Removing spaces
                if (c != ' ') s1 += c;
            }
            return s1.ReverseWord().ToLower() == s1.ToLower();
        }

        public static string FlipCasing(this string s)
        {
            string s1 = ""; char c1 = ' ';
            foreach (char c in s)
            {
                if (char.IsLower(c)) c1 = char.ToUpper(c);
                else c1 = char.ToLower(c);
                s1 += c1;
            }
            return s1;
        }
    }
}