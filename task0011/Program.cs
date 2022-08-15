
using static System.Console;
Clear();

int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");



int[] GetArrayFromString(string arrayString)
{
    string[] massString = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result= new int [massString.Length];
    for (int i=0; i<result.Length; i++)
    {
        result[i] = int.Parse(massString[i]);
    }
    return result;
}
