﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    //System.Console.WriteLine();
}

int[] InputArray(int m) //метод ввода элементов массива с клавиатуры
{
    int[] array = new int[m];
    Console.WriteLine("Ввод элементов массива:");
    for (int i = 0; i < m; i++)
    {
        Console.Write($"array[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumOfPositiv(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

System.Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = InputArray(m);
PrintArray(myArray);
System.Console.WriteLine($" -> {SumOfPositiv(myArray)}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

