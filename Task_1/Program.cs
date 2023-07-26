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
