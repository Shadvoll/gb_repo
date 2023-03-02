int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

string[] GetStrings(int n)
{
    string[] strs = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i+1} строку: ");
        strs[i] = Console.ReadLine();
    }
    return strs;
}

string[] FilterStrings(string[] strs)
{
    int n = strs.Length;
    int m = 0;
    for (int i = 0; i < n; i++)
    {
        if (strs[i].Length <= 3)
        {
            m++;
        }
    }
    string[] result = new string[m];
    m = 0;
    for (int i = 0; i < n; i++)
    {
        if (strs[i].Length <= 3)
        {
            result[m++] = strs[i];
        }
    }
    return result;
}

int n = GetNum("Введите количество строк: ");
string[] inputStrings = GetStrings(n);
string[] resultStrings = FilterStrings(inputStrings);
Console.WriteLine("Строки, длины которых меньше 3: ");
for(int i = 0 ; i < resultStrings.Length; i++){
    Console.Write(resultStrings[i] + " ");
}