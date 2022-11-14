string[] words = new string[5] {"Hello", "my", "name", "is", "Sanya"};
string[] needlyWords = new string[words.Length];

void GetNeedlyWords(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}