﻿// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
//
Console.Clear();

int[] CopyArr(int[]  inArray)
{
    int[] arr = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        arr[i] = inArray[i];
    }
    return arr;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}




int[] arr = GetArray(5, -10, 10);
int[] copyarr = CopyArr(arr);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", copyarr));
ReversArray1(arr);
Console.WriteLine("========");
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine(String.Join(", ", copyarr));
