using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberParity();
            //MinAndMaxValues();
            //DaysAndWeeks();
            NumbersSwap();
        }

        public static void NumberParity() //Проверить, является ли введенное число четным.
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            if (int.Parse(number) % 2 == 0) Console.WriteLine("{0} - Even number", number);
            else Console.WriteLine("{0} - Odd number", number);
        }

        public static void MinAndMaxValues() //Ввести 3 числа. Вывести: Максимальное и Минимальное число
        {
            Console.Write("Enter 3 numbers: ");
            string enteredNumber1 = Console.ReadLine();
            string enteredNumber2 = Console.ReadLine();
            string enteredNumber3 = Console.ReadLine();

            int number1 = int.Parse(enteredNumber1);
            int number2 = int.Parse(enteredNumber2);
            int number3 = int.Parse(enteredNumber3);

            int maxValue, minValue;
            if (number1 > number2 && number1 > number3) maxValue = number1;
            else if (number2 > number1 && number2 > number3) maxValue = number2;
            else maxValue = number3;

            if (number1 < number2 && number1 < number3) minValue = number1;
            else if (number2 < number1 && number2 < number3) minValue = number2;
            else minValue = number3;

            //int[] array = new int[] { number1, number2, number3 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    maxValue = array[0];
            //    minValue = array[0];
            //    if (array[i] > maxValue) maxValue = array[i];
            //    else minValue = array[i];

            //}
            Console.WriteLine("{0} is a minimum value and {1} is a maximum value", minValue, maxValue);
        }

        public static void DaysAndWeeks() //Ввести количество дней. Вывести: Количество недель и остаток дней
        {
            Console.Write("Enter a number of days: ");
            string enteredDaysNumber = Console.ReadLine();
            int daysNumber = int.Parse(enteredDaysNumber);

            int weeks = daysNumber / 7;
            int days = daysNumber % 7;
            Console.WriteLine("{0} week(s) and {1} day(s)", weeks, days);
        }

        /*Поменять местами две целочисленных переменных:
        а) С использованием третьей переменной;
        б) Без использования третьей переменной*/
        public static void NumbersSwap()
        {
            int a = 1;
            int b = 2;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0} and b = {1}", a, b);

            int d = 1;
            int e = 2;
            d += e;
            e = d - e;
            d -= e;
            Console.WriteLine("d = {0} and e = {1}", d, e);
        }
    }
}

