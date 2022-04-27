//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит их на экран. Диапазон - любое целое число.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int N = 8;

int[] Array8(int N)
{
    
    int[] arr = new int[N];
    for (int i = 0; i<N; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void writeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

writeArray(Array8(N));