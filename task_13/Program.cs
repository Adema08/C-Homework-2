// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter a number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string s = Convert.ToString(n);
if (s.Length < 3)
{
    Console.WriteLine("We don't have 3rd digit of the number");
}
else
{
    Console.WriteLine(s[2]);
}