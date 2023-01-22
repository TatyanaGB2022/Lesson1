// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine ();
System.Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine ();

int a = Convert.ToInt32(number1);
int b = Convert.ToInt32(number2);
if (a*a == b)
{
  System.Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else System.Console.WriteLine($"Число {a} не является квадратом числа {b}");
