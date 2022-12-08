// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] arr = new int[4];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(100,999);
// }
// void PrintResult(int[] arr)
// {
//     int even = 0;
//        for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//         if (arr[i] % 2 == 0) even++;
//     }
//     Console.WriteLine();
//     Console.WriteLine ($"Количество четных чисел {even}");
// }
// PrintResult(arr);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int size = 4;
// int[] array = new int[4];
// for (int i = 0; i <4; i++)
// {
//     array[i] = new Random().Next(-99, 99);
// }

// void PrintArrey(int[]arr)
// {
// int sum = 0;
// Console.WriteLine();
// for (int i = 0; i <size; i++)
//     {
//     Console.Write(arr[i] + " ");
//     if (i % 2 > 0) sum += arr[i];
//     }
// Console.WriteLine();
// Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
// Console.WriteLine();
// }
// PrintArrey(array);

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine();
int size = new Random().Next(1, 7);
Console.WriteLine($"Количетсов элементов массива: {size}");
double[] SourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}
void PrintMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double diff = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {diff}");
}
PrintMinMax(SourceArray(size));
Console.WriteLine();
