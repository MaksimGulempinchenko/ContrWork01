string[] NewTextArray(string[] array1)
{
    string[] arrayText2 = new string[3];
    for (int i = 0, j = 0; i < array1.Length; i++, j++)
    {
    if(array1[i].Length <= arrayText2.Length)
        {
        arrayText2[j] = array1[i];
        }
       
    }
    return arrayText2;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] arrayText1 = new string[3] {"Russian", "437", "hello"};
string [] finishArray = NewTextArray(arrayText1);
PrintArray(arrayText1);
PrintArray(finishArray);