using System;

// Тестирование 

namespace UnitTestsExample.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFromConsole;
            do
            {
                Console.WriteLine("Введите что-нибудь");
                textFromConsole = Console.ReadLine();
            } while (SimpleClass.IsEmpty(textFromConsole));

            if (textFromConsole == "ololo")
            {
                Console.WriteLine("Вы молодец. Мы рассчитаем для вас сумму двух чисел");
                var a = SimpleClass.InputAndCheckStingForAddition("Введите первое число");
                var b = SimpleClass.InputAndCheckStingForAddition("Введите второе число");
                var c = int.Parse(a) + int.Parse(b);
                Console.WriteLine("Сумма двух чисел = " + c);
            }
            else
            {
                Console.WriteLine("Вы ввели " + textFromConsole);
            }
        }
    }
}