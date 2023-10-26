
// void MultiplicationTable(int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         for (int j = 1; j <= n; j++)
//         {
//             Console.SetCursorPosition(i,)
//             System.Console.Write(i*j);
//         }
//         System.Console.WriteLine();
//     }

// }
// MultiplicationTable(9);
//__________________________________________________________________________________

int count = 5;
int[] array = new int[count].Select(value => Random.Shared.Next(0, 10)).ToArray();
Console.WriteLine($"[{string.Join(" ", array)}]");

// Алгоритм вывода числа в консоль:
Console.WriteLine(array[3]);
// Сложность алгоритма O(n) = 1.
// Используем упрощенную запись сложности O(1)

// Алгоритм нахождения суммы элементов массива:
int sum = array.Sum();
// Сложность алгоритма O(n) = n
// Количество операций прямо пропорционально n
// Используем упрощенную запись сложности O(n)

// Если массив представляет собой арифметическую прогрессию,
// можно использовать формулу n*(max-min)/2.
// Сложность решения будет O(n) = 1.
// Используем упрощенную запись O(1).

// Алгоритм составления таблицы умножения для первых n чисел:
int[,] MultiplyTable(int n)
{
    int[,] result = new int[n + 1, n + 1];
    for (int i = 0; i <= n; i++)
    {
        for (int j = 0; j <= n; j++)
        {
            result[i, j] = i * j;
        }
    }
    return result;
}
// Сложность алгоритма составляет O(n) = (n)^2.
// Используем упрощенную запись O(n^2).

// Делаем алгоритм составления таблицы умножения быстрее

int[,] MultiplyTableFast(int n)
{
    int[,] result = new int[n + 1, n + 1];
    for (int i = 0; i <= n; i++)
    {
        for (int j = i; j <= n; j++)
        {
            result[i, j] = i * j;
            result[j, i] = result[i, j];
        }
    }
    return result;
}
// Сложность алгоритма составляет O(n) = (n)*(n/2)
// Упрощенная запись O(n^2/2)

// Выводит матрицу в консоль
void ShowMatrix(int[,] matrix, string message = "")
{
    Console.WriteLine(message);
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);
    Console.Write("\t");
    for (int j = 0; j < colsCount; j++)
    {
        Console.Write($"{j}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < rowsCount; i++)
    {
        Console.Write($"{i}:     ");
        for (int j = 0; j < colsCount; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] table1 = MultiplyTable(7);
ShowMatrix(table1, "Таблица умножения:");
int[,] table2 = MultiplyTableFast(7);
ShowMatrix(table2, "Таблица умножения ускоренная:");