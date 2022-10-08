// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int noun = Math.Abs(Convert.ToInt32(Console.ReadLine()));
while (noun < 100|noun > 999)
{
    Console.WriteLine("Число не трехзначное!");
    Console.Write("Введите трехзначное число: ");
    noun = Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int second = (noun % 100 - noun % 10) / 10;
Console.WriteLine("Вторая цифра введенного числа: " + second);