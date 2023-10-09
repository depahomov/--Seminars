// ** Задача  39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем месте и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 8 9] -. [9 8 7 6]

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
