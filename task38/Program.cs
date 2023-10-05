// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
arr[i] = rnd.NextDouble() * (max - min) + min;
}
return arr;
}

void PrintArrayDouble(double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
double nRound = Math.Round(arr[i], 1);
if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
else Console.Write($"{arr[i]:F2}");
}
Console.Write("]");
}

double MaxNumberInDoubleArray(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinNumberInDoubleArray(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double Difference (double max, double min)
{
    return max - min;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(array);
double maxNumberInDoubleArray = MaxNumberInDoubleArray(array);
double minNumberInDoubleArray = MinNumberInDoubleArray(array);
double difference = Difference (maxNumberInDoubleArray,  minNumberInDoubleArray);
Console.Write(" => ");
Console.Write($"{maxNumberInDoubleArray:F2} - ");
Console.Write($"{minNumberInDoubleArray:F2} = ");
Console.Write($"{difference:F2}");
