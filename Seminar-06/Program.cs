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
Console.WriteLine("Decimal: 45 -> " + GetBynaryFromDecimal(45, result));
string GetBynaryFromDecimal(int dec, string res)
{
    if (dec / 2 > 0) return GetBynaryFromDecimal(dec / 2, res);
    else return dec % 2 + res;
    // if (dec / 2 == 0) return dec % 2 + res;
    // else GetBynaryFromDecimal(dec / 2, res);
    // return res;
}


// Methods:
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



