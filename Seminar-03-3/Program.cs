// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.WriteLine();
Console.WriteLine("Семинар 5. Работа на семинаре.");
Console.WriteLine("Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.");
int[] array = new int[123];
var rnd = new Random();
int count = 0;
FillArray(array, 0, 1000);

foreach (int item in array)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine("Двузначных элементов: " + Count());


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10
Console.WriteLine();
Console.WriteLine("Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
int[] array_37 = new int[5];
FillArray(array_37, 0, 11);
PrintMultCoupleDigits(array_37);

// Урок 5. Функции продолжение
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("\n");
Console.WriteLine("Урок 5. Функции продолжение. HomeWork.");
Console.WriteLine();
Console.WriteLine("Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine();
Console.Write("Enter the number of elements in the array: ");

int numberOfElements = 0;
numberOfElements = getNumber("It is NOT number. Enter the number: ", numberOfElements);
int[] arrayEvenOdd = new int[numberOfElements];
FillArray(arrayEvenOdd, 100, 1000);

Console.Write("[ " + string.Join(", ", arrayEvenOdd) + " ] -> ");
Console.WriteLine(numberOfElements - getOddNumber(arrayEvenOdd));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine();
Console.WriteLine("Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine();

Console.Write("Enter the number of elements in the array: ");
numberOfElements = getNumber("It is NOT number. Enter the number: ", numberOfElements);
int[] arraySumOddIndex = new int[numberOfElements];
FillArray(arraySumOddIndex, 0, 100);
// int[] arraySumOddIndex = { -4, -6, 89, 6 };

Console.Write("[ " + string.Join(", ", arraySumOddIndex) + " ] -> ");
Console.WriteLine(GetSumOddIndex(arraySumOddIndex));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine();
Console.WriteLine("Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine();
Console.Write("Enter the number of elements in the array: ");
numberOfElements = getNumber("It is NOT number. Enter the number: ", numberOfElements);

float[] arrayRealNumber = new float[numberOfElements];
float[] arrayRealMinAndMaxNumber = new float[2];
// SetMinMax(arrayRealMinAndMaxNumber, arrayRealNumber);
FillArrayReal(arrayRealNumber, 100);
GetMinMaxRealNumber(arrayRealMinAndMaxNumber, arrayRealNumber);

Console.Write("[ " + string.Join(", ", arrayRealNumber) + " ] -> ");
Console.WriteLine($"min: {arrayRealMinAndMaxNumber[0]}, max: {arrayRealMinAndMaxNumber[1]}");






// Methods
void GetMinMaxRealNumber(float[] minAndMax, float[] real)
{
    SetMinMax(minAndMax, real);

    foreach (float item in real)
    {
        if (item < minAndMax[0]) minAndMax[0] = item;
        if (item > minAndMax[1]) minAndMax[1] = item;
    }
}

void SetMinMax(float[] minAndMax, float[] real)
{
    if (real.Length == 0)
    {
        minAndMax[0] = 0;
        minAndMax[1] = 0;
    }
    else
    {
        minAndMax[0] = real[1];
        minAndMax[1] = real[1];
    }
}

int GetSumOddIndex(int[] array)
{
    int count = 0;
    if (array.Length > 1)
    {
        for (int i = 1; i < array.Length;)
        {
            count += array[i];
            i = i + 2;
        }
    }
    return count;
}

int getOddNumber(int[] array)
{
    int count = 0;
    foreach (int item in arrayEvenOdd)
    {
        count += (item & 1);
    }
    return count;
}

int getNumber(string message, int Number)
{
    while (!int.TryParse(Console.ReadLine(), out Number))
    {
        Console.Write(message);
    }
    return Number;
}

void PrintMultCoupleDigits(int[] array)
{
    Console.Write("[ " + string.Join(", ", array) + " ] -> ");
    for (int i = 0; i <= array.Length / 2; i++)
    {
        if (i != array.Length / 2)
        {
            Console.Write(array[i] * array[array.Length - 1 - i] + " ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine("\n");
}

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
}

void FillArrayReal(float[] array, int mult)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (float)rnd.NextDouble() * mult;
    }
}


int Count()
{
    foreach (int item in array)
    {
        if (item < 100 && item > 9) count++;
    }
    return count;
}

