﻿// Задача 50. Напишите программу, которая на вход принимает число и 
//возвращает индексы элемента в двумерном массиве или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите размеры массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine("Введите : ");
int row = Convert.ToInt32(Console.ReadLine());
int colum = Convert.ToInt32(Console.ReadLine());
if (row < 0 | row > array.GetLength(0) - 1 | colum < 0 | colum > array.GetLength(1) - 1)
    Console.WriteLine($":Такого числа нет ");
else
{
    object diag = array.GetValue(row, colum);
    Console.WriteLine(diag);
}