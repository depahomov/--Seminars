//Урок 2. Базовые алгоритмы

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
System.Console.WriteLine("Вывод второй цифры из трёхзначного числа");
int ShowSecondDigit(int number)
{
    number = number / 10;
    number = number % 10;
    return number;
}

System.Console.Write("Введите трёхзначное число:  ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{num} -> {ShowSecondDigit(num)}");