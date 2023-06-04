//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма..

string[] array = new string[6] { "S", "Rombo!", "Plus+sok", "!!", "op1", "PAvelll" };
string[] array2 = FindingThreeElementArray(array);

Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");
Console.WriteLine();
Console.Write("[");
PrintArray(array2, ",");
Console.WriteLine("]");


string[] FindingThreeElementArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSimvols = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvols = array[i];
        if (array[i].Length <= 3)
        {
            arrayThreeSimvols[j] = simvols;
            j++;
        }
    }
    return arrayThreeSimvols;
}



void PrintArray(string[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }

}