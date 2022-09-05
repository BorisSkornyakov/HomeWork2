﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdSymbol(int a)                // Объявляем метод определения третьего знака в трехзначном числе
{
    return a % 10;
}

System.Console.WriteLine("Введите число");               // Считываем число из консоли
int number = Convert.ToInt32(Console.ReadLine());


if(number < 100)                                        // Если число двухзначное выдаем сообщение об отсутствии 3-й цифры
{    
    System.Console.WriteLine($"{number} -> третьей цифры нет");
}
else if (number < 1000)                                                  // Если число трехзначное, запускаем метод определения третьего знака                  
{                                                                        // и выводим результат на консоль
    System.Console.WriteLine($"{number} -> {ThirdSymbol(number)}");
}
else if (number > 999)                                                  // Если число имеет знаков больше 3-х
{                                                                       // Отбрасываем все младшие разряды, оставляя только три старших
    int result = number;                                                // После чего запускаем метод определения третьего знака
    while (result > 999)                                                // и выводим результат на консоль
    {
        result = result / 10;
    }
    
    System.Console.WriteLine($"{number} -> {ThirdSymbol(result)}");
}