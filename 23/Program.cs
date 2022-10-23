// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Программа выводит кубы чисел от 1 до заданного.");
Console.Write("Задайте число: ");
int a = (Convert.ToInt32(Console.ReadLine()));
int b = 1;
while (b < a + 1)
{
    Console.WriteLine((Math.Pow(b,3)));
    b ++;
}