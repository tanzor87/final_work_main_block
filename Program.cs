// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

int lenOfSymbols = 3;

// string[] arrayString = {"Hello", "2", "world", ":-)"};
string[] arrayString = {"1234", "1567", "-2", "computer science"};
// string[] arrayString = {"Russia", "Denmark", "Kazan"};


void printArray (string[] array, string message = "")
{
    if (message != "")
    {
        Console.WriteLine(message);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

string[] newArray (string[] array, int number)
{
    string str = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            str += array[i] + " ";
        }
    }

    str = str.Trim();
    string[] newArray = str.Split(" ");
    
    return newArray;
}

string[] newArrayString = newArray(arrayString, lenOfSymbols);

printArray(arrayString, "Старый массив: ");
printArray(newArrayString, "Новый массив: ");

