// Урок 2. Массивы и функции в программировании
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine();
Console.WriteLine("Урок 2. Массивы и функции в программировании");
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

//create random number
var rnd = new Random();
int input_value = rnd.Next(100, 1000);
Console.WriteLine($"The random input number: {input_value}");

//counting the number of digits
int digit = CountDigits(input_value);

// creating an array of digits from a number
int[] t1_array = new int[digit];
t1_array = FillArray(t1_array, input_value);

// output values from the array to the console by element number
ConWrite(t1_array, 2);
Console.WriteLine();


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 ->6
input_value = rnd.Next(1, 200);
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine($"The random input number: {input_value}");

//counting the number of digits
digit = CountDigits(input_value);

// creating an array of digits from a number
int[] array = new int[digit];
array = FillArray(array, input_value);

// output values from the array to the console by element number
ConWrite(array, 3);
Console.WriteLine();


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
input_value = rnd.Next(1, 8);
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine($"The random input number: {input_value}");
if (input_value == 6 || input_value == 7)
{
    Console.WriteLine($"The {input_value}'s day of the week IS a weekend day");
}
else
{
    Console.WriteLine($"The {input_value}'s day of the week is NOT a weekend day");
}
Console.WriteLine();


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98
input_value = rnd.Next(100, 1000);
Console.WriteLine("Задача 2: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. Задача решена в более общем варианте. Можно указать порядковый номер цифры которую надо удалить");
Console.WriteLine($"The random input number: {input_value}");

//counting the number of digits
digit = CountDigits(input_value);

// creating an array of digits from a number
int[] t2_array = new int[digit];
t2_array = FillArray(t2_array, input_value);
int result = 0;
Console.Write("Enter the order of the digit you want to delete: ");
int oderDigitDelete = int.Parse(Console.ReadLine()!);
int corrector = 1;

for (int i = t2_array.Length - 1; i >= 0; i--)
{
    if (i == oderDigitDelete - 1)
    {
        corrector = 2;
        continue;
    }
    result += t2_array[i] * GetSeparator(t2_array.Length - corrector - i);
}

Console.WriteLine($"Deletion result: {result}");
Console.WriteLine();


// Дополнительная Задача 9
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Дополнительная Задача 9: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
Console.Write("Enter a multiple of, as it seems to you, 23 and 7: ");
int multipleNumber = int.Parse(Console.ReadLine()!);

if (multipleNumber % 23 == 0 & multipleNumber % 7 == 0)
{
    Console.WriteLine("This number IS MULTIPLE of 23 and 7");
}
else
{
    Console.WriteLine("This number is NOT multiple of 23 and 7");
}
Console.WriteLine();


// Methods:
// 
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

void ConWrite(int[] array, int number)
{
    if (array.Length >= number)
    {
        Console.WriteLine($"The {number}'s digit of the number: {array[number - 1]}");
    }
    else
    {
        Console.WriteLine($"There is not {number}'s digit");
    }

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