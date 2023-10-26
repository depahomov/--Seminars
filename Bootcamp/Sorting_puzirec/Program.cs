// Сортировка методом пузырька

int n = 5;
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Random.Shared.Next(10);
}
Console.WriteLine($"[{String.Join(',' ,array)}]");
for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
    }
}
Console.WriteLine($"[{String.Join(',' ,array)}]");