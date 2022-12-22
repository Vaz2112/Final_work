/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


string[] NotMore3Symbols(string[] str)
{
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
            count++;
    }

    string[] strLess4 = new string[count];
    count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            strLess4[count] = str[i];
            count++;
        }
    }

    return strLess4;
}

//Формирование массива из строк, длина которых меньше, либо равна 3 символам
string[] notMore3Symbols = NotMore3Symbols(new string[] { " v", "122", "sdfs", "qwe", "67123/", "#$%", " 36" });

//Вывод полученного массива в консоль
for (int i = 0; i < notMore3Symbols.Length; i++)
{
    Console.WriteLine(notMore3Symbols[i]);
}