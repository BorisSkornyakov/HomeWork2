// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели от 1 до 7, где 1 это Понедельник, а 7 это Воскресенье");
int numberday = Convert.ToInt32(Console.ReadLine());
if ((numberday == 6) || (numberday == 7))
{
    System.Console.WriteLine($"{numberday} -> да");
}
else if (numberday > 7)
{
    System.Console.WriteLine($"Нет такого дня недели");
}
else
{
    System.Console.WriteLine($"{numberday} -> нет");
}