/*
Внутри класса Answer напишите метод IsPalindrome, 
который принимает на вход пятизначное число number и проверяет, 
является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, 
в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.
*/
/*
using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
*/

/*
bool IsPalindrome(int number)
{
    if (number > 9999 && number < 100000)
    {
        int digit1 = number % 10; number = number / 10;
        int digit2 = number % 10; number = number / 100;
        int digit4 = number % 10; number = number / 10;
        int digit5 = number % 10;
        if (digit1 == digit5 && digit2 == digit4)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    System.Console.WriteLine("Число не пятизначное");
    return false;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
bool result = IsPalindrome(number);
System.Console.WriteLine(result);
*/

/*
Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
*/

double Length(int[] pointA, int[] pointB)
{
    // Введите свое решение ниже
    return Math.Round(Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2)), 2);
}

int[] CoordinatsA = { 7, -5, 0 };
int[] CoordinatsB = { 1, -1, 9 };
System.Console.WriteLine(Length(CoordinatsA, CoordinatsB ));
