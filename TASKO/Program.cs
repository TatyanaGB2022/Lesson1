/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

/*
System.Console.Write("Введите число > ");
string stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);

int result = value * value;

System.Console.WriteLine("Квадрат числа " + value + " равен " + result);
System.Console.WriteLine($"Квадрат числа {value} равен {result}");
*/

// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

// System.Console.WriteLine("Введите число 1: ");
// string number1 = Console.ReadLine();
// System.Console.WriteLine("Введите число 2: ");
// string number2 = Console.ReadLine();

// int a = Convert.ToInt32(number1);
// int b = Convert.ToInt32(number2);
// if(a*a == b) 
// {
//   System.Console.WriteLine($"Число {a} является квадратом числа {b}");
// }
// else System.Console.WriteLine($"Число {a} не является квадратом числа {b}");


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

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

System.Console.WriteLine("Введите число дня недели: ");
string day1 = Console.ReadLine();
System.Console.WriteLine("Введите число дня недели: ");
string day2 = Console.ReadLine();

int result1 = Convert.ToInt32(day1);
int result2 = Convert.ToInt32(day2);
if (result1 == 3)
{
  System.Console.WriteLine($"номер дня недели {result} Среда");
}
if (result2 == 5)
{
  System.Console.WriteLine($"номер дня недели {result} Пятница");
}
// else (result == 1)
// {
//   System.Console.WriteLine($ "номер дня недели {result} Понедельник");
// }