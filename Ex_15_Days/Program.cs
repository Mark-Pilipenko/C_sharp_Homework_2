// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int noun = Convert.ToInt32(Console.ReadLine());
while (noun < 1|noun > 7)
{
    Console.WriteLine("Такого дня недели не существует!");
    Console.Write("Введите номер дня недели: ");
    noun = noun = Convert.ToInt32(Console.ReadLine());
}
if (noun <= 5 & noun >= 1) Console.WriteLine("Нет, не выходной:(");
else Console.WriteLine("Да, выходной!");

switch (noun)
{
    case 1:
    Console.WriteLine("И вообще, понедельник:((");
    break;
    case 3:
    Console.WriteLine("Среда - маленькая пятница:)");
    break;
    case 5:
    Console.WriteLine("НО - ПЯТНИЦА!!!");
    break;
    case 7:
    Console.WriteLine("Аккуратно - завтра на работу!");
    break;
}