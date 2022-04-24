//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число :");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
    N = -N;
int i = 1;
while (i <= N)
{
    int result = cub(i);

    Console.Write(result + ";");
    i++;
}
int cub(int N)
{
    N = N * N * N;
    return N;
}   