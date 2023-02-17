/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше или равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

using static System.Console;
Clear();


//Ввести можно к примеру следующие строки { "hello", "2", "world", ":-)"};
WriteLine("Введите несколько произвольных строк, разделенных пробелами");
string[] str = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] result = new string[str.Length];

CountArray(str, result);
PrintSecondArray(result);


void CountArray(string[] str, string[] result)
{
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            result[count] = str[i];
            count += 1;
        }
    }
}


void PrintSecondArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
