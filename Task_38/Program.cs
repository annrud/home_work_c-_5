Console.Clear();
Console.WriteLine("Программа выдаёт рвзницу между " +
                  "максимальным и минимальным элементом.");
Console.Write("Введите числа через пробел: ");
string input = Console.ReadLine()!;
double[] array = ParseToArray(input);
Console.WriteLine(DifferenceMaxMin(array));


double[] ParseToArray(string str)
{
    string[] stringArray = str.Trim().Split(" ");
    double[] result = new double[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = double.Parse(stringArray[i]);
    }
 
    return result;
}

double DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        else
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
    }

    return max - min;
}
              