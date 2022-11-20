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

Console.WriteLine($"Decimal: {DEC} -> " + GetBynaryFromDecimal(DEC));

// Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine();
Console.WriteLine("Урок 6. Двумерные массивы и рекурсия.");
Console.WriteLine();
Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

string[] subs = GetStr("Enter the numbers in one line separated by a space.");


int[] num = new int[subs.Length];

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
Console.WriteLine();
Console.WriteLine("Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

float[] formula = GetFormula();

if (formula[0] == formula[2])
{
    if (formula[1] == formula[3])
    {
        Console.WriteLine("Straight lines match.");
    }
    else Console.WriteLine("Straight lines don't intersect.");
}
else
{
    float x = (formula[3] - formula[1]) / (formula[0] - formula[2]);
    Console.WriteLine($"Intersection point. X: {x} Y: {formula[0] * x + formula[1]}.");
}


// Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

Console.WriteLine();
Console.WriteLine("Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.");
int[] array = { -1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.Write("[ " + string.Join(", ", array) + " ] -> ");

bool[] checkArray = new bool[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0 & array[i] < array.Length)
        checkArray[array[i]] = true;
}
count = -1;
for (int i = 0; i < checkArray.Length; i++)
{
    if (!checkArray[i])
    {
        Console.WriteLine("MEX: " + i);
        count++;
        break;
    }
}
if (count == -1) Console.WriteLine("MEX: " + array.Length);




// Methods:
float[] GetFormula()
{
    float[] formula = new float[4];
    for (int i = 0; i <= 2;)
    {
        do
        {
            if (i == 0) subs = GetStr("Formula: y = k1 * x + b1. Enter the values k1 and b1 separated by a space.");
            else subs = GetStr("Formula: y = k2 * x + b2. Enter the values k2 and b2 separated by a space.");
        } while (subs.Length != 2);

        if (!float.TryParse(subs[0], out formula[i]) || !float.TryParse(subs[1], out formula[i + 1])) continue;
        else i += 2;
    }
    return formula;
}

string[] GetStr(string mes)
{
    string str = "";
    do
    {
        Console.WriteLine(mes);
        str = Console.ReadLine()!;
    } while (String.IsNullOrWhiteSpace(str));
    str = str.Trim();
    return str.Split(' ');
}

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



