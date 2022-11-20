// Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n. Выведете полученный массив на экран.
// m=3, n=4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.WriteLine("Seminar's work");
Console.WriteLine();
Console.WriteLine("Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n. Выведете полученный массив на экран.");

// getting the size (with size check > 0) of an array
int rows = GetNumber("Enter number of rows: ", true);
int columns = GetNumber("Enter number of columns: ", true);

int[,] array = new int[rows, columns];

var rnd = new Random();
int maxRandom = 100;

FillArray(array, "i+j");

// calculation of the line formatting interval
int count = 0;
count = GetOrder(rows + columns) + 3;

// getting a string from an array and outputting it to the console
Console.WriteLine(CreateOutputMessage(array, count));



// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса нечетные, и заените эти элементы на их квадраты.
// Например, изначально массив              Новый массив будет выглядеть
// выглядел так:                            вот так:
// 1 4 7 2                                  1 4 7 2 
// 5 9 2 3                                  5 81 2 9
// 8 4 2 4                                  8 4 2 4
Console.WriteLine();
Console.WriteLine("Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса нечетные, и заените эти элементы на их квадраты.");

// getting the size (with size check > 0) of an array
rows = GetNumber("Enter number of rows: ", true);
columns = GetNumber("Enter number of columns: ", true);
int[,] arrayTask49 = new int[rows, columns];

FillArray(arrayTask49, "rnd");

count = 0;
count = GetOrder(maxRandom * maxRandom) + 3;

Console.WriteLine("Original array: ");
Console.WriteLine(CreateOutputMessage(arrayTask49, count));

ChangeArrayWithIndexOdd(arrayTask49);
Console.WriteLine("Modified array: ");
Console.WriteLine(CreateOutputMessage(arrayTask49, count));


// Задача 51. Задайте двумерный массив, заполнив его случайными числами. Найдите сумму элементов на главной диагонали (главная диагональ - это те элементы, которые имеют индекс (0,0), (1,1)..).
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12
Console.WriteLine();
Console.WriteLine("Задача 51. Задайте двумерный массив, заполнив его случайными числами. Найдите сумму элементов на главной диагонали (главная диагональ - это те элементы, которые имеют индекс (0,0), (1,1)..).");

// getting the size (with size check > 0) of an array
rows = GetNumber("Enter number of rows: ", true);
columns = GetNumber("Enter number of columns: ", true);
int[,] arrayTask51 = new int[rows, columns];

FillArray(arrayTask51, "rnd");

count = 0;
maxRandom = 10;
count = GetOrder(maxRandom) + 3;

Console.WriteLine("Array : ");
Console.WriteLine(CreateOutputMessage(arrayTask51, count));
int i = 0;
int sum = 0;
string sumMessage = "";
while (i < arrayTask51.GetLength(0) && i < arrayTask51.GetLength(1))
{
    sum += arrayTask51[i, i];
    sumMessage += arrayTask51[i, i];
    if (i < arrayTask51.GetLength(0) - 1 && i < arrayTask51.GetLength(1) - 1) sumMessage += " + ";
    i++;
}
Console.WriteLine($"The sum of the elements of the main diagonal: {sumMessage} = {sum}");


// Урок 7. Как не нужно писать код. Часть 1
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine();
Console.WriteLine("Урок 7. Как не нужно писать код. Часть 1");
Console.WriteLine();
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

// getting the size (with check size > 0) of an array
rows = GetNumber("Enter number of rows: ", true);
columns = GetNumber("Enter number of columns: ", true);
double[,] arrayTask47 = new double[rows, columns];
int maxValue;
int minValue;
do
{
    maxValue = GetNumber("Enter max value array: ", false);
    minValue = GetNumber("Enter min value array: ", false);
} while (maxValue <= minValue);

count = GetOrder(maxValue) + 3;

FillArrayDouble(arrayTask47, minValue, maxValue);

Console.WriteLine(CreateOutputMessageDouble(arrayTask47, count));



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine();
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.\n");
Console.WriteLine("Enter the position of the element in the two-dimensional array:");

//output existing array
Console.WriteLine(CreateOutputMessageDouble(arrayTask47, count));

rows = GetNumber("Enter the vertical position: ", true);
columns = GetNumber("Enter the horizontal position: ", true);

if (rows - 1 < arrayTask47.GetLength(0) & columns - 1 < arrayTask47.GetLength(1))
    Console.WriteLine($"The value of the element at the point [{rows},{columns}]: {arrayTask47[rows - 1, columns - 1]:N2}");
else Console.WriteLine($"There are NO points with [{rows},{columns}] coordinates in this array");




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine();
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n");

// getting the size (with check size > 0) of an array
rows = GetNumber("Enter number of rows: ", true);
columns = GetNumber("Enter number of columns: ", true);

int[,] arrayTask52 = new int[rows, columns];

count = 0;
maxRandom = 10;
count = GetOrder(maxRandom) + 5;
FillArray(arrayTask52, "rnd");

Console.WriteLine("Array : ");
Console.WriteLine(CreateOutputMessage(arrayTask52, count));

string resultMessage = "";
for (int j = 0; j < arrayTask52.GetLength(1); j++)
{
    sum = 0;
    for (int k = 0; k < arrayTask52.GetLength(0); k++)
    {
        sum += arrayTask52[k, j];
    }
    resultMessage += String.Format("{0,-" + count + ":N2}", Convert.ToDouble(sum) / arrayTask52.GetLength(0));
}
Console.WriteLine(resultMessage);



// Methods
string CreateOutputMessageDouble(double[,] array, int interval)
{
    string resultMessage = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultMessage += String.Format("{0,-" + interval + ":N2}", array[i, j]);
        }
        resultMessage += "\n";
    }
    return resultMessage;
}

void FillArrayDouble(double[,] array, int min, int max)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
}

void ChangeArrayWithIndexOdd(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 != 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 != 0) array[i, j] *= array[i, j];
            }
        }
    }
}

string CreateOutputMessage(int[,] array, int interval)
{
    string resultMessage = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultMessage += String.Format("{0,-" + interval + "}", array[i, j]);
        }
        resultMessage += "\n";
    }
    return resultMessage;
}

int GetOrder(int val)
{
    count++;
    if (val / 10 == 0) return count;
    else GetOrder(val / 10);
    return count;
}

void FillArray(int[,] array, string choice)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (choice.Equals("i+j")) array[i, j] = i + j;
            if (choice.Equals("rnd")) array[i, j] = rnd.Next(maxRandom);
        }
    }
}

int GetNumber(string message, bool greaterZero)
{
    int number;
    do
    {
        Console.Write(message);
        if (greaterZero && int.TryParse(Console.ReadLine(), out number) & number > 0) return number;
        if (!greaterZero && int.TryParse(Console.ReadLine(), out number)) return number;
    }
    while (true);
}