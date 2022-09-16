// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. '
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FillArray1(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

int FindSize2(string[] arr1)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            j++;
        }
    }
    return j;
}

void FillArray2(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];            
            j++;
        }
    }
}

Console.Write("Укажите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
Console.Write("Заполните массив: ");
FillArray1(array1);

string[] array2 = new string[(FindSize2(array1))];

Console.WriteLine();
FillArray2(array1, array2);
Console.Write(string.Join(" ", array2));
