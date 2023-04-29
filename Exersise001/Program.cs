int[] GetIntArray(string userInput)
{
    string[] tempArray = userInput.Split(' ');
    int[] array = new int[tempArray.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(tempArray[i]);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetPositiveNumbers(int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            counter++;
    }

    return counter;
}

Console.Clear();
Console.Write("Please enter values devided by spacebar: ");
string userInput = Console.ReadLine();
int[] array = GetIntArray(userInput);
PrintArray(array);
Console.WriteLine($"Amount of values > 0 in array: {GetPositiveNumbers(array)}");