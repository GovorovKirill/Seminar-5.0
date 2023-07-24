// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}; ");
        else Console.Write($"{num}");
    }
    Console.Write("]");
}

double DiffMaxMinNumber(double[] arr, int round = 1)
{
    double minNum = arr[0];
    double maxNum = arr[0];
    double difference = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum) minNum = Math.Round(arr[i], round);
        if (arr[i] > maxNum) maxNum = Math.Round(arr[i], round);
    }

    difference = maxNum - minNum;
    return difference;
}


double[] arrDouble = CreateArrayRndDouble(5, -9, 9);
PrintArrayDouble(arrDouble);

double diffMaxMinNumber = DiffMaxMinNumber(arrDouble);
Console.WriteLine($"-> {diffMaxMinNumber}");
