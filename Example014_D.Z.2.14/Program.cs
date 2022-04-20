//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine ("Введите число от нуля до 1000 : "); 
double N =  Convert.ToInt32(Console.ReadLine());

if (N / 10 >=10) System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {N  % 10}");
else System.Console.WriteLine($"У числа {N} нет третьей цифры");
