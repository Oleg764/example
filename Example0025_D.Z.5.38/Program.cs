//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным значением элементов массива.
//Длина массива задается с терминала.
Console.WriteLine($"Введите длину массива : ");
int N;
while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
    Console.WriteLine("некорректный  ввод , попробуйте ущё раз : ");

double[] FillArray(int N)
{
    double[] array = new double[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().NextDouble()*100 ;
    }
    return array;
}

void PrintDiffMinMax(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
    double difference = array.Max() - array.Min();
    Console.WriteLine($" Min = {array.Min()}, Max =  {array.Max()}");
    Console.WriteLine($"Разница между Max и Min =  {difference}");
    Console.WriteLine();
}

PrintDiffMinMax(FillArray(N));
Console.WriteLine();
