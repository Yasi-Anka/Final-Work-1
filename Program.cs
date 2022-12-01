﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array(int size) //Заполнение массива пользователем
{
    string[] array = new string[size];
    for(int i  = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент масива номер " + i + ":");
        array[i] = Console.ReadLine();

    }
    return array;
}

void ShowArray(string[] array) // Вывести массив на консоль
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

string[] NewArray(string[] array // Формирование нового массива, элементы кторого удовлетворяют условию "кол-во символов меньше или равно 3"
{
    
}


Console.WriteLine("Введите количество элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());

string[] MyArray = Array(size);

ShowArray(MyArray);
