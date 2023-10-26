using System;
// алгоритмическая сложность

// double s = 0;

// for (int n = 0; n < 130; n++)
// {
//     int count = 0;
//     int  i = n; 
//     while (i > 0)
//     {
//         count++;
//         s += i;
//         i = i / 2;
//     } 
//     System.Console.WriteLine($"n: {n}   count: {count}");
// }

// сложность алгоритма O(log2(x) + 1)

// int n = Random.Shared.Next(10000000);

// double s = 0;

// int i = n;
// for (int j = 2; j < n / 2; j++) // n/2 - 2
// {
//     while (i > 0)
//     {
//         //s += i;
//         i = i / 2;  // log(n) + 1
//     } 
// }
// сложность алгоритма: 
// f(n) * g(n) = (n/2 - 2) * (log2(n) + 1) = n/2*log(n) + n/2 - 2*log(n) - 2 =>
// =>  1/2*n*log(n) + 1/2*n - 2*log(n) - 2 => упроощаем => O(n*log(n))

// ----------- Сортировка выбором ------------------
int[] SortSelectionMinToMax(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}

int[] SortSelectionMaxToMin(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] > collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}


var arr = new int[] { 9, 6, 8, 5, 7, 3, 1, 2, };
System.Console.WriteLine(string.Join(' ', arr));
SortSelectionMinToMax(arr);
System.Console.WriteLine(string.Join(' ', arr));
SortSelectionMaxToMin(arr);
System.Console.WriteLine(string.Join(' ', arr));