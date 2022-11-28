// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world",":-)"] -> ["2",":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array1 = new string[10] { "Hello,", "this", "is", "the", "final", "project", "after", "the", "first", "term" };
string[] array2 = GetShortWords(array1);

PrintArray(array1);
Console.Write(" -> ");
PrintArray(array2);

string[] GetShortWords(string[] Array1)
{
    int count = 0;
    int temp = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3) count++;
    }

    string[] array2 = new string[count];

    for (int j = 0; j < Array1.Length; j++)
    {
        if (Array1[j].Length <= 3)
        {
            array2[temp] = Array1[j];
            temp++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}