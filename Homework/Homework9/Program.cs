// Урок 9. Рекурсия

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbersFromNto1(int n)
{
    if (n > 1)
    {
        System.Console.Write(n + ", ");
        ShowNumbersFromNto1(n - 1);
    }
    else System.Console.Write(n);
}
int n = 12;
System.Console.WriteLine("Вывод натуральных чисел от N до 1:");
System.Console.Write($"N = {n} -> ");
ShowNumbersFromNto1(n);
System.Console.WriteLine();
System.Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbersFromMtoN(int m, int n)
{
    if (n != m)
    {
        if (m > n)
        {
            return SumNumbersFromMtoN(m - 1, n) + m;
        }
        else
        {
            return SumNumbersFromMtoN(m, n - 1) + n;
        }
    }
    else return m;
}

System.Console.WriteLine("Нахождение суммы натуральных чисел от M до N:");
int m1 = 2;
int n1 = 5;
System.Console.Write($"M = {m1}; N = {n1} -> ");
System.Console.WriteLine(SumNumbersFromMtoN(m1, n1));
m1 = 5;
n1 = 2;
System.Console.Write($"M = {m1}; N = {n1} -> ");
System.Console.WriteLine(SumNumbersFromMtoN(m1, n1));
System.Console.WriteLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m > 0) && (n == 0))
            return Ackerman(m - 1, 1);
        else
            return Ackerman(m - 1, Ackerman(m, n - 1));
    }

}

System.Console.WriteLine("Нахождение функции Аккермана A(m, n):");
int m2 = 0;
int n2 = 1;
System.Console.Write($"m = {m2}; n = {n2} -> ");
System.Console.WriteLine(Ackerman(m2, n2));
m2 = 1;
n2 = 0;
System.Console.Write($"m = {m2}; n = {n2} -> ");
System.Console.WriteLine(Ackerman(m2, n2));
m2 = 2;
n2 = 3;
System.Console.Write($"m = {m2}; n = {n2} -> ");
System.Console.WriteLine(Ackerman(m2, n2));
m2 = 3;
n2 = 2;
System.Console.Write($"m = {m2}; n = {n2} -> ");
System.Console.WriteLine(Ackerman(m2, n2));
System.Console.WriteLine();
