Console.Clear();
Console.WriteLine("Программа выдаёт количество чётных чисел в массиве.");
Console.WriteLine("Введите трёхзначные числа через пробел: ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
Console.WriteLine(GetAmount(array));


int[] ParseToArray(string str)
{
    string[] stringArray = str.Trim().Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = Math.Abs(int.Parse(stringArray[i]));
    }
 
    return result;
}

int GetAmount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }

    return count;
}