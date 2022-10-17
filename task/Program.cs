Console.Clear();
string[] array = { "hello", "2", "world", ":-)" };

void NewArr(string[] arr)
{
    Console.Write(" -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write($"[{arr[i]}]");
            // Console.Write(",");
        }
    }
    Console.WriteLine();
}

void PrintArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

PrintArray(array);
NewArr(array);