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

PrintArrayInt(newArray);