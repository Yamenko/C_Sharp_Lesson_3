//Задача 21: Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


using System.Drawing;
using System.Reflection.Metadata;

int[] sum = new int[3];
int tmp;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Точка {i + 1}. Введитеи координату {j}");
        Int32.TryParse(Console.ReadLine(), out tmp);
        sum[j] -= tmp;
    }
}

Console.WriteLine(Math.Sqrt(Math.Pow(sum[0], 2) + Math.Pow(sum[1], 2) + Math.Pow(sum[2], 2)));
