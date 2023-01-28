// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

double Prompt(string message)
{
Console.WriteLine(message);
return Convert.ToDouble(Console.ReadLine());
}

double number = Prompt("Введите число");
double result = 1/number;
System.Console.WriteLine($"Обратное число равно {result}");