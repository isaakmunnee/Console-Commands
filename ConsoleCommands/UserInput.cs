using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCommands
{
    /// <summary>
    /// A class hoping to simplify user input from the terminal :)
    /// </summary>
    public static class UserInput
    {
        #region GetInt
        public static int GetUserSpecifiedInt(string prompt, string incorrectMessage, bool clear)
        {
            int? number = null;

            while (number == null)
            {
                if(clear)
                    Console.Clear();

                Console.WriteLine(prompt);
                int n;

                if(int.TryParse(Console.ReadLine(), out n))
                {
                    number = n;
                }
                else
                {
                    Console.WriteLine("Not a valid integer value.");
                }
            }

            if(clear)
                Console.Clear();

            return number.Value;
        }

        public static int GetUserSpecifiedInt(string prompt, bool clear)
        {
            return GetUserSpecifiedInt(prompt, "Not a valid integer value.", clear);
        }

        public static int GetUserSpecifiedInt(string prompt, string incorrect)
        {
            return GetUserSpecifiedInt(prompt, incorrect, false);
        }

        public static int GetUserSpecifiedInt(string prompt)
        {
            return GetUserSpecifiedInt(prompt, "Not a valid integer value.", false);
        }

        public static int GetUserSpecifiedInt()
        {
            return GetUserSpecifiedInt("Enter an integer value.", "Not a valid integer value.", false);
        }
        #endregion

        #region GetFloat
        public static float GetUserSpecifiedFloat(string prompt, string incorrectMessage, bool clear)
        {
            float? number = null;

            while (number == null)
            {
                if (clear)
                    Console.Clear();

                Console.WriteLine(prompt);
                float n;

                if (float.TryParse(Console.ReadLine(), out n))
                {
                    number = n;
                }
                else
                {
                    Console.WriteLine("Not a valid float value.");
                }
            }

            if (clear)
                Console.Clear();

            return number.Value;
        }

        public static float GetUserSpecifiedFloat(string prompt, bool clear)
        {
            return GetUserSpecifiedInt(prompt, "Not a valid float value.", clear);
        }

        public static float GetUserSpecifiedFloat(string prompt, string incorrect)
        {
            return GetUserSpecifiedInt(prompt, incorrect, false);
        }

        public static float GetUserSpecifiedFloat(string prompt)
        {
            return GetUserSpecifiedInt(prompt, "Not a valid float value.", false);
        }

        public static float GetUserSpecifiedFloat()
        {
            return GetUserSpecifiedInt("Enter an float value.", "Not a valid float value.", false);
        }
        #endregion

        #region GetDouble
        public static double GetUserSpecifiedDouble(string prompt, string incorrectMessage, bool clear)
        {
            double? number = null;

            while (number == null)
            {
                if (clear)
                    Console.Clear();

                Console.WriteLine(prompt);
                double n;

                if (double.TryParse(Console.ReadLine(), out n))
                {
                    number = n;
                }
                else
                {
                    Console.WriteLine("Not a valid double value.");
                }
            }

            if (clear)
                Console.Clear();

            return number.Value;
        }

        public static double GetUserSpecifiedDouble(string prompt, bool clear)
        {
            return GetUserSpecifiedDouble(prompt, "Not a valid double value.", clear);
        }

        public static double GetUserSpecifiedDouble(string prompt, string incorrect)
        {
            return GetUserSpecifiedDouble(prompt, incorrect, false);
        }

        public static double GetUserSpecifiedDouble(string prompt)
        {
            return GetUserSpecifiedDouble(prompt, "Not a valid double value.", false);
        }

        public static double GetUserSpecifiedDouble()
        {
            return GetUserSpecifiedDouble("Enter an double value.", "Not a valid double value.", false);
        }
        #endregion

        #region GetDecimal
        public static decimal GetUserSpecifiedDecimal(string prompt, string incorrectMessage, bool clear)
        {
            decimal? number = null;

            while (number == null)
            {
                if (clear)
                    Console.Clear();

                Console.WriteLine(prompt);
                decimal n;

                if (decimal.TryParse(Console.ReadLine(), out n))
                {
                    number = n;
                }
                else
                {
                    Console.WriteLine("Not a valid decimal value.");
                }
            }

            if (clear)
                Console.Clear();

            return number.Value;
        }

        public static decimal GetUserSpecifiedDecimal(string prompt, bool clear)
        {
            return GetUserSpecifiedDecimal(prompt, "Not a valid decimal value.", clear);
        }

        public static decimal GetUserSpecifiedDecimal(string prompt, string incorrect)
        {
            return GetUserSpecifiedDecimal(prompt, incorrect, false);
        }

        public static decimal GetUserSpecifiedDecimal(string prompt)
        {
            return GetUserSpecifiedDecimal(prompt, "Not a valid decimal value.", false);
        }

        public static decimal GetUserSpecifiedDecimal()
        {
            return GetUserSpecifiedDecimal("Enter an decimal value.", "Not a valid decimal value.", false);
        }
        #endregion
        
        #region GetBool
        public static bool GetUserSpecifiedBool(string prompt, string incorrectMessage, bool clear)
        {
            bool? number = null;

            while (number == null)
            {
                if (clear)
                    Console.Clear();

                Console.WriteLine(prompt);
                bool n;

                if (bool.TryParse(Console.ReadLine(), out n))
                {
                    number = n;
                }
                else
                {
                    Console.WriteLine("Not a valid bool value.");
                }
            }

            if (clear)
                Console.Clear();

            return number.Value;
        }

        public static bool GetUserSpecifiedBool(string prompt, bool clear)
        {
            return GetUserSpecifiedBool(prompt, "Not a valid bool value.", clear);
        }

        public static bool GetUserSpecifiedBool(string prompt, string incorrect)
        {
            return GetUserSpecifiedBool(prompt, incorrect, false);
        }

        public static bool GetUserSpecifiedBool(string prompt)
        {
            return GetUserSpecifiedBool(prompt, "Not a valid bool value.", false);
        }

        public static bool GetUserSpecifiedBool()
        {
            return GetUserSpecifiedBool("Enter an bool value.", "Not a valid bool value.", false);
        }
        #endregion

        #region GetString
        public static string GetUserSpecifiedString(string prompt, string incorrectMessage, bool clear)
        {
            Console.WriteLine(prompt);

            bool isSatisfied = false;
            string value = null;

            if (clear)
                Console.Clear();

            while (!isSatisfied)
            {
                if (clear)
                    Console.WriteLine(prompt);

                string temp = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(temp))
                {
                    value = temp;
                    isSatisfied = true;
                }
                else
                {
                    Console.WriteLine(incorrectMessage);
                }

                if (clear)
                    Console.Clear();
            }

            return value;
        }

        public static string GetUserSpecifiedString(string prompt, bool clear)
        {
            return GetUserSpecifiedString(prompt, "That's just empty space...", clear);
        }

        public static string GetUserSpecifiedString(string prompt, string incorrect)
        {
            return GetUserSpecifiedString(prompt, incorrect, false);
        }

        public static string GetUserSpecifiedString(string prompt)
        {
            return GetUserSpecifiedString(prompt, "That's just empty space...", false);
        }

        public static string GetUserSpecifiedString()
        {
            return GetUserSpecifiedString("Enter an string.", "That's just empty space...", false);
        }
        #endregion

        #region GetInt[]
        public static int[] GetUserSpecifiedIntArray(string newMessage, string prompt, int length, bool clear)
        {
            int[] array = new int[length];

            Console.WriteLine(newMessage);

            if (clear)
                Console.Clear();

            for(int i = 0; i < length; i++)
            {
                if (clear)
                    Console.WriteLine(newMessage);

                int number = GetUserSpecifiedInt(String.Format("{0} #{1}:", prompt, i + 1));
                array[i] = number;

                if (clear)
                    Console.Clear();
            }

            return array;
        }

        public static int[] GetUserSpecifiedIntArray(int length)
        {
            return GetUserSpecifiedIntArray("New Int Array!", "Enter Int", length, false);
        }

        public static int[] GetUserSpecifiedIntArray(string newMessage, int length)
        {
            return GetUserSpecifiedIntArray(newMessage, "Enter Int", length, false);
        }

        public static int[] GetUserSpecifiedIntArray(string newMessage, string prompt, int length)
        {
            return GetUserSpecifiedIntArray(newMessage, prompt, length, false);
        }

        public static int[] GetUserSpecifiedIntArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt, bool clear)
        {
            int length = GetUserSpecifiedInt(arrayLengthPrompt);
            return GetUserSpecifiedIntArray(newMessage, prompt, length, clear);
        }

        public static int[] GetUserSpecifiedIntArrayUserLength(string arrayLengthPrompt)
        {
            return GetUserSpecifiedIntArrayUserLength(arrayLengthPrompt, "New Int Array!", "Enter Int", false);
        }

        public static int[] GetUserSpecifiedIntArrayUserLength(string arrayLengthPrompt, string newMessage)
        {
            return GetUserSpecifiedIntArrayUserLength(arrayLengthPrompt, newMessage, "Enter Int", false);
        }

        public static int[] GetUserSpecifiedIntArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt)
        {
            return GetUserSpecifiedIntArrayUserLength(arrayLengthPrompt, newMessage, prompt, false);
        }
        
        public static int[] GetUserSpecifiedIntArrayUserLength()
        {
            return GetUserSpecifiedIntArrayUserLength("Enter Array Length:", "New Int Array!", "Enter Int", false);
        }
        #endregion

        #region GetFloat[]
        public static float[] GetUserSpecifiedFloatArray(string newMessage, string prompt, int length, bool clear)
        {
            float[] array = new float[length];

            Console.WriteLine(newMessage);

            if (clear)
                Console.Clear();

            for (int i = 0; i < length; i++)
            {
                if (clear)
                    Console.WriteLine(newMessage);

                float number = GetUserSpecifiedFloat(String.Format("{0} #{1}:", prompt, i + 1));
                array[i] = number;

                if (clear)
                    Console.Clear();
            }

            return array;
        }

        public static float[] GetUserSpecifiedFloatArray(int length)
        {
            return GetUserSpecifiedFloatArray("New Float Array!", "Enter Float", length, false);
        }

        public static float[] GetUserSpecifiedFloatArray(string newMessage, int length)
        {
            return GetUserSpecifiedFloatArray(newMessage, "Enter Float", length, false);
        }

        public static float[] GetUserSpecifiedFloatArray(string newMessage, string prompt, int length)
        {
            return GetUserSpecifiedFloatArray(newMessage, prompt, length, false);
        }

        public static float[] GetUserSpecifiedFloatArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt, bool clear)
        {
            int length = GetUserSpecifiedInt(arrayLengthPrompt);
            return GetUserSpecifiedFloatArray(newMessage, prompt, length, clear);
        }

        public static float[] GetUserSpecifiedFloatArrayUserLength(string arrayLengthPrompt)
        {
            return GetUserSpecifiedFloatArrayUserLength(arrayLengthPrompt, "New Float Array!", "Enter Float", false);
        }

        public static float[] GetUserSpecifiedFloatArrayUserLength(string arrayLengthPrompt, string newMessage)
        {
            return GetUserSpecifiedFloatArrayUserLength(arrayLengthPrompt, newMessage, "Enter Float", false);
        }

        public static float[] GetUserSpecifiedFloatArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt)
        {
            return GetUserSpecifiedFloatArrayUserLength(arrayLengthPrompt, newMessage, prompt, false);
        }

        public static float[] GetUserSpecifiedFloatArrayUserLength()
        {
            return GetUserSpecifiedFloatArrayUserLength("Enter Array Length:", "New Float Array!", "Enter Float", false);
        }
        #endregion

        #region GetDouble[]
        public static double[] GetUserSpecifiedDoubleArray(string newMessage, string prompt, int length, bool clear)
        {
            double[] array = new double[length];

            Console.WriteLine(newMessage);

            if (clear)
                Console.Clear();

            for (int i = 0; i < length; i++)
            {
                if (clear)
                    Console.WriteLine(newMessage);

                double number = GetUserSpecifiedDouble(String.Format("{0} #{1}:", prompt, i + 1));
                array[i] = number;

                if (clear)
                    Console.Clear();
            }

            return array;
        }

        public static double[] GetUserSpecifiedDoubleArray(int length)
        {
            return GetUserSpecifiedDoubleArray("New Double Array!", "Enter Double", length, false);
        }

        public static double[] GetUserSpecifiedDoubleArray(string newMessage, int length)
        {
            return GetUserSpecifiedDoubleArray(newMessage, "Enter Double", length, false);
        }

        public static double[] GetUserSpecifiedDoubleArray(string newMessage, string prompt, int length)
        {
            return GetUserSpecifiedDoubleArray(newMessage, prompt, length, false);
        }

        public static double[] GetUserSpecifiedDoubleArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt, bool clear)
        {
            int length = GetUserSpecifiedInt(arrayLengthPrompt);
            return GetUserSpecifiedDoubleArray(newMessage, prompt, length, clear);
        }

        public static double[] GetUserSpecifiedDoubleArrayUserLength(string arrayLengthPrompt)
        {
            return GetUserSpecifiedDoubleArrayUserLength(arrayLengthPrompt, "New Double Array!", "Enter Double", false);
        }

        public static double[] GetUserSpecifiedDoubleArrayUserLength(string arrayLengthPrompt, string newMessage)
        {
            return GetUserSpecifiedDoubleArrayUserLength(arrayLengthPrompt, newMessage, "Enter Double", false);
        }

        public static double[] GetUserSpecifiedDoubleArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt)
        {
            return GetUserSpecifiedDoubleArrayUserLength(arrayLengthPrompt, newMessage, prompt, false);
        }

        public static double[] GetUserSpecifiedDoubleArrayUserLength()
        {
            return GetUserSpecifiedDoubleArrayUserLength("Enter Array Length:", "New Double Array!", "Enter Double", false);
        }
        #endregion

        #region GetDecimal[]
        public static decimal[] GetUserSpecifiedDecimalArray(string newMessage, string prompt, int length, bool clear)
        {
            decimal[] array = new decimal[length];

            Console.WriteLine(newMessage);

            if (clear)
                Console.Clear();

            for (int i = 0; i < length; i++)
            {
                if (clear)
                    Console.WriteLine(newMessage);

                decimal number = GetUserSpecifiedDecimal(String.Format("{0} #{1}:", prompt, i + 1));
                array[i] = number;

                if (clear)
                    Console.Clear();
            }

            return array;
        }

        public static decimal[] GetUserSpecifiedDecimalArray(int length)
        {
            return GetUserSpecifiedDecimalArray("New Decimal Array!", "Enter Decimal", length, false);
        }

        public static decimal[] GetUserSpecifiedDecimalArray(string newMessage, int length)
        {
            return GetUserSpecifiedDecimalArray(newMessage, "Enter Decimal", length, false);
        }

        public static decimal[] GetUserSpecifiedDecimalArray(string newMessage, string prompt, int length)
        {
            return GetUserSpecifiedDecimalArray(newMessage, prompt, length, false);
        }

        public static decimal[] GetUserSpecifiedDecimalArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt, bool clear)
        {
            int length = GetUserSpecifiedInt(arrayLengthPrompt);
            return GetUserSpecifiedDecimalArray(newMessage, prompt, length, clear);
        }

        public static decimal[] GetUserSpecifiedDecimalArrayUserLength(string arrayLengthPrompt)
        {
            return GetUserSpecifiedDecimalArrayUserLength(arrayLengthPrompt, "New Decimal Array!", "Enter Decimal", false);
        }

        public static decimal[] GetUserSpecifiedDecimalArrayUserLength(string arrayLengthPrompt, string newMessage)
        {
            return GetUserSpecifiedDecimalArrayUserLength(arrayLengthPrompt, newMessage, "Enter Decimal", false);
        }

        public static decimal[] GetUserSpecifiedDecimalArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt)
        {
            return GetUserSpecifiedDecimalArrayUserLength(arrayLengthPrompt, newMessage, prompt, false);
        }

        public static decimal[] GetUserSpecifiedDecimalArrayUserLength()
        {
            return GetUserSpecifiedDecimalArrayUserLength("Enter Array Length:", "New Decimal Array!", "Enter Decimal", false);
        }
        #endregion

        #region GetBool[]
        public static bool[] GetUserSpecifiedBoolArray(string newMessage, string prompt, int length, bool clear)
        {
            bool[] array = new bool[length];

            Console.WriteLine(newMessage);

            if (clear)
                Console.Clear();

            for (int i = 0; i < length; i++)
            {
                if (clear)
                    Console.WriteLine(newMessage);

                bool number = GetUserSpecifiedBool(String.Format("{0} #{1}:", prompt, i + 1));
                array[i] = number;

                if (clear)
                    Console.Clear();
            }

            return array;
        }

        public static bool[] GetUserSpecifiedBoolArray(int length)
        {
            return GetUserSpecifiedBoolArray("New Bool Array!", "Enter Bool", length, false);
        }

        public static bool[] GetUserSpecifiedBoolArray(string newMessage, int length)
        {
            return GetUserSpecifiedBoolArray(newMessage, "Enter Bool", length, false);
        }

        public static bool[] GetUserSpecifiedBoolArray(string newMessage, string prompt, int length)
        {
            return GetUserSpecifiedBoolArray(newMessage, prompt, length, false);
        }

        public static bool[] GetUserSpecifiedBoolArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt, bool clear)
        {
            int length = GetUserSpecifiedInt(arrayLengthPrompt);
            return GetUserSpecifiedBoolArray(newMessage, prompt, length, clear);
        }

        public static bool[] GetUserSpecifiedBoolArrayUserLength(string arrayLengthPrompt)
        {
            return GetUserSpecifiedBoolArrayUserLength(arrayLengthPrompt, "New Bool Array!", "Enter Bool", false);
        }

        public static bool[] GetUserSpecifiedBoolArrayUserLength(string arrayLengthPrompt, string newMessage)
        {
            return GetUserSpecifiedBoolArrayUserLength(arrayLengthPrompt, newMessage, "Enter Bool", false);
        }

        public static bool[] GetUserSpecifiedBoolArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt)
        {
            return GetUserSpecifiedBoolArrayUserLength(arrayLengthPrompt, newMessage, prompt, false);
        }

        public static bool[] GetUserSpecifiedBoolArrayUserLength()
        {
            return GetUserSpecifiedBoolArrayUserLength("Enter Array Length:", "New Bool Array!", "Enter Bool", false);
        }
        #endregion
        
        #region GetString[]
        public static string[] GetUserSpecifiedStringArray(string newMessage, string prompt, int length, bool clear)
        {
            string[] array = new string[length];

            Console.WriteLine(newMessage);

            if (clear)
                Console.Clear();

            for (int i = 0; i < length; i++)
            {
                if (clear)
                    Console.WriteLine(newMessage);

                string number = GetUserSpecifiedString(String.Format("{0} #{1}:", prompt, i + 1));
                array[i] = number;

                if (clear)
                    Console.Clear();
            }

            return array;
        }

        public static string[] GetUserSpecifiedStringArray(int length)
        {
            return GetUserSpecifiedStringArray("New String Array!", "Enter String", length, false);
        }

        public static string[] GetUserSpecifiedStringArray(string newMessage, int length)
        {
            return GetUserSpecifiedStringArray(newMessage, "Enter String", length, false);
        }

        public static string[] GetUserSpecifiedStringArray(string newMessage, string prompt, int length)
        {
            return GetUserSpecifiedStringArray(newMessage, prompt, length, false);
        }

        public static string[] GetUserSpecifiedStringArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt, bool clear)
        {
            int length = GetUserSpecifiedInt(arrayLengthPrompt);
            return GetUserSpecifiedStringArray(newMessage, prompt, length, clear);
        }

        public static string[] GetUserSpecifiedStringArrayUserLength(string arrayLengthPrompt)
        {
            return GetUserSpecifiedStringArrayUserLength(arrayLengthPrompt, "New String Array!", "Enter String", false);
        }

        public static string[] GetUserSpecifiedStringArrayUserLength(string arrayLengthPrompt, string newMessage)
        {
            return GetUserSpecifiedStringArrayUserLength(arrayLengthPrompt, newMessage, "Enter String", false);
        }

        public static string[] GetUserSpecifiedStringArrayUserLength(string arrayLengthPrompt, string newMessage, string prompt)
        {
            return GetUserSpecifiedStringArrayUserLength(arrayLengthPrompt, newMessage, prompt, false);
        }

        public static string[] GetUserSpecifiedStringArrayUserLength()
        {
            return GetUserSpecifiedStringArrayUserLength("Enter Array Length:", "New String Array!", "Enter String", false);
        }
        #endregion
    }
}
