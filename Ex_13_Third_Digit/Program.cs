// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int noun = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string noun1 = Convert.ToString(noun);
int count = noun1.Length;
if (count < 3) Console.WriteLine("Третьей цифры нет!");
else Console.WriteLine("Третья цифра: " + noun1[2]);