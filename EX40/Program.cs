//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами  такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.




bool CheckTree(int a, int b, int c)
{
    return a + b > c && a + c > b && b +c > a;
} 

Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите первое число: ");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите первое число: ");
int z = int.Parse(Console.ReadLine()!);

if(CheckTree(x, y, z))
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}
// 22 строка если условие первая ветка , если условие ложное после else - 2 ветка