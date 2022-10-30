// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] a = new double[4, 4];
double[] b = new double[4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = i * j + 1;
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0, k = 0; i < 4; i++)
{
    double summ = 0;
    for (int j = 0; j < 4; j++)
    {
        summ += a[i, j];
    }
    b[k] = summ / 4;
    Console.WriteLine("Среднее арифметическое столбца " + (i + 1) + " равно: " + b[k]);
    k++;
}
// Console.WriteLine("Введите размеры массива: ");
Console.Write(" ");
Console.ReadKey(true);