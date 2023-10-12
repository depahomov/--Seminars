/* Д/З 7. Задача 1. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n 
(размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают 
на минимальную и максимальную границы случайных чисел.

Также, задайте метод PrintArray, который выводил бы массив на экран.

Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] 
с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого 
элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом 
табуляции при выводе.

m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

0,5    7    -2    -0,2
1    -3,3    8    -9,9
8    7,8    -7,1    9
 */

/*
int InputInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    // Введите свое решение ниже
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(minLimitRandom, maxLimitRandom) + rnd.NextDouble();
        }
    }
    return array;
}


    void PrintArray(double[, ] matrix)
{
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]:f2}\t");
            Console.WriteLine();
        }
}

int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество стоблцов: ");
int min = InputInteger("Введите минимальное значение диапазона: ");
int max = InputInteger("Введите максимальное значение диапазона: ");

double[,] myArray = CreateRandomMatrix(rows, columns, min, max);
PrintArray(myArray);
*/
/*
Задача 2.
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, 
FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
с каждым новым элементом увеличивающимся на определенное число. 
Метод принимает на вход три числа 
(n - количество строк матрицы, m - количество столбцов матрицы, 
k - число, на которое увеличивается каждый новый элемент) 
и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом 
CreateIncreasingMatrix матрицу. 
Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.

Метод FindNumberByPosition принимает на вход сгенерированную матрицу 
и числа x и y - позиции элемента в матрице. Если указанные координаты 
находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: 
значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, 
что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition 
и числа x и y - позиции элемента в матрице. Метод должен проверить, 
был ли найден элемент в матрице по указанным координатам (x и y), 
используя результаты из метода FindNumberByPosition. Если такого элемента нет, 
вывести на экран "There is no such index". 
Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
*/
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
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }

}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    // Введите свое решение ниже
    int[,] array = new int[n, m];
    int temp = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = temp;
            temp += k;
        }
    }
    return array;
}

/*
int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    // Введите свое решение ниже


}

public static void PrintCheckIfError(int[] results, int X, int Y)
{
    // Введите свое решение ниже


}
*/
int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество стоблцов: ");
int number = InputInteger("Введите число, на которое увеличивается каждый новый элемент: ");

int[,] myArray = CreateIncreasingMatrix(rows, columns, number);
PrintArray(myArray);