 // 1. Создание массива
// 2. Заполнить
//     - руками
//     - случайно
//     - из файла
// 3. Печать массива
// 4. Сумма
// 5. Печать результата
//     - в консоль
//     - в файл

using System.Diagnostics;

int[] array = 100_000.Create()
               .Fill(1, 10 );
// array.ConvertToStringAndPrintToTerminal();


int n = 10_000 ;
Stopwatch sw = new Stopwatch();

sw.Start();
int max = array.BadGetSum(n);
sw.Stop();
System.Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(n);
sw.Stop();
System.Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");

//System.Console.WriteLine(array.AndPrintToTerminal());