// Контрольная работа
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


    // string[] array = { "Hello", "2", "world", ":-)" };
    // string[] array = { "1234", "1567", "-2", "computer science" };
    // string[] array = { "Russia", "Denmark", "Kazan" };

    void FillArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Введите {0} - ю строку: ", i+1);
                    array[i] = Console.ReadLine();
                }
        }

    int Count(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i].Length <= 3){
                    count++;
                }
            return count;
        }

    string[] ArraySearch(string[] array)
        {
            string[] array2 = new string[Count(array)];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3){
                    array2[j] = array[i];
                    j++;
                }
            }
            return array2;
        }

Console.WriteLine("Массив будете вводить в ручную?");
Console.WriteLine("ДА = 1, НЕТ = 0");
int menu = Convert.ToInt32(Console.ReadLine());
if (menu == 1)
    {
        Console.WriteLine("Введите колличество строк в массиве:");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];

        FillArray(array);
        ArraySearch(array);
        Console.WriteLine();
        Console.WriteLine("[" + string.Join(",", ArraySearch(array))+ "]");
    }
else
    {
        string[] array = { "Hello", "2", "world", ":-)" };
        ArraySearch(array);
        Console.WriteLine();
        Console.WriteLine("[" + string.Join(",", ArraySearch(array))+ "]");
    }

