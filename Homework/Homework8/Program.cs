// Задача 1.  Сортировка строк матрицы по убыванию

// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. 
// Он принимает на вход двумерный массив целых чисел matrix 
// и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку 
// матрицы так, чтобы элементы в каждой строке шли по убыванию.

// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

// На выходе:
// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6    

// Матрица с упорядоченными по убыванию строками:
// 9   7   1   
// 3   2   1   
// 6   5   4

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

void SortRowsDescending(int[,] matrix)
    {
// Введите свое решение ниже
        

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