// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string GetPrint(int begin, int finish)
{
    if (begin == 1)
    {
        return begin.ToString();
        //  "1";
    }


    Console.WriteLine($"f({begin},{finish}) -> {(begin - 1) + " , " + GetPrint(begin - 1, finish)}");
    return (begin - 1) + " , " + GetPrint(begin - 1, finish);
}



Console.Write("Вводим n: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(GetPrint(n, m));



