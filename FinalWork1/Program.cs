string[] words = new string[6] {"Hello", "my", "name", "is", "Sanya", "!"};
string[] needlyWords = new string[words.Length];

GetNeedlyWords(words, needlyWords);
Console.WriteLine("Массив из строк с длинной элементов 3 = ");
PrintNeedlyWords(needlyWords);

void GetNeedlyWords(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
    }
}

void PrintNeedlyWords(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
