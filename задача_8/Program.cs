// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
//  Идея решения задачи такая, код выдает ошибку. Но я уже иссякла и не знаю, как их исправлять. Если поможете разобраться, буду безмерно благодарно, так как очень интересно!

Console.WriteLine("Type a number: ");
int N = Console.ReadLine();
int z = Int32.Parse(N);
int index = 0;
int EvenNumbers = 0;

int n = array.Length;
int[] array = new int [1, N];
while (index < n)
{
   if (array [index] % 2 == 0)
   {
      Console.WriteLine(EvenNumbers);
      index++;
   }
EvenNumbers++;
}
Console.WriteLine(EvenNumbers);