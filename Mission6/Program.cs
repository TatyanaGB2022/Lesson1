//  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.WriteLine("Введите число 1: ");
string astr = Console.ReadLine ();
int a = Convert.ToInt32(astr);
System.Console.WriteLine("Введите число 2: ");
string bstr = Console.ReadLine ();
int b = Convert.ToInt32(bstr);

if (a*a == b) System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");

// System.Console.WriteLine("Введите число 1: ");
// string astr = Console.ReadLine ();
// int a = Convert.ToInt32(astr);
// System.Console.WriteLine("Введите число 2: ");
// string bstr = Console.ReadLine ();
// int b = Convert.ToInt32(bstr);

// if (a*a == b) System.Console.WriteLine($"a={a}, b={b}, -> Yes");
// else System.Console.WriteLine($"a={a}, b={b}, -> No");