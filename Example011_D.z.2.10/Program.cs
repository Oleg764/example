//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int digit2 = (n/10) % 10;
Console.WriteLine ("Вторая цифра в этом числе : {0}", digit2);