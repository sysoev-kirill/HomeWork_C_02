// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Input num ");
int n = Convert.ToInt32(Console.ReadLine());
int res;

if (n < 99) Console.WriteLine($"{n} -> третьей цифры нет");
else
{
   while (n > 999)
      n = n / 10;
   res = n % 10;
   Console.WriteLine($"Третья цифра заданного числа -> {res}");
}
