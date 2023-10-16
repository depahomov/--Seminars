// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//   3, 5 -> 243 (3⁵)
//   2, 4 -> 16

System.Console.WriteLine("Задача 25. Возведение числа А в степень В.");
int DegreeOfNumber (int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

System.Console.Write("Input A:  ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input B:  ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{a} to the degree of {b} = {DegreeOfNumber(a, b)}");
System.Console.WriteLine();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//      452 -> 11
//      82 -> 10
//      9012 -> 12

System.Console.WriteLine("Задача 27. Сумма цифр в числе.");
int SumOfDigitsInNumber(int number)
{
    number = Math.Abs(number);
    int digit = 0;
    int sum = 0;
    while (number > 0)
    {
        digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    return sum;
}

System.Console.Write("Input N:  ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Cумма цифр в числе {num} = {SumOfDigitsInNumber(num)}");
System.Console.WriteLine();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//      1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//      6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Задача 29. Задание массива из 8 элементов и вывод его на экран.");
int[] CreateRandomArray(int minValue, int maxValue)
{
    int[] array = new int[8]; //инициалицация массива из 8 элементов
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        System.Console.Write(array[i]);
        if (i < 7)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine("]");
}


System.Console.Write("Введите минимальное значение элемента:  ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите максимальное значение элемента:  ");
int max = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(min, max));