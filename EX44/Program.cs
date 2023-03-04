//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

int[] Fib(int na)
{
    int[] arr = new int[na];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < na; i++)
    {
        arr[i] = arr[i - 1]+ arr[i - 2];
    }
    return arr;
}


int na = int.Parse(Console.ReadLine()!);
int[] array = Fib(na);
Console.WriteLine(String.Join(", ", array));
