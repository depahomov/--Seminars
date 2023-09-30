/*
написать программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно первому,
то программа выводит остаток от деления

34, 5  -> не кратно, остаток от деления 4
16, 4  -> кратно
*/

/*
void CheckMultiplicity(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}, {num2} -> кратно");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
    }
}

System.Console.Write("Input first number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number:  ");
int n2 = Convert.ToInt32(Console.ReadLine());

CheckMultiplicity(num1, n2);
*/

/*
Напишите программу, которая выводит случайное число из отрезка [10,99]
и показывает наибольшую цифру числа

78 -> 8
12 -> 2
85 -> 8
*/

/*
using System.Runtime.Serialization;

int BiggestDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
    
}

int num = new Random().Next(10, 100);
//int result = BiggestDigit(num);
System.Console.WriteLine($"{num} -> {BiggestDigit(num)}");
*/

/*
Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/

/*
int DeleteSecondDigit(int number)
{
    int ed = number % 10;
    int sotni = number / 100;
    int result = sotni * 10 + ed;
    return result;
}

int chislo = new Random().Next(100, 1000);
System.Console.WriteLine($"{chislo} -> {DeleteSecondDigit(chislo)}");
*/

/*
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
*/

//Вариант 1 (мой)

/*
int CheckMultiplicity7(int num)
{
    if (num % 7 == 0)
    {
        int result = 0;
        return result;
    }
    else
    {
        int result = 1;
        return result;
    }
}

int CheckMultiplicity23(int num1)
{
    if (num1 % 23 == 0)
    {
        int result1 = 0;
        return result1;
    }
    else
    {
        int result1 = 1;
        return result1;
    }
}

System.Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckMultiplicity7(number) + CheckMultiplicity23(number) == 0)
{
    System.Console.WriteLine($"Число {number} одновременно кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {number} одновременно не кратно 7 и 23");
}
*/
//Вариант 2 (семинар) более короткий

bool CheckMultiplicity7and23(int num)
{
    if (num % 7 ==0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Введите число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (CheckMultiplicity7and23(number1) == true)
{
    System.Console.WriteLine($"Число {number1} одновременно кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {number1} одновременно не кратно 7 и 23");
}