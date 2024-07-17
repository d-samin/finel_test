void Main()
{
    string[] str = { "Hello", "2", "world", ":-)"};
    PrintNewArray(str);
}

string[] FormNewArray(string[] str)
{
    int count = 0;
    for(int i=0; i <str.Length; i++ )
    {
        if (str[i].Length <= 3)
            count++;
    }

    int index = 0;
    string[] result = new string[count];
    for(int i=0; i <str.Length; i++ )
    {
       if (str[i].Length <= 3)
        {
            result[index] = str[i];
            index++;
        }
    }
    return result;
}

void PrintNewArray(string[] str)
    {
        string[] newArray = FormNewArray(str);
        Console.WriteLine(string.Join(", ", newArray));
    }


Main();
