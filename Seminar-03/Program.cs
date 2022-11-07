// Урок 3. Массивы и функции в программировании

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine();
Console.WriteLine("Урок 3. Массивы и функции в программировании");
Console.WriteLine();
Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Палиндром - это слово, число, фраза или другая последовательность символов, которые читаются одинаково как в обратном, так и в прямом направлении, например, слова \"мадам\" или 12321.");
int inputNumber = 0;
int digit;
int[] array = new int[5];
bool checkPalindrom = true; ;

while (true)
{
    // checking for a five-digit number
    do
    {
        Console.Write("Enter a palindrome: ");
        inputNumber = getNumber("This is not number. Enter a palindrome: ", inputNumber);
        digit = CountDigits(inputNumber);
        if (digit != 5)
        {
            Console.WriteLine("This is not five-digit number!");
            continue;
        }
        else break;
    } while (true);

    // filling an array of digits from a number
    array = FillArray(array, inputNumber);

    // checking for a palindrome
    for (int i = 0; i < 2; i++)
    {
        if (array[i] != array[4 - i])
        {
            checkPalindrom = false;
            break;
        }
    }

    // output the check result
    if (checkPalindrom)
    {
        Console.WriteLine("This IS palindrome: ");
        break;
    }
    else
    {
        Console.WriteLine("This is NOT palindrome.");
        checkPalindrom = true;
    }
}



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек (A и B) и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine();
Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
int[,] points = new int[2, 3];

Console.WriteLine("Enter coordinates of the A point");
Console.Write("Enter the X: ");
points[0, 0] = getNumber("This is not number. Enter the X: ", points[0, 0]);
Console.Write("Enter the Y: ");
points[0, 1] = getNumber("This is not number. Enter the Y: ", points[0, 1]);
Console.Write("Enter the Z: ");
points[0, 2] = getNumber("This is not number. Enter the Z: ", points[0, 2]);

Console.WriteLine("Enter coordinates of the B point");
Console.Write("Enter the X: ");
points[1, 0] = getNumber("This is not number. Enter the X: ", points[1, 0]);
Console.Write("Enter the Y: ");
points[1, 1] = getNumber("This is not number. Enter the Y: ", points[1, 1]);
Console.Write("Enter the Z: ");
points[1, 2] = getNumber("This is not number. Enter the Z: ", points[1, 2]);

double res = 0;
for (int i = 0; i < 3; i++)
{
    res += Math.Pow(points[0, i] - points[1, i], 2);
}
Console.WriteLine("Distance between points A and B: " + Math.Sqrt(res));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine();
Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Enter number: ");
inputNumber = getNumber("This is not number. Enter the NUMBER: ", inputNumber);

Console.Write(inputNumber + " -> ");
int sign = 1;
if (inputNumber < 0) sign = -1;
for (int i = 1; i <= Math.Abs(inputNumber); i++)
{
    Console.Write(Math.Pow(i, 3) * sign);
    if (i < Math.Abs(inputNumber)) Console.Write(", ");
}
Console.WriteLine();

// Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11
Console.WriteLine();
Console.WriteLine("Дополнительно. Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.");

Console.Write("Enter number: ");
inputNumber = getNumber("This is not number. Enter the NUMBER: ", inputNumber);

bool check;
Console.Write(inputNumber + " -> ");
for (int i = 1; i <= inputNumber; i++)
{
    check = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            check = false;
            break;
        }
    }

    if (check)
    {
        Console.Write(i);
        if (i < inputNumber) Console.Write(", ");
    }
}
Console.WriteLine();
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

int[] FillArray(int[] array, int number)
{
    int index = array.Length - 1;
    //int div = 1;
    for (int j = index; j >= 0; j--)
    {
        //if (index - j > 0) div = GetDivider(index - j);
        array[j] = (number / GetSeparator(index - j)) % 10;
        //div = 1;
    }
    return array;
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