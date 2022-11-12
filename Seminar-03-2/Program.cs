// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine();
Console.WriteLine("Урок 4. Функции продолжение");
Console.WriteLine();
Console.WriteLine("Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int baseDegree = 0;
Console.WriteLine("Enter the base of degree: ");
baseDegree = getNumber("This is not number. Enter the base of degree: ", baseDegree);
int degree = 0;
Console.WriteLine("Enter the degree: ");
degree = getNumber("This is not number. Enter the degree: ", degree);

int res = 1;
while (degree > 0)
{
    if (degree % 2 != 0)
    {
        res *= baseDegree;
        degree--;
    }
    baseDegree *= baseDegree;
    degree = degree / 2;
}
Console.WriteLine("Result: " + res);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine();
Console.WriteLine("Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Enter the number: ");
degree = getNumber("This is not number. Enter the number: ", degree);

// Console.WriteLine("!!!!! " + degree);
int[] array = new int[CountDigits(degree)];
FillArray(array, degree);
// Array.ForEach(array, Console.WriteLine);
res = 0;
foreach (int item in array)
{
    res += item;
}
Console.WriteLine("Result: " + res);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine();
Console.WriteLine("Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("Since it is not specified how the array will be formed, it will be filled with random integer values in the range up to 1000.");
var rnd = new Random();
int[] arraySecond = new int[8];

for (int i = 0; i < arraySecond.Length; i++)
{
    arraySecond[i] = rnd.Next(1000);
    Console.Write(arraySecond[i]);
    if (i < arraySecond.Length - 1) Console.Write(", ");
}

Console.Write(" -> [");
for (int i = 0; i < arraySecond.Length; i++)
{
    Console.Write(arraySecond[i]);
    if (i < arraySecond.Length - 1) Console.Write(", ");
}
Console.WriteLine("]");
Console.WriteLine();


// Methods:
//
int getNumber(string message, int Number)
{
    while (!int.TryParse(Console.ReadLine(), out Number))
    {
        Console.Write(message);
    }
    return Number;
}

int CountDigits(int number)
{
    int count = 0;
    while (number >= 1)
    {
        number = number / 10;
        count++;
    }
    return count;
}

void FillArray(int[] array, int number)
{
    int index = array.Length - 1;
    //int div = 1;
    for (int j = index; j >= 0; j--)
    {
        //if (index - j > 0) div = GetDivider(index - j);
        array[j] = (number / GetSeparator(index - j)) % 10;
        //div = 1;
    }
    //return array;
}

int GetSeparator(int repeat)
{
    int div = 1;
    for (int cnt = 0; cnt < repeat; cnt++)
    {
        div *= 10;
    }
    return div;
}



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]