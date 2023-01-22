// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine();
System.Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine();

int a = Convert.ToInt32(number1);
int b = Convert.ToInt32(number2);
if (a * a == b)
{
  System.Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else System.Console.WriteLine($"Число {a} не является квадратом числа {b}");


// Console.Write("Введите число 1: ");
// string stringValue1 = Console.ReadLine();
// Console.Write("Введите число 2: ");
// string stringValue2 = Console.ReadLine();

// int value1 = Convert.ToInt32(stringValue1);
// int value2 = Convert.ToInt32(stringValue2);

// int result = value1 * value1;
// if (result == value2){
// Console.WriteLine($"Квадрат числа {value1} равен числу {value2}");
// }
// else {
// Console.WriteLine($"Квадрат числа {value1} НЕ равен числу {value2}");
// }
