// Напишите программу, которая принимает на вход координаты точки (Х и У),
// причём Х >< 0 и У >< 0 и выдаёт номер четверти, в которой находится эта точка


/*
int FindQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

System.Console.Write("Input x:  ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input y:  ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindQuarter(x, y));
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25

//2 -> 1, 4

/*
void QuadTable(int n)
{
    int count = 1;
    System.Console.Write(n + " -> ");
    while (count < n)
    {
        System.Console.Write(count * count + ", ");
        count++;
    }
    System.Console.WriteLine(count * count);
}

System.Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
QuadTable(n);
*/

// 3) по введённому номеру четверти вывести допустимые значения Х и У
// 1 -> (+x, +y)

/*
string FindCoordinates(int n)
{
    if (n == 1) return "x > 0, y > 0";
    if (n == 2) return "x < 0, y > 0";
    if (n == 3) return "x < 0, y < 0";
    if (n == 4) return "x > 0, y < 0";
    return "плоскости с таким номером нет";
}

System.Console.Write("Введите номер плоскости:  ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Допустимые значения координат: {FindCoordinates(n)}");
*/


// 4) напишите программу, которая по координатам 2-х точек 
//    находит расстояние между ними в 2-d пространстве

double Distance(double xa, double ya, double xb, double yb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
}

System.Console.Write("Введите координату Х точки А:  ");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату Y точки А:  ");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату Х точки B:  ");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату Y точки B:  ");
double yb = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками А({xa}, {ya}) и В({xb}, {yb}) = {Math.Round(Distance(xa, ya, xb, yb), 2)}");