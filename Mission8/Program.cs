// Напишите программу вычисления модуля числа.
	// 2 -> 2
	// -3 -> 3
	// -7 -> 7

double Prompt(string message)
{
Console.WriteLine(message);
return Convert.ToDouble(Console.ReadLine());
}

double number = Prompt("Введите число");
double result = 1 / number;

double abs;
if (number > 0)
{
abs = number;
}
else
{
abs = -number;
}

System.Console.WriteLine($"Обратное число равно {result}");
System.Console.WriteLine($"Модуль числа равно {abs}");