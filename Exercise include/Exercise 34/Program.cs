// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



int[] GenerateRandomArray(int size, int begin, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {

        RandomArray[i] = new Random().Next(begin, end + 1);
    }

    return RandomArray;
}


void ShowArray(int[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.WriteLine(Convert.ToString(Array1[i]));
    }
}


int CountMass(int[] myArray2)

{
    int Count = 0;
    for (int i = 0; i < myArray2.Length; i++)
        if (myArray2[i] % 2 == 0)
        {
            Count = Count + 1;
        }
    return Count;
}

int[] myArray = new int[5];
myArray = GenerateRandomArray(5, 100, 1001);
ShowArray(myArray);
Console.WriteLine("Колличество четных чисел массива:  " + CountMass(myArray));


