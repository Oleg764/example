//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях. Длина массива задается с терминала.

Console.WriteLine ($"Введите длину массива : " );
int N;
while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз : ");

int[] FillArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void SumUneven(int[] array)
{

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 > 0)
        sum = sum + array[i];
         
        
    
    }
Console.WriteLine();
Console.WriteLine($"Сумма нечётных элементов равна : {sum}");
Console.WriteLine();
}

SumUneven(FillArray(N));