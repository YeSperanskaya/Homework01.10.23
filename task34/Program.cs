// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;

}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    // Console.WriteLine("]"); если добавим в метод, то скобки будут выводится всегда. Если скобки не критичны, то стоит выводить за метод.
}

int EvenNumbersInArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(5, 99, 1000);
// PrintArray(array);
int evenNumbersInArray = EvenNumbersInArray(array);

Console.Write(" [");
PrintArray(array);
Console.Write("]");
Console.Write(" -> ");
Console.Write(evenNumbersInArray);

