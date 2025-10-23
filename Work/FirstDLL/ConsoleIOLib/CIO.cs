using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace CSC160_ConsoleMenu
{
    public static class CIO
    {
        /// <summary>
        /// Generates a console-based menu using the strings in options as the menu items.
        /// Automatically numbers each option starting at 1 and incrementing by 1.
        /// Reserves the number 0 for the "quit" option when withQuit is true.
        /// </summary>
        /// <param name="options">strings representing the menu options</param>
        /// <param name="withQuit">adds option 0 for "quit" when true</param>
        /// <returns>the int of the selection made by the user</returns>
        /// <exception cref="ArgumentException">
        ///     options is null
        ///     options is empty and withQuit is false
        /// </exception>
        public static int PromptForMenuSelection(IEnumerable<string> options, bool withQuit)
        {
            int numOptions = 0;
            foreach (string option in options)
            {
                Console.WriteLine($"{++numOptions} {option}");
            }
            if (withQuit)
            {
                Console.WriteLine("0. Quit");
            }
            return PromptForInt("Choose an option:", (withQuit) ? 0 : 1, numOptions);
        }

        /// <summary>
        /// Generates a prompt that expects the user to enter one of two responses that will equate
        /// to a boolean value. The trueString represents the case-insensitive response that will equate to true. 
        /// The falseString acts similarly, but for a false boolean value.
        ///     <para>
        ///         Example: Assume this method is called with a trueString argument of "yes" and a falseString
        ///         argument of "no". If the user enters "YES", the method returns true. If the user enters "no",
        ///         the method returns false. All other inputs are considered invalid, the user will be informed, 
        ///         and the prompt will repeat.
        ///     </para>
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="trueString">the case-insensitive value that will evaluate to true</param>
        /// <param name="falseString">the case-insensitive value that will evaluate to false</param>
        /// <returns>the boolean result based on the user's input</returns>
        /// <exception cref="ArgumentException">
        ///     prompt, trueString, or falseString is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     trueString and falseString are case-insensitively equal
        /// </exception>
        public static bool PromptForBool(string prompt, string trueString, string falseString)
        {
            if (trueString.Equals(falseString, StringComparison.CurrentCultureIgnoreCase)) { throw new ArgumentException("trueString equals falseString"); }
            if (trueString is null || falseString is null) { throw new ArgumentException("trueString or falseString was null"); }
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            bool? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (response.Equals(trueString, StringComparison.CurrentCultureIgnoreCase)) result = true;
                    else if (response.Equals(falseString, StringComparison.CurrentCultureIgnoreCase)) result = false;
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else { Console.WriteLine("User Response was null (not allowed)"); }
            }
            return (bool)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing a byte value.
        /// This method loops until valid input is given.
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid byte value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static byte PromptForByte(string prompt, byte min, byte max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");

            byte? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (byte.TryParse(response, out byte parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (byte)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing a short value.
        /// This method loops until valid input is given.
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid short value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static short PromptForShort(string prompt, short min, short max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");
            short? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (short.TryParse(response, out short parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (short)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing an int value.
        /// This method loops until valid input is given.
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid int value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static int PromptForInt(string prompt, int min, int max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");
            int? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (int.TryParse(response, out int parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (int)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing a long value.
        /// This method loops until valid input is given.
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid long value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static long PromptForLong(string prompt, long min, long max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");
            long? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (long.TryParse(response, out long parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (long)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing a float value.
        /// This method loops until valid input is given.
		///
		/// <para>NOTE: For the purposes of this method, two floats are considered equal if the absolute value of their difference
		/// is less than or equal to 0.00001.</para>
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid float value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static float PromptForFloat(string prompt, float min, float max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");
            float? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (float.TryParse(response, out float parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (Math.Abs(parsed - min) <= 0.00001 || Math.Abs(max - parsed) <= 0.00001) result = parsed; // This line might not be necessary
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (float)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing a double value.
        /// This method loops until valid input is given.
        /// 
		/// <para>NOTE: For the purposes of this method, two doubles are considered equal if the absolute value of their difference
		/// is less than or equal to 0.0000000000001.</para>
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid double value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static double PromptForDouble(string prompt, double min, double max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");
            double? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (double.TryParse(response, out double parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (Math.Abs(parsed - min) <= 0.0000000000001 || Math.Abs(max - parsed) <= 0.0000000000001) result = parsed; // This line might not be necessary
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (double)result;
        }

        /// <summary>
        /// Generates a prompt that expects a numeric input representing a decimal value.
        /// This method loops until valid input is given.
        /// 
		/// <para>NOTE: For the purposes of this method, two decimals are considered equal if the absolute value of their difference
		/// is less than or equal to 0.00000000000000000000000000001.</para>
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid decimal value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static decimal PromptForDecimal(string prompt, decimal min, decimal max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");
            decimal? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (decimal.TryParse(response, out decimal parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (Math.Abs(parsed - min) <= (decimal)0.00000000000000000000000000001 || Math.Abs(max - parsed) <= (decimal)0.00000000000000000000000000001) result = parsed; // This line might not be necessary
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (decimal)result;
        }

        /// <summary>
        /// Generates a prompt that allows the user to enter any response and returns the string.
        /// When allowEmpty is true, empty responses are valid. When false, responses must contain
        /// at least one character (including whitespace). Null is never a valid user input for this method.
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user.</param>
        /// <param name="allowEmpty">when true, makes empty responses valid</param>
        /// <returns>the input from the user as a string</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        /// </exception>
        public static string PromptForInput(string prompt, bool allowEmpty)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            string? response = null;
            while (response is null)
            {
                Console.WriteLine(prompt);
                Console.BackgroundColor = ConsoleColor.Black;
                response = Console.ReadLine();
                if (allowEmpty) return (response is null) ? "" : response; // Don't want to return null
                if (string.IsNullOrEmpty(response)) response = null;
            }
            return response;
        }

        /// <summary>
        /// Generates a prompt that expects a single character input representing a char value.
        /// This method loops until valid input is given.
		///
		/// <para>NOTE: When validating user input and min/max values, this method IS case sensitive.</para>
        /// </summary>
        /// <param name="prompt">the prompt to be displayed to the user</param>
        /// <param name="min">the inclusive minimum boundary</param>
        /// <param name="max">the inclusive maximum boundary</param>
        /// <returns>the user's valid char value</returns>
        /// <exception cref="ArgumentException">
        ///     prompt is null
        ///     prompt is empty
        ///     prompt is just whitespace
        ///     min is greater than max
        /// </exception>
        public static char PromptForChar(string prompt, char min, char max)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrWhiteSpace(prompt)) throw new ArgumentException($"Improper prompt: {prompt}");
            if (min > max) throw new ArgumentException($"{min} is greater than {max}");

            char? result = null;
            while (result is null)
            {
                Console.WriteLine(prompt);
                string? response = Console.ReadLine();
                if (response is not null)
                {
                    if (char.TryParse(response, out char parsed))
                    {
                        if (parsed >= min && parsed <= max) result = parsed;
                        else if (parsed > max) Console.WriteLine($"{parsed} is greater than {max}");
                        else if (parsed < min) Console.WriteLine($"{parsed} is less than {min}");
                    }
                    else Console.WriteLine($"Improper Response: {response}");
                }
                else Console.WriteLine("User Response was null (not allowed)");
            }
            return (char)result;
        }
    }
}
