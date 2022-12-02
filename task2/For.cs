// Цикл For

// for (int i = 1; i < 11; i++)
// {
//     Console.WriteLine(i);
// }



// Пример =======================================================================

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "asdasd");
Console.WriteLine(res);