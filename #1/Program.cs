// Задача: Написать программу, которая из имеющегося массива сторок формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгритма.

string[] Array = { "hello", "+32", "Almaty", ":-)", "CPU", "GitHub", "Id", "144", "15489", "-44", "54689" };
PrintArray(FilterArr(Array));

string[] FilterArr(string[] array)
{
    int lengthOfElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lengthOfElem++;
        }
    }
    string[] createArray = new string[lengthOfElem];
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            createArray[a] = array[i];
            a++;
        }
    }
    return createArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($" {arr[arr.Length - 1]} ]");
}