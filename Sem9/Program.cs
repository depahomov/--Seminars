//  Задача 1. Задайте значение N. Напишите пр-мму, которая выведет все натуральные числа
// в промежутке от 1 до N.

// N = 5 => "1, 2, 3, 4, 5"

// void ShowNumbers(int n)
// {
//     if (n > 0)
//     {
//         ShowNumbers(n - 1);
//         System.Console.Write(n + " ");
//     }
// }

// ShowNumbers(15);

//Задание 2. Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else return 0;
// }

// System.Console.WriteLine(FindSum(453));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"
// void ShowNumbersFromMtoN(int m, int n)
// {
//     if (n != m)
//     {
//         if (m > n)
//         {
//             ShowNumbersFromMtoN(m - 1, n);
//             System.Console.Write(m + " ");
//         }
//         else
//         {
//             ShowNumbersFromMtoN(m, n - 1);
//             System.Console.Write(n + " ");
//         }
//     }
//     else System.Console.Write(n + " ");
// }

// int n = 10;
// int m = 8;
// ShowNumbersFromMtoN(n, m);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int Exponentiation(int a, int b)
{
    if (b > 1)
    {
        return Exponentiation(a, b - 1) * a;
    }
    else return a;
}

int a = 10;
int b = 3;
System.Console.WriteLine(Exponentiation(a, b));