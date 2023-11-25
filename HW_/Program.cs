// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] Prompt(string msg)
{
    Console.Write(msg);
    return Console.ReadLine().Split("; ");
}

string[] GetArrayOfThreeSymbols(string[] array)
{
    int count = 0;
    string[] preresult = new string[count];
    string[] result = preresult;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            preresult = new string[count];
            for (int j = 0; j < preresult.Length - 1; j++)
            {
                preresult[j] = result[j];
            }
            preresult[count - 1] = array[i];
            result = preresult;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    string mass = "[";
    if (array.Length > 0)
    {
        mass += "\"" + array[0] + "\"";
        for (int i = 1; i < array.Length; i++)
        {
            mass += ", \"" + array[i] + "\"";
        }
    }
    mass += "]";
    Console.Write(mass);
}

string[] arrayOfStrings = Prompt("Введите элементы массива строк, отделяя каждый элемент массива точкой с запятой и пробелом (; ): ");
string[] arrayOfThreeSymbols = GetArrayOfThreeSymbols(arrayOfStrings);
Console.Write("Сформированный массив из элементов введенного массива ");
PrintArray(arrayOfStrings);
Console.Write(", длина которых меньше или равна 3 символам, равен ");
PrintArray(arrayOfThreeSymbols);

