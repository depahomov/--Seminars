// Напишите програму, которая принимает на вход число и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

/*
int DigitCount(int num)
{
    num = Math.Abs(num);
    int count = 1;
    while(num > 10)
    {
        num /= 10;
        count++;
    }
    return count;
}

System.Console.Write("Input num:  ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DigitCount(num));
*/

// Напишите программу, которая выводит массив из N элементов,
// заполненный случайными числами в указанном диапазоне.

// {0, 1, 65, 2, 4}


/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; //инициалицация массива размером size
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] +" ");
    }
    System.Console.WriteLine();
}


System.Console.Write("Input size:  ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value:  ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value:  ");
int max = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(size, min, max));
*/

//Задача 3
// Найти сумму чисел от 1 до А

/*
void SumNumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    System.Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
}

System.Console.Write("Input N:  ");
int n = Convert.ToInt32(Console.ReadLine());
SumNumbers(n);
*/


//Задача 4
// Найти произведение чисел от 1 до N

//вариант 1
/*
void Factorial (int num)
{
    int multiplication = 1;
    for (int i = 2; i <= num; i++)
    {
        multiplication*=i; //умножение на i и присваивание значения
    }
    System.Console.WriteLine($"Факториал {num} = {multiplication}");
}
*/

//вариант 2
int Factorial (int num)
{
    int multiplication = 1;
    for (int i = 2; i <= num; i++)
    {
        multiplication*=i; //умножение на i и присваивание значения
    }
    return multiplication;
}

System.Console.Write("Input N:  ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Факториал {n} = {Factorial(n)}");
