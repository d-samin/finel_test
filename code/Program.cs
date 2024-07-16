void Main()
{
    string[] str = { "Hello", "2", "world", ":-)"};
    PrintNewArray(str);
}

string[] FormNewArray(string[] str)
{
    int count = 0;
    foreach (string s in str)
    {
        if (s.Length <= 3)
            count++;
    }

    int index = 0;
    string[] result = new string[count];
    foreach (string s in str)
    {
       if (s.Length <= 3)
        {
            result[index] = s;
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
