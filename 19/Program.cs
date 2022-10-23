// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Программа определения палидром или нет пятизначное число.");
Console.Write("Введите число: ");
int a = (Convert.ToInt32(Console.ReadLine()));
if  (a < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Отрицательное число не может быть палиндромом");
    Console.ResetColor();
}
else{
    if (a > 9999 && a < 100000)
{
    if (((a / 10000 == a % 10)) && ((a/1000) % 10 == (a % 100) /10 ))
    {
        Console.WriteLine("Да, введенное число палиндром");
    }
    else
    {
        Console.WriteLine("Нет, введенное число не палиндром");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введенное чисто не пятизначное");
    Console.ResetColor();
}
}