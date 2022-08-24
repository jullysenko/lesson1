// Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");  // интерполяция строк
//     }
//        Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//              + "ежели бы вас послали вместо нашего милого Винценгероде, "
//              + "вы бы взяли приступом согласие прусского короля. "
//              + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             0123
// s[3] // r

// string Replace(string text, char oldValue, char newValue) // метод принимает строку и те символы, кот нужно менять, входной текст - text, char - конкретный символ
// {
//     string result = String.Empty;  // инициализация пустой строки
//     int length = text.Length;   // получить длину строки
//     for (int i = 0; i < length; i++)   // от 0 силвола, до конца строки
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}"; // если текуий символ text [i] совпал с символом, который хотим заменить, то результат должны положить новое значение в виде строки 
//          else result = result + $"{text[i]}";       // если совпадени не обнаружено, то в наш резалт нужно добавить текущий символ 
//     }                   
//     return result;    // вернуть результат
// }
// string newText = Replace(text, ' ', '|');  // новый текст, присваиваем метод
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');  // новый текст, присваиваем метод
// Console.WriteLine(newText);


// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; // массив

// void PrintArray(int[] array)   // подзадача, чтобы вывести массив на экран. в качестве аргумента приходит массив
// {
//     int count = array.Length;   

//     for (int i = 0; i < count; i++)   // пробегаем по элементам массива
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)                // метод, который упорядочивает массив, в качестве аргумента приходит массив
// {
//     for (int i = 0; i < array.Length - 1; i++) // нужно пробежаться по всем элементам нашего массива, если начинаем позицию с 1 + i, искустренно нужно 1 отнять array.Length - 1
//     {
//         int minPosition = i;                    // определяем позицию, на которую смотрим
//         for (int j = 1 + i; j < array.Length; j++)  // ищем тот самый мин.элемент. нач позиция с i + 1?  не трогаем ту часть, что уже была отсортирована
//         {
//             if (array[j] < array[minPosition])    // ищем элемент мин. смотрим текущий, если он меньше, того мин. то мы текущую позицию сохраняем
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];                            //  меняем значение
//         array[i] = array[minPosition];
//         array[minPosition] = temporary; 
//     }
// }

// PrintArray(arr);  
// SelectionSort(arr);

// PrintArray(arr);  

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)   // подзадача, чтобы вывести массив на экран. в качестве аргумента приходит массив
{
    int count = array.Length;   

    for (int i = 0; i < count; i++)   // пробегаем по элементам массива
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)                // метод, который упорядочивает массив, в качестве аргумента приходит массив
{
    for (int i = 0; i < array.Length - 1 ; i++) // нужно пробежаться по всем элементам нашего массива, если начинаем позицию с 1 + i, искустренно нужно 1 отнять array.Length - 1
    {
        int maxPosition = i;                    // определяем позицию, на которую смотрим
        for (int j = 1 + i; j < array.Length; j++)  // ищем тот самый мин.элемент. нач позиция с i + 1?  не трогаем ту часть, что уже была отсортирована
        {
            if (array[j] > array[maxPosition])    // ищем элемент мин. смотрим текущий, если он меньше, того мин. то мы текущую позицию сохраняем
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];                            //  меняем значение
        array[i] = array[maxPosition];
        array[maxPosition] = temporary; 
    }
}

PrintArray(arr);  
SelectionSort(arr);

PrintArray(arr);  



