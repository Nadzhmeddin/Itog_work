// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arrayMax = new string[10] {"Moscow", "Rome", "Str", "Int", "Hi", "Russia", "USA", "China", "Japan", "Day"};
string[] arrayMini = new string[arrayMax.Length];

void GetMiniArray(string[]arrayMax, string[]arrayMini)
{
    int count = 0;
    for (int i = 0; i < arrayMax.Length; i++)
    {
        if(arrayMax[i].Length <= 3 )
        {
            arrayMini[count] = arrayMax[i];
            count++;
        }
    }
}

void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


GetMiniArray(arrayMax, arrayMini);
PrintArray(arrayMini);
