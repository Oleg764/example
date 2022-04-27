//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int A;

do
{
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз  ");
    Console.Write("введите число A: ");
}
while (!int.TryParse(Console.ReadLine(), out A)|| A<0);

int B;
do
{
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз  ");
    Console.Write("введите число B: ");
}
while (!int.TryParse(Console.ReadLine(), out B)|| B<0);