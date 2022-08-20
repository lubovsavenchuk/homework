// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Type first number here: ");
string num1 = Console.ReadLine();
int a = Int32.Parse(num1);

Console.WriteLine("Type second number here: ");
string num2 = Console.ReadLine();
int b = Int32.Parse(num2);
int max = a;
int min;

if (b > max) max = b; min = a;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

