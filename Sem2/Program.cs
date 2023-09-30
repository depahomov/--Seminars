/*
написать программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно первому,
то программа выводит остаток от деления

34, 5  -> не кратно, остаток от деления 4
16, 4  -> кратно
*/

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
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number:  ");
int n2 = Convert.ToInt32(Console.ReadLine());

CheckMultiplicity(n1, n2);
