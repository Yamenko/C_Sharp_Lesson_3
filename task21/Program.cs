//Задача 21: Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[,] points = new int[2, 3];
//int tmp;

while (true)
{
    Console.WriteLine("Введите число (0 во все координаты для выхода): ");

    for (int i = 0; i < 2; i++){
        for (int j = 0; j < 3; j++){
            Console.WriteLine($"Точка {i + 1}. Введитеи координату {j}");
            Int32.TryParse(Console.ReadLine(), out points[i, j]);
            
        }
    }

    // Расчет длин отрезков по координатам
    int[] sum = new int[3];
    for (int i = 0; i < 3; i++){
        sum[i] = points[1, i] - points[0, i];   
    }

    // Условие выхода
    if (sum[0] == 0 && sum[1] == 0 && sum[2] == 0) { break; }

    // Окончательный расчет
    Console.WriteLine(Math.Sqrt(Math.Pow(sum[0], 2) + Math.Pow(sum[1], 2) + Math.Pow(sum[2], 2)));
}