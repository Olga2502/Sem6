// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом 
//месте, а первый - на последнем и т.д.)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}



void ReversArray1(int[] inArray) // сщздаем новый массив. готовы пожертвовать текущим массивом
{
    for (int i = 0; i < inArray.Length / 2; i++) //идем от1 индекса до середины длины массива 
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 -i];  //Функция SWAP в С — простой способ обменять значения двух переменных, которые содержат одинаковые типы данных.
        inArray[inArray.Length - 1 - i] = temp; //в i-й элемент кладем элемент с концв 
        
    }

}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - i - 1];
    }
    return result;
}


int[] array = GetArray(6, 1, 10);
Console.WriteLine(String.Join(", ", array));

ReversArray1(array);
Console.WriteLine(String.Join(", ", array));

int[] reversed =  ReversArray2(array);
Console.WriteLine(String.Join(", ", reversed));