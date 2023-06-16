//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = 0;

while (true)
{
    Console.WriteLine("Введите число (0 для выхода): ");

    // Получаем число
    if (!Int32.TryParse(Console.ReadLine(), out num)) { Console.WriteLine("Не число!"); continue; }

    // Условие выхода
    if (num == 0) { break; }

    string str = "";
    for (int i = 1; i <= num; i++) {
        str += Math.Pow(i, 3) + ", ";
    }
    Console.WriteLine(str);
}
