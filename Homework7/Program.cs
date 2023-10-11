﻿/* Д/З 7. Задача 1. 
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