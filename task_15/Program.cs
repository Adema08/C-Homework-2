// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number of the day of the week: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is it a day off?");
if (n == 6 || n == 7)
{
    Console.Write("Yes");
}
else if (n > 7 || n < 1)
{
    Console.Write("This is not a day of the week");
}
else
{
    Console.Write("No");
}
