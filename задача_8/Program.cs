// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Type a number: ");
string N = Console.ReadLine();
int z = Int32.Parse(N);
int index = 0;
int EvenNumbers = 0;

while (z > 1)
{
   if ( index % 2 == 0)
   {
      index++;
   }

}
Console.WriteLine(index);