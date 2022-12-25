// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. 

string[] stringArray = new string[5];
Console.WriteLine("Введите первый элемент массива: ");
stringArray[0] = Console.ReadLine()!;
Console.WriteLine("Введите второй элемент массива: ");
stringArray[1] = Console.ReadLine()!;
Console.WriteLine("Введите третий элемент массива: ");
stringArray[2] = Console.ReadLine()!;
Console.WriteLine("Введите четвертый элемент массива: ");
stringArray[3] = Console.ReadLine()!;
Console.WriteLine("Введите пятый элемент массива: ");
stringArray[4] = Console.ReadLine()!;

Console.WriteLine($"Введен массив: [{String.Join(",", stringArray)}]");

string[] newSizeArray = CheckArray(stringArray);
Console.WriteLine($"Новый массив: [{String.Join(",", newSizeArray)}]");

string[] CheckArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int el = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[el] = array [i];
            el++;
        }
    }
    return newArray;
}


