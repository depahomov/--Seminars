// -----Задача 1.  Сортировка строк матрицы по убыванию---------


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
            System.Console.Write(matrix[i, j] + "\t");
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


System.Console.WriteLine("Матрица 1:");
int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество столбцов: ");
int minValue = InputInteger("Введите минимальное значение элемента массива: ");
int maxValue = InputInteger("Введите максимальное значение элемента массива: ");
int[,] myArray1 = Create2DArray(rows, columns);
Fill2DArray(myArray1, minValue, maxValue);
PrintArray(myArray1);
System.Console.WriteLine();

System.Console.WriteLine("Матрица 2:");
rows = InputInteger("Введите количество строк: ");
columns = InputInteger("Введите количество столбцов: ");
minValue = InputInteger("Введите минимальное значение элемента массива: ");
maxValue = InputInteger("Введите максимальное значение элемента массива: ");
int[,] myArray2 = Create2DArray(rows, columns);
Fill2DArray(myArray2, minValue, maxValue);
PrintArray(myArray2);
System.Console.WriteLine();
