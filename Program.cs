string[] array = { "Jonh", "Bob", "Katrin", "Anastasia" }; // Создаем массив строк
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
    System.Console.WriteLine(array[i]);
}
System.Console.WriteLine();

string[] arrays = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrays[j] = array[i];
        j++;
    }
}
for (int i = 0; i < arrays.Length; i++)
{
    System.Console.WriteLine(arrays[i]);
}
