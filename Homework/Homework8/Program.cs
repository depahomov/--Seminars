
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

// ------ Задача 3 -------
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): 
// Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. 
// Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, 
// то выводится сообщение "It is impossible to multiply." 
// В противном случае, вызывается метод MatrixMultiplication для умножения матриц, 
// и результат выводится с помощью метода PrintMatrix

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{ // Введите свое решение ниже
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    if (columnsA == rowsB) PrintArray(MatrixMultiplication(matrixA, matrixB));
    else System.Console.WriteLine("It is impossible to multiply.");
}

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для 
// умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу, 
// которая представляет собой результат умножения матрицы matrixA 
// на матрицу matrixB.

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{   // Введите свое решение ниже
    int rowsA = matrixA.GetLength(0);
    int rowsB = matrixB.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] matrixC = new int[rowsA, columnsB];
    int tempSum = 0;

    for (int i = 0; i < rowsA; i++)
    {
        for (int k = 0; k < columnsB; k++)
        {
            for (int j = 0; j < rowsB; j++)
            {
                tempSum += matrixA[i, j] * matrixB[j, k];
            }
            matrixC[i, k] = tempSum;
            tempSum = 0;
        }
    }
    return matrixC;
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

MultiplyIfPossible(myArray1, myArray2);