﻿// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равнa 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int countChar = 3;                                   // Количество символов, допустимых в строке в новом массиве
PrintData("Введите массив строк через пробел:");
string str = ReadData();
string[] array = Solution(str.Split(' '));
PrintData("Mассив строк, длина которых меньше либо равнa 3 символа:");
PrintArray(array);

// Метод читает данные от пользователя
string ReadData()
{
    return Console.ReadLine() ?? "0";
}

// Метод выводит данные на печать
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод печатает массив
void PrintArray(string[] arr)
{
    Console.Write("[");
    if (arr.Any())
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1]);
    }
    Console.WriteLine("]");
}

// Метод добавляет строку в массив
string[] AddToArray(string[] arr, string item)
{
    if (arr.Length == 0)
    {
        return new string[] { item };
    }
    string[] arrResult = new string[arr.Length + 1];
    arr.CopyTo(arrResult, 0);
    arrResult[arr.Length] = item;
    return arrResult;
}

// Метод из имеющегося массива строк формирует массив строк, длина которых меньше либо равнa 3 символа.
string[] Solution(string[] arr)
{
    string[] arrNew = new string[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (string.IsNullOrEmpty(arr[i]))
            continue;
        if (arr[i].Length - 1 < countChar) arrNew = AddToArray(arrNew, arr[i]);

    }
    return arrNew;
}
