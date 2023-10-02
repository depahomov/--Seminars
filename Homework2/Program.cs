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
int numAbs = Math.Abs(num);
if (numAbs > 99 & numAbs < 1000)
{
   System.Console.WriteLine($"{num} -> {ShowSecondDigit(numAbs)}");
}
else
{
    System.Console.WriteLine("Введённое число не трёхзначное!");
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Вывод третьей цифры заданного числа (при её наличии)");

int ShowThirdDigit(int number1)
{
    while (number1 > 999)
    {
        number1 = number1 / 10;
    }
    number1 = number1 % 10;
    return number1;
}

System.Console.Write("Введите целое число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num1Abs = Math.Abs(num1);
if (num1Abs > 99)
{
    System.Console.WriteLine($"{num1} -> {ShowThirdDigit(num1Abs)}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}

