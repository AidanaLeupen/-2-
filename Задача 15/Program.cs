// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());

void Check (int a)
{
  if (a == 6 || a == 7) {
  Console.WriteLine("Yes");
  }
  else if (a < 1 || a > 7) {
    Console.WriteLine("No");
  }
  else Console.WriteLine("Its not a weekend");
}

Check(a);