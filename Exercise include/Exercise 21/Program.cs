//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Len(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return result;
}

Console.Write("Введите X координату точки A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координату точки A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координату точки A: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координату точки B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координату точки B: ");
int by = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координату точки B: ");
int bz = int.Parse(Console.ReadLine()!);


Console.Write($"Длина отрезка AB равна : {Len(ax, ay, az, bx, by, bz):f2}  ");