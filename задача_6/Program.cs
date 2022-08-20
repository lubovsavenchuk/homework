// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Type a number: ");
string x = Console.ReadLine();
int z = Int32.Parse(x);

if (z % 2 == 0)
{
   Console.WriteLine("Even number");
}
else
{
Console.WriteLine("Odd number");
}