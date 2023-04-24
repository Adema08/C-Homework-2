//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (n < 0)
// {
//     n *= -1;
// }
if (n > 99 && n < 1000) 
{
    Console.WriteLine($"The 2nd digit of the number: {n % 100 / 10}");
}
else
{
    Console.WriteLine("Not a 3-digital number");
}
