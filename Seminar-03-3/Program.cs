// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.WriteLine();
Console.WriteLine("Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.");
int[] array = new int[123];
var rnd = new Random();
int count = 0;
FillArray(array, 1000);

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
FillArray(array_37, 11);
PrintMultCoupleDigits(array_37);

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
// Console.Write("[ " + string.Join(", ", array_37) +" ] -> ");
// for (int i = 0; i <= array_37.Length / 2; i++)
// {
//     if (i != array_37.Length / 2)
//     {
//         Console.Write(array_37[i] * array_37[array_37.Length - 1 - i] + " ");
//     }
//     else
//     {
//         Console.Write(array_37[i]);
//     }
// }
// Console.WriteLine("\n");


// Methods
void FillArray(int[] array, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, max);
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

