//Задача 19: Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли 
//оно палиндромом.

int num = 0, digit = 0;

while (true) { 
Console.WriteLine("Введите число (0 для выхода): ");

	// Получаем число
	if (!Int32.TryParse(Console.ReadLine(), out num))   { Console.WriteLine("Не число!"); continue; }
	
	// Условие выхода
	if (num == 0) { break; }

	// Проверка что число 5ти значное
	if (num < 10000 && num >= 10000 )                   { Console.WriteLine("Не 5ти значное!"); continue; }

	// Расчет разрядности
	digit = (int)Math.Ceiling(Math.Log10(num) - 1);
	bool polindrom = true;

	// Прверка палиндрома (сравниваем по очереди разряды слева и справа, сложно N/2)
	for (int i = 0; i < (digit / 2); i++) {
		int left = (int)((num / Math.Pow(10, (digit - i))) % 10);
		int right = (int)((num / Math.Pow(10, i)) % 10);
		if (right != left) { polindrom = false; break; }
	}

	// Вывод результата
	if (polindrom) { Console.WriteLine("Палиндром"); }
	else{Console.WriteLine("нет");}
}
