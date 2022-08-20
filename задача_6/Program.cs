// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Type a number: ");
string num1 = Console.ReadLine();
int x = Int32.Parse(num1);
if (x % 2)
{
   Console.WriteLine("Even number");
}
else
{
Console.WriteLine("Odd number");
}