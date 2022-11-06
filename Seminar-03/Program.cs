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
int inputNumber;
int digit;
int[] array = new int[5];
bool checkPalindrom = true; ;

while (true)
{
    // checking for a five-digit number
    do
    {
        Console.Write("Enter a palindrome: ");
        getNumber("Enter a palindrome: ");
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
        Console.WriteLine("This IS palindrome.");
        break;
    }
    else
    {
        Console.WriteLine("This is NOT palindrome.");
        checkPalindrom = true;
    }
}



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Methods:
//
void getNumber(string message)
{
    while (!int.TryParse(Console.ReadLine(), out inputNumber))
    {
        Console.Write("This is not number. " + message);
    }
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


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11