Console.Clear();
Console.WriteLine("Программа выдаёт самую длинную последовательность, " +
                  "состоящую из одинаковых элементов.");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
int[] results = FindMaxSequence(array);
Console.WriteLine($"Count: {results[0]}");
Console.WriteLine($"Element: {results[1]}");
Console.WriteLine($"Position: {results[2]}");

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


int[] FindMaxSequence(int[] arr)
{
	int cnt = 0;
	int count = 0;
	int element = 0;
	int position = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] == arr[i+1])
		{
			cnt++;
			if (cnt + 1 > count)
			{
				count = cnt + 1;
				position = i - (cnt - 1);
				element = arr[position];
			}	
		}
		else
		{
			cnt = 0;
		}
    }
	int[] result = new int[3]{count, element, position};
	return result;
}
