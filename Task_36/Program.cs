Console.Clear();
Console.WriteLine("Программа выдаёт сумму элементов, стоящих на нечётных позициях.");
Console.Write("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
Console.WriteLine(SumOfOddPosition(array));


int[] ParseToArray(string str)
{
    string[] stringArray = str.Trim().Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
 
    return result;
}

int SumOfOddPosition(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
    }

    return count;
}