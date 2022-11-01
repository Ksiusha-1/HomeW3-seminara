// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArr()

{
    int[] array = new int[8];

    for (int i = 1; i < array.Length; i++)

    {
        array[i] = new Random().Next(i);

    }
    return array;

}

void PrintArray(int[] mass)

{
    for (int i = 1; i < mass.Length; i++)

    {
        Console.Write($"{mass[i]}");
        while (i != mass.Length + 2) ;

    }
}

int[] ArrayResult = RandomArr();
PrintArray(RandomArr());
Console.Write($"ArrayResult : [ , ]");

