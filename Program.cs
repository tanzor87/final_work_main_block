// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


// string[] stringArray = {"Hello", "2", "world", ":-)"};
string[] stringArray = {"1234", "1567", "-2", "computer science"};
// string[] stringArray = {"Russia", "Denmark", "Kazan"};

string str = "";
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        if (i != stringArray.Length - 1)
        {
            str += stringArray[i] + " ";
        }
        else
        {
            str += stringArray[i];
        }
    }
}

string[] stringNewArray = str.Split(" ");

Console.WriteLine($"Старый массив: [{string.Join(", ", stringArray)}]");
Console.WriteLine($"Новый массив: [{string.Join(", ", stringNewArray)}]");
