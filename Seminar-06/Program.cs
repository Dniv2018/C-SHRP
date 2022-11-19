// Решение в группах задач:
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine();
Console.WriteLine("Урок 6. Двумерные массивы и рекурсия.");
Console.WriteLine();
Console.WriteLine("Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.");

int[] len = { 10, 5, 11 };
Console.WriteLine("[ " + string.Join(", ", len) + " ] -> " + CheckTriangle(len));



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
Console.WriteLine();
Console.WriteLine("Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.");
string result = "";
int DEC = 46;
// GetBynaryFromDecimal(DEC);
Console.WriteLine($"Decimal: {DEC} -> " + GetBynaryFromDecimal(DEC));

// Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine();
Console.WriteLine("Урок 6. Двумерные массивы и рекурсия.");
Console.WriteLine();
Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
// Console.WriteLine("Enter the numbers in one line separated by a space.");
string str;
do
{
    Console.WriteLine("Enter the numbers in one line separated by a space.");
    str = Console.ReadLine()!;
} while (String.IsNullOrWhiteSpace(str));
// Console.WriteLine("Enter the numbers in one line separated by a space.");
// string str = Console.ReadLine()!;
str = str.Trim();
string[] subs = str.Split(' ');
int[] num = new int[str.Length];

for (int i = 0; i < subs.Length; i++)
{
    if (!int.TryParse(subs[i], out num[i]))
    {
        num[i] = 0;
    }
}
int count = 0;

foreach (int item in num)
{
    if (item > 0) count++;
}
Console.WriteLine($"You entered {count} numbers greater than 0");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.



// Methods:
string GetBynaryFromDecimal(int dec)
{
    result = dec % 2 + result;
    if (dec / 2 == 0) return result;
    else GetBynaryFromDecimal(dec / 2);
    return result;
}

bool CheckTriangle(int[] array)
{
    bool count;
    int i = 0;
    do
    {
        i++;
        if (array[0] >= array[1] + array[2])
        {
            count = false;
        }
        else
        {
            count = true;
        }
        Rotaite(array);
        // Console.WriteLine("[ " + string.Join(", ", len) + " ] -> " + count + " i: " + i);
    }
    while (i <= 3 && count);
    return count;
}

void Rotaite(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        temp = array[i];
        array[i] = array[i + 1];
        array[i + 1] = temp;
    }
}



