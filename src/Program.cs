using System;
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
using System;
int InputInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

string InputString()
{
    return Convert.ToString(Console.ReadLine());
}

string[] InputStringArray(int n)
{
    var array = new string[n];
    for(int i = 0; i < n; i++)
    {
        array[i] = InputString();
    }

    return array;
}

string[] GetGoodLines(string[] lines)
{
    int N = lines.Length;
    var isGood = new bool[N];
    int count = 0;

    for(int i = 0; i < N; i++)
    {
        if(lines[i].Length <= 3)
        {
            isGood[i] = true;
            count++;
        }
        else
        {
            isGood[i] = false;
        }
    }

    int j = 0;
    var res = new string[count];
    for(int i = 0; i < N; i++)
    {
        if(isGood[i])
        {
            res[j] = lines[i];
            j++;
        }
    }

    return res;
}

void PrintArray(string[] array)
{
    Console.WriteLine("Result:");
    foreach(var line in array)
    {
        Console.WriteLine(line);
    }
}

var N = InputInt();

var lines = InputStringArray(N);

PrintArray(GetGoodLines(lines));
