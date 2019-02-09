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

            // with remainder
            int wpArea = wpLength * wpWidth;
            int roomArea = (roomWidth + roomHeight) * 2 + (roomLength * roomHeight) * 2;

            double rollsWithRemainder = (double)roomArea / wpArea;
            Console.WriteLine($"Rolls with remainders: {rollsWithRemainder}");

            // without remainder
            double rollsWithoutRemainder = Math.Ceiling((double)roomArea / wpArea);
            Console.WriteLine($"Rolls without remainders: {rollsWithoutRemainder}");
        }

        //Даны три стороны треугольника, вывести на экран: существует ли такой треугольник и его тип(равносторонний, равнобедренный, прямоугольный, разносторонний).
        public static void task7_Triangles()
        {
            Console.WriteLine("Enter the 3 sides of triangles: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Equilateral triangle (равносторонний треугольник)");
            }
            else if (side1 > side2 + side3 && side2 > side1 + side3 && side3 > side1 + side2)
            {
                Console.WriteLine("Triangle with such sides doesn't exist");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Isosceles triangle (равнобедренный треугольник)");
            }
            else if (side1 * side1 == side2 * side2 + side3 * side3 || side2 * side2 == side1 * side1 + side3 * side3 || side3 * side3 == side2 * side2 + side1 * side1)
            {
                Console.WriteLine("Right triangle (прямоугольный треугольник)");
            }
            else if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                Console.WriteLine("Versatile triangle (разносторонний треугольник)");
            }
            else
            {
                Console.WriteLine("Another type of triangle");
            }
        }

        /*Write a program and ask the user to enter a number.
        The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
        (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/
        public static void task8_ValidNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10) Console.WriteLine("Valid number");
            else Console.WriteLine("Invalid number");
        }

        //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
        public static void task9_ImageFrame()
        {
            Console.Write("Enter a height of image: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a width of image: ");
            int width = Convert.ToInt32(Console.ReadLine());

            if (height > width) Console.WriteLine("Portrait image");
            else Console.WriteLine("Landscape image");
        }

        /*Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.*/
        public static void task10_DivisibleNumber()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % number == 0) count++;
            }

            Console.WriteLine($"{count} numbers are divisible by {number} without remainder in range between 1 and 100");
        }

        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
        public static void task11_EnteredNumberSum()
        {
            //int[] array;

            Console.WriteLine("Enter the numbers or 'ok' to exit");
            int sum = 0;
            string number;
            do
            {
                number = Console.ReadLine();
                sum += Convert.ToInt32(number);
            } while (number != "ok");
        }

        //Сортировка одномерного массива
        public static void task34_OneArraySort()
        {
            int[] arraySort = new int[5];

            Console.WriteLine("Enter 5 different numbers");
            for (int i = 0; i < arraySort.Length; i++)
            {
                arraySort[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < arraySort.Length; i++)
            {
                for (int j = i + 1; j < arraySort.Length; j++)
                {
                    if (arraySort[i] > arraySort[j])
                    {
                        temp = arraySort[i];
                        arraySort[i] = arraySort[j];
                        arraySort[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arraySort.Length; i++)
            {
                Console.WriteLine(arraySort[i]);
            }

        }

        public static void task35_TwoArraySort()
        {
            int[,] array = { { 9, 5, 6 }, { 2, 4, 1 }, { 8, 7, 3 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int temp;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = columns - 1; j >= 0; j--)
            //    {
            //        Console.Write(array[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        for (int k = columns - 1; k >= j; k--)
            //        {

            //            Console.Write(array[i, j]);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < rows; i++)
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    //x = array[i, j];
                    //Console.Write(array[i, j]);
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write(array[i, j]);
                        if (array[i, k] > array[i, k+1])
                        {
                            temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                        Console.Write(array[i, j]);
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }

        

            static void Main(string[] args)
        {
            //task1_NumberParity();
            //task2_MinAndMaxValues();
            //task3_DaysAndWeeks();
            //task4_NumbersSwap();
            //task5_ConvertFromMeters();
            //task6_roomAndWallpaper();
            //task7_Triangles();
            //task8_ValidNumber();
            //task9_ImageFrame();
            //task10_DivisibleNumber();
            //task11_EnteredNumberSum();
            //task34_OneArraySort();
            task35_TwoArraySort();
        }
    }
}
