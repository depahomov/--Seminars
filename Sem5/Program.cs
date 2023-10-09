// ** Задача  39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем месте и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 8 9] -. [9 8 7 6]

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; //инициалицация массива размером size
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    //System.Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

System.Console.Write("Input size:  ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value:  ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.Write("[ ");
PrintArray(myArray); 
Console.Write("] -> [ ");

myArray = ReverseArray(myArray);

PrintArray(myArray);
Console.Write("]");
*/

// Задача 42. Напишите программу, которая будет преобразовыывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
string DecimalToBinary(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

System.Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DecimalToBinary(number));
*/


// Задача. Напишите программу, которая принимает на вход 3 числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.


/*
void СheckExistenceOfTriangle(int a, int b, int c)
{
    if ((a < b +c) & (b < a + c) & (c < a + b))
    {
        System.Console.WriteLine("Треугольник со сторонами {a}, {b}, {c} существует");
    }
    else
    {
        System.Console.WriteLine("Треугольник со сторонами {a}, {b}, {c} не существует");
    }
}

System.Console.Write("Input side a: ");
int sideA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input side b: ");
int sideB = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input side c: ");
int sideC = Convert.ToInt32(Console.ReadLine());

СheckExistenceOfTriangle(sideA, sideB, sideC);
*/


// Не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа равны 1, 1.

int[] Fibboyfxb