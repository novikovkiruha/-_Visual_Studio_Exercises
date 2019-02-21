using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        //Проверить, является ли введенное число четным.
        public static void task1_NumberParity()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("{0} - Even number", number);
            else Console.WriteLine("{0} - Odd number", number);
        }

        //Ввести 3 числа. Вывести: Максимальное и Минимальное число
        public static void task2_MinAndMaxValues()
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

        //Ввести количество дней. Вывести: Количество недель и остаток дней
        public static void task3_DaysAndWeeks()
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
            double wpLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a wallpaper width: ");
            double wpWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a room height: ");
            double roomHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a room width: ");
            double roomWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a room length: ");
            double roomLength = Convert.ToInt32(Console.ReadLine());

            // with remainder
            double wpArea = wpLength * wpWidth;
            double roomArea = (roomWidth * roomHeight + roomLength * roomHeight) * 2;

            double rollsWithRemainder = roomArea / wpArea;
            Console.WriteLine($"Rolls with remainders: {rollsWithRemainder}");

            // without remainder
            double rollsWithoutRemainder = 0;
            if (wpLength >= roomHeight)
            {
                //rollsWithoutRemainder = Math.Ceiling(roomArea / wpArea);
                rollsWithoutRemainder = Math.Ceiling((roomLength + roomWidth) / wpWidth);
            } else
            {
                double k = Math.Ceiling(roomHeight / wpLength);
                rollsWithoutRemainder = Math.Ceiling((roomLength + roomWidth) / wpWidth) * k;
            }
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
            Console.WriteLine("Enter the numbers or 'ok' to exit: ");
            int sum = 0;
            while (true)
            {
                String numbers = Console.ReadLine();
                if (numbers == "ok") break;
                sum += Convert.ToInt32(numbers);
            }
            Console.WriteLine($"Sum of entered numbers = {sum}");
        }

        //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void task12_Factorial()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= number; i++)
                factorial *= i;
            Console.WriteLine(factorial);
        }

        /*13) Пользователь вводит с клавиатуры целое число в одну строку, необходимо:
        а) показать сколько в данном числе цифр
        б) перевернуть число и вывести на экран (было 12345 стало 54321)
        в) показать на экран сумму цифр в числе*/
        public static void task13_EnteredNumber()
        {
            Console.Write("Enter a number: ");
            string text = Console.ReadLine();
            Console.WriteLine($"The length of the entered number: {text.Length}");
            int number = Convert.ToInt32(text);

            int swappedNumber = 0;
            int sum = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                swappedNumber *= 10;
                swappedNumber += remainder;
                sum += remainder;
                number /= 10;
            }
            Console.WriteLine($"Swapped number: {swappedNumber}\nSum: {sum}");

            //char[] array = text.ToCharArray();
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += Convert.ToInt32(array[i]);
            //    Console.WriteLine($"Array element: {array[i]}");
            //    Console.WriteLine($"Sum: {sum}");
            //}
            //Array.Reverse(array);
            //Console.WriteLine(sum);
            //Console.WriteLine(array);
            //Console.WriteLine(array.Length);
        }

        /*14) Разработать программу, которая выводит на экран линию из символов.
        Число символов, какой использовать символ, и какая будет линия - вертикальная, или горизонтальная - указывает пользователь.*/
        public static void task14_SymbolLine()
        {
            Console.Write("Enter a number of symbols: ");
            int symbolNumbers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a symbol type: ");
            char symbolType = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a symbol line: 'h' - horizontal or 'v' - vertical: ");
            char symbolLine = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < symbolNumbers; i++)
            {
                if (symbolLine == 'h')
                    Console.Write($"{symbolType} ");
                else if (symbolLine == 'v')
                    Console.WriteLine($"{symbolType}");
                else
                {
                    Console.WriteLine("Wrong symbol line");
                    break;
                }
            }
            Console.WriteLine();
        }

        //15) Написать программу, которая находит сумму всех целых нечетных чисел в диапазоне, указанном пользователем.
        public static void task15_SumOfOddNumbers()
        {
            Console.Write("Enter the first and lower number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second and higher number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine(sum);
        }

        //17) Написать программу, которая находит сумму всех целых чисел от n до m включительно.
        public static void task17_SumOfNumbers()
        {
            Console.Write("Enter the first and lower number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second and higher number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        /*18) Если сумма трех x,y,z различных числел больше 100, то наименьшее из этих чисел - заменить полусуммой двух других, 
        иначе - меньшее из x и y заменить суммой оставшихся.*/
        public static void task18_ThreeNumbers()
        {
            double x, y, z;
            Console.WriteLine("Enter three numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Entered numbers\nX: {x}\nY: {y}\nZ: {z}");
            double sum = x + y + z;

            if (sum > 100)
            {
                if (x < y && x < z)
                    x = (y + z) / 2;
                else if (y < z)
                    y = (x + z) / 2;
                else
                    z = (x + y) / 2;
                Console.WriteLine($"Changed numbers\nX: {x}\nY: {y}\nZ: {z}");
            }
            else
            {
                if (x > y)
                    y = x + z;
                else if (x < y)
                    x = y + z;
                Console.WriteLine($"Changed numbers\nX: {x}\nY: {y}\nZ: {z}");
            }
        }

        /*19) На часах h часов m минут и s секунд. Вывести время через одну секунду.*/
        public static void task19_Delay()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time);
            int h = time.Hour;
            int m = time.Minute;
            int s = time.Second;
            int[] array = new[] { h, m, s };
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Thread.Sleep(1000);
            }
        }

        //20) Пользователь вводит 4-х-значное число, поменять местами 1 с 2 и 3 с 4 цифры.Если число не 4-х значное - вывести сообщение.
        public static void task20_4DigitNumber()
        {
            Console.Write("Enter a 4-digit number: ");
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);
            int[] array = new int[n.Length];
            
            if (n.Length == 4)
            {
                for (int i = n.Length-1; i >= 0; i--)
                {
                    array[i] = number % 10;
                    number /= 10;
                    Console.WriteLine(array[i]);
                }

                int temp = 0;
                temp = array[0];
                array[0] = array[1];
                array[1] = temp;
                temp = array[2];
                array[2] = array[3];
                array[3] = temp;
                string result = string.Concat(array);
                Console.WriteLine(result);

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
            } else
                Console.WriteLine("Not a 4-digit number. Try again...");
        }

        //21) Пользователь вводит 6-ти значное число, определить является ли число счастливым(сумма первых 3-х цифр равна сумме вторых 3-х цифр).
        public static void task21_6DigitNumber()
        {
            Console.Write("Enter a 6-digit number: ");
            string number = Console.ReadLine();
            int n = Convert.ToInt32(number);
            int[] array = new int[number.Length];

            if (number.Length == 6)
            {
                int sum1 = 0, sum2 = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    array[i] = n % 10;
                    n /= 10;
                }
                sum1 = array[0] + array[1] + array[2];
                sum2 = array[3] + array[4] + array[5];

                if (sum1 == sum2)
                {
                    Console.WriteLine("Lucky number");
                }
                else Console.WriteLine("Better luck next time");
            }
            else
                Console.WriteLine("Not a 6-digit number. Try again...");
        }

        //22) С клавиатуры вводятся n чисел.
        //Составьте программу, которая определяет кол-во отрицательных, кол-во положительных и кол-во нулей среди введеных чисел.
        //Значение n вводится с клавиатуры.
        public static void task22_PositiveNegative()
        {
            Console.Write("Enter a number of digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int negative = 0;
            int positive = 0;
            int zero = 0;

            Console.WriteLine("Enter the different digits:");
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    zero++;
                else if (number > 0)
                    positive++;
                else if (number < 0)
                    negative++;
            }
            Console.WriteLine($"Positive: {positive}\nNegative: {negative}\nZero: {zero}");
        }

        //23) Сколько нечетных среди n введенных
        public static void task23_EvenOdd()
        {
            Console.Write("Enter a number of digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int odd = 0;
            int even = 0;
            int zero = 0;

            Console.WriteLine("Enter the different digits:");
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    zero++;
                else if (number % 2 == 0)
                    even++;
                else if (number % 2 != 0)
                    odd++;
            }
            Console.WriteLine($"Even: {even}\nOdd: {odd}\nZero: {zero}");
        }

        //24) Вывод всех двухзначных чисел, кратных 5
        public static void task24_MultipleOf()
        {
            Console.WriteLine("The 2-digit numbers are multiple of 5");
            for (int i = 10; i <= 99; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
        }

        //25) Найти сумму цифр целого положительного числа
        public static void task25_PositiveNumbersSum()
        {
            Console.Write("Enter a positive number: ");
            string numberText = Console.ReadLine();
            int number = Convert.ToInt32(numberText);
            int[] array = new int[numberText.Length];

            int sum = 0;
            if (number > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = number % 10;
                    number /= 10;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine(sum);
            } else
                Console.WriteLine("Wrong number. Please, enter a positive one.");
        }

        //26) Найти max из введенных чисел
        public static void task26_MaxNumber()
        {
            Console.Write("Enter a number of digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            int max = 0;
            Console.WriteLine("Enter the different digits:");
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > max)
                    max = number;
            }
            Console.WriteLine($"Max number is {max}");
        }

        //27) Есть ли среди введенных число k
        public static void task27_SearchedNumber()
        {
            Console.Write("Enter a number of digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a searched number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the different digits:");
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }

            foreach (int i in array)
            {
                if (i == k)
                    Console.WriteLine($"{k} is in the list");
                else
                    Console.WriteLine($"{k} is NOT in the list");
            }
        }

        //28) Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.
        public static void task28_NaturalNumbers()
        {
            for (int i = 20; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    Console.WriteLine(i);
            }
        }

        //29) Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно.
        public static void task29_NumberSquares()
        {
            for (int i = 10; i <= 20; i++)
                Console.WriteLine(i*i);
        }

        //30) Пользователь вводит число. Определить количество цифр в числе и наибольшую цифру числа.
        public static void task30_NumberOfDigitsAndMax()
        {
            Console.Write("Enter a number: ");
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);
            int[] array = new int[n.Length];

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number % 10;
                number /= 10;
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine($"Number of digits: {n.Length}\nMax number: {max}");
        }

        //31) Найдите все четырехзначные числа, сумма цифр каждого из которых равна 15.

        //32) Одноклеточная амеба каждые 3 часа делится на 2 клетки.Определить, сколько амеб будет через 3, 6, 9, 12,..., 24 часа.

        //33) Начав тренировки, лыжник в первый день пробежал 10 км.Каждый следующий день он увеличивал пробeг на 10% от пробега предыдущего дня.Определить в какой день суммарный пробег за все дни превысит 100 км.

        static void Main(string[] args)
        {
            //task1_NumberParity();
            //task2_MinAndMaxValues();
            //task3_DaysAndWeeks();
            //task4_NumbersSwap();
            //task5_ConvertFromMeters();
            task6_roomAndWallpaper();
            //task7_Triangles();
            //task8_ValidNumber();
            //task9_ImageFrame();
            //task10_DivisibleNumber();
            //task11_EnteredNumberSum();
            //task12_Factorial();
            //task13_EnteredNumber();
            //task14_SymbolLine();
            //task15_SumOfOddNumbers();
            //task17_SumOfNumbers();
            //task18_ThreeNumbers();
            //task19_Delay();
            //task20_4DigitNumber();
            //task21_6DigitNumber();
            //task22_PositiveNegative();
            //task23_EvenOdd();
            //task24_MultipleOf();
            //task25_PositiveNumbersSum();
            //task26_MaxNumber();
            //task27_SearchedNumber();
            //task28_NaturalNumbers();
            //task29_NumberSquares();
            //task30_NumberOfDigitsAndMax();

            //task34_OneArraySort();
            //task35_TwoArraySort();
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

        //Сортировка двумерного массива
        public static void task35_TwoArraySort()
        {
            int[,] array = { { 9, 5, 6 }, { 2, 4, 1 }, { 8, 7, 3 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int temp;

            for (int i = 0; i < rows; i++)
            {
                //for (int j = columns - 1; j >= 0; j--)
                for (int j = 0; j < columns; j++)
                {
                    for (int k = columns-1; k >= 0; k--)
                    //for (int k = 0; k < j; k++)
                    {
                        if (array[i, k] > array[i, k + 1])
                        {
                            temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                        Console.Write(array[i, j] + " ");
                        Console.Write(array[i, k] + " ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
    }
}
