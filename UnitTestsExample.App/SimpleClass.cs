using System;

namespace UnitTestsExample.App
{
    public class SimpleClass
    {
        public static bool IsEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ничего не ввели");
                return true;
            }
            return false;
        }

        public static bool IsDigitOnly(string text)
        {
            foreach (char t in text)
            {
                if (t < '0' || t > '9')
                {
                    Console.WriteLine("Вы ввели не цифры, как мы будем их складывать?");
                    return false;
                }
            }
            return true;
        }

        public static bool IsLengthLessMaxIntLength(string text)
        {
            var intLength = int.MaxValue.ToString().Length;
            if (text.Length >= intLength - 1)
            {
                Console.WriteLine($"Вы ввели очень большое значение. Больше, чем {intLength - 1}");
                return false;
            }
            return true;
        }

        public static string InputAndCheckStingForAddition(string message)
        {
            string a;
            do
            {
                Console.WriteLine(message);
                a = Console.ReadLine();
            } while (IsEmpty(a) || !IsDigitOnly(a) || !IsLengthLessMaxIntLength(a));
            return a;
        }
    }
}