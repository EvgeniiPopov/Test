string[] arraySTR = { "Jonh", "Bob", "Katrin", "Anastasia", "Marvin", "Mia"}; // Создаем массив строк
int count = 0;
for (byte i = 0; i < arraySTR.Length; i++)
{
    if (arraySTR[i].Length <= 3) count++;
    System.Console.WriteLine(arraySTR[i]);
}
System.Console.WriteLine();

string[] arrayString = new string[count];
int j = 0;
for (byte i = 0; i < arraySTR.Length; i++)
{
    if (arraySTR[i].Length <= 3)
    {
        arrayString[j] = arraySTR[i];
        j++;
    }
}
for (byte i = 0; i < arrayString.Length; i++)
{
    System.Console.WriteLine(arrayString[i]);
}
