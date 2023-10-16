/*
 (//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2
 */

/*
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
    {
        System.Console.WriteLine("Index of row is out of bound!");
    }
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

System.Console.Write("Input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input num of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


System.Console.Write("Input num of first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input num of second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
ChangeRows(myArray, row1, row2);
Print2DArray(myArray);

*/

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7


int InputInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
}

// void RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1)) System.Console.WriteLine("Invalid array!");
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < array.GetLength(0); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
// }


// ---------------------------------------------------------------------
//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент (заменяем нулями)

int[,] DeleteRoesAndColumnWithMin(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(0); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }

    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, minJ] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[minI, j] = 0;
    }
    return array;
}


int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество столбцов: ");
int minValue = InputInteger("Введите минимальное значение элемента массива: ");
int maxValue = InputInteger("Введите максимальное значение элемента массива: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
System.Console.WriteLine("Исходный массив:");
PrintArray(myArray);
System.Console.WriteLine();
DeleteRoesAndColumnWithMin(myArray);
System.Console.WriteLine("Изменённый массив:");
PrintArray(myArray);





