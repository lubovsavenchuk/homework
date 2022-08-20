//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Type first number here: ");
string num1 = Console.ReadLine();
int a = Int32.Parse(num1);

Console.WriteLine("Type second number here: ");
string num2 = Console.ReadLine();
int b = Int32.Parse(num2);

Console.WriteLine("Type third number here: ");
string num3 = Console.ReadLine();
int c = Int32.Parse(num3);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);