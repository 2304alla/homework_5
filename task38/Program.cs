// Задача 38:
//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}


// double[] array = new double[n];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// array[i] = rand.NextDouble();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int MaxMinElemDifference(int[] array)
{
    int max = array[0];
    int min = array[0];
    int difference = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) array[i] = min;

    }

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) array[i] = max;
    }
    return difference = max - min;

}

//CreateArrayRndDouble(5, 1, 7);
int[] arr = CreateArrayRndDouble(5, 1, 7);
PrintArray(arr);
int result= MaxMinElemDifference(arr);
Console.WriteLine($"Разница между максимальным и минимальм элементами = {result}");