void PrintArrayInt(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
string[] InputArray()
{
    Console.WriteLine("Введите массив через пробел: ");
    string[] array = Console.ReadLine().Split(" ").ToArray();
    return array;
}

string[] array = InputArray();
int n = 0;
for(int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
        n++;
string[] newArray = new string[n];
int j = 0;
  for(int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
PrintArrayInt(newArray);