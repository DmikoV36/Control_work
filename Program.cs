//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

Console.WriteLine("Введите массив строк");
string? input = Console.ReadLine();
char[] separators = new char[] { ' ', ',' };
string[] strArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
int size = strArray.Length;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (strArray[i].Length <= 3)
    {
        count++;
    } 
}

if (count == 0) count = 1;
string[] newArray = new string[count];
count = 0;

string[] FillArray (string[] array)
{
    for (int i = 0; i < size; i++)
    {
        if (strArray[i].Length <= 3)
        {
            newArray[count] = strArray[i];
            count++;
        } 
    }
    return newArray;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        Console.Write(newArray[i] + ", ");
    }
    Console.WriteLine(newArray[newArray.Length - 1]);
}

PrintArray(FillArray(strArray));
