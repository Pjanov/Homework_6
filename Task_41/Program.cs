/*                                             Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3   */

Console.WriteLine("ВВЕДИТЕ ПЯТЬ ЧИСЕЛ ! ");
int[] array = new int[5]; // М числа

void EnterNumber(int[] array) // запрашивает ввод числа у пользователя
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine(); // пустая строка

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}{(i != array.Length - 1 ? ", " : "")}");
    }
}

void PositiveNumber(int[] array) // считает положительные числа
{
    int even = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            even++;
        }
    }
    Console.Write($" -> {even}"); 
}

EnterNumber(array); 
PositiveNumber(array);  