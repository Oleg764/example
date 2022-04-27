//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int A;

Console.Write("Введите введите число  А: ");

while (!int.TryParse(Console.ReadLine(), out A) || A < 0)
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз : ");
int B;

Console.Write("Введите введите число В: ");

while (!int.TryParse(Console.ReadLine(), out B) || B <= 0)
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз : ");
int count = 1;
int result = A;

{
    while (count < B)

    {
        result = result* A;
        count++;
    }
}
Console.WriteLine($" Число А в степени В = {result}");