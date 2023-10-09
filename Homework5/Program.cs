
/*Напишите программу, которая подсчитывает количество четных элементов 
в массиве целых положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает массив 
целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".

Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
который содержит следующие значения: 
{100, 102, 105, 166, 283, 764, 300, 499, 133}.

Аргументы, передаваемые в метод/функцию:

'124, 378, 593, 821, 456'
На выходе:


Массив:
124     378     593     821     456 
Количество четных элементов: 3
*/
/*
int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count = count + 1;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] myArray = { 124, 378, 593, 821, 456 };
PrintArray(myArray);
System.Console.WriteLine($"Количество чётных элементов: {CountEvenElements(myArray)}");
*/
/*
Напишите программу, которая находит сумму элементов с нечетными индексами 
в одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых чисел 
и возвращает сумму элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Аргументы, передаваемые в метод/функцию:
'18, 76, 11'
На выходе:
18      76      11  
Сумма нечетных элементов: 76
*/

/*
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;


}

int[] myArray = { 1, 3, 5, 8, 4 };
PrintArray(myArray);
System.Console.WriteLine($"Сумма нечётных элементов: {SumOddElements(myArray)}");
*/

/*
Напишите программу для работы с массивом вещественных чисел.

Реализуйте класс ArrayOperations, который содержит следующие статические методы:
FindMax(double[] array): Метод принимает на вход массив вещественных чисел array
и возвращает максимальное число из массива.
FindMin(double[] array): Метод принимает на вход массив вещественных чисел array 
и возвращает минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив 
вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода массива на экран. 
Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:
Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/
double FindMax(double[] array)
{
    int max = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[max]) max = i;
    }
    return array[max];
}

double FindMin(double[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]< array[min]) min = i;
    }
    return array[min];
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    return FindMax(array) - FindMin(array);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}\t");
    }
    System.Console.WriteLine();
}

double[] myArray = { 3.175, 8.945, 2.365, 5.725, 0.855 };
Console.WriteLine("Массив:");
PrintArray(myArray);
double diff = CalcDifferenceBetweenMaxMin(myArray);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");