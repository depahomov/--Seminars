/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr, minValue, maxValue)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //от 1 до 9
        }
    }
}
System.Console.WriteLine("Инициализация массива и вывод на экран:");
int[,] matix = new int[3, 4];
PrintArray(matix);
System.Console.WriteLine();

System.Console.WriteLine("Заполнение массива случайными числами от 1 до 9 и вывод на экран:");
FillArray(matix);
PrintArray(matix);
*/

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}

int[,] matix = new int[3, 4];
System.Console.WriteLine("Заполнение массива числами и вывод на экран:");
FillArray(matix);
PrintArray(matix);
*/

/*
Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

/* - не получилось
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateArray(int rows, int columns)
{
    int[,] matr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

void ConverseArray(int[,] matr)
{
    for (int i = 2; i < matr.GetLength(0); i++)
    {
        for (int j = 2; j < matr.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
            {
                matr[i, j] = matr[i, j] * matr[i, j];
            }
        }
    }
}

int[,] matrix = CreateArray(5, 5);

PrintArray(matrix);
System.Console.WriteLine();

ConverseArray(matrix);
PrintArray(matrix);
*/


/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/


int InputInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(minValue, maxValue + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество стоблцов: ");
int min = InputInteger("Введите минимальное значение диапазона: ");
int max = InputInteger("Введите максимальное значение диапазона: ");
int[,] arr = Create2DArray(rows, columns);
Fill2DArray(arr, min, max);
Print2DArray(arr);

/*
int FindMinimum(int[,] array)
{
    if (array.GetLength(0) < array.GetLength(1)) 
        return array.GetLength(0);
    else
        return array.GetLength(1);
}
int GetSumMainDiagonal(int[,] array)
{
    int minSize = FindMinimum(array);
    int sum = 0;

    for (int i = 0; i < minSize; i++)
    {
        sum += array[i, i];
    }

    return sum;
}
*/

// int a = rnd.