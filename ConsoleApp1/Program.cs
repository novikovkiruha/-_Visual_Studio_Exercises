using System;

namespace ConsoleApp1
{
    class Program
    {

        public static void task1_NumberParity() //Проверить, является ли введенное число четным.
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("{0} - Even number", number);
            else Console.WriteLine("{0} - Odd number", number);
        }

        public static void task2_MinAndMaxValues() //Ввести 3 числа. Вывести: Максимальное и Минимальное число
        {
            Console.Write("Enter 3 numbers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

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

        public static void task3_DaysAndWeeks() //Ввести количество дней. Вывести: Количество недель и остаток дней
        {
            Console.Write("Enter a number of days: ");
            int daysNumber = int.Parse(Console.ReadLine());

            int weeks = daysNumber / 7;
            int days = daysNumber % 7;
            Console.WriteLine("{0} week(s) and {1} day(s)", weeks, days);
        }

        /*Поменять местами две целочисленных переменных:
        а) С использованием третьей переменной;
        б) Без использования третьей переменной*/
        public static void task4_NumbersSwap()
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

            /*Ввести количество метров, вывести количество сантиметров или киллометров в зависимости от выбора пользователя
            Реализовать меню:
            1) Перевести метры в киллометры
            2) Перевести метры в сантиметры
            Другие варианты - ошибка*/
        public static void task5_ConvertFromMeters()
        {
            Console.Write("Enter a number of meters: ");
            int meters = Convert.ToInt32(Console.ReadLine());
            int cm;
            double km;
            Console.Write("Enter 'cm' for centimeters or 'km' for kilometers: ");
            string measure = Console.ReadLine();

            if (measure == "cm")
            {
                cm = meters * 100;
                Console.WriteLine("{0} m = {1} cm", meters, cm);
            }
            else if (measure == "km")
            {
                km = (double)meters / 1000;
                Console.WriteLine("{0} m = {1} km", meters, km);
            }
            else Console.WriteLine("Wrong measure. Try again...");
        }

        /*Дана комната без окон и дверей.В комнате на стены необходимо поклеить обои.
        Пользователь вводит:
        1) Длину и ширину рулона обоев
        2) Высоту, ширину и длинну комнаты
        Расчитать сколько рулонов обоев нужно для поклейки:
        1) С использованием остатков
        2) Без использования остатков
        Выбор варианта поклейки предоставить пользователю*/
        public static void task6_roomAndWallpaper()
        {
            Console.Write("Enter a wallpaper length: ");
            int wpLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a wallpaper width: ");
            int wpWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a room height: ");
            int roomHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a room width: ");
            int roomWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a room length: ");
            int roomLength = Convert.ToInt32(Console.ReadLine());

            // without remainder
            int wpArea = wpLength * wpWidth;
            int roomArea = ((roomWidth + roomLength) * 2) * roomHeight;
        }


        static void Main(string[] args)
        {
            //task1_NumberParity();
            //task2_MinAndMaxValues();
            //task3_DaysAndWeeks();
            //task4_NumbersSwap();
            //task5_ConvertFromMeters();
            task6_roomAndWallpaper();
        }
    }
}
