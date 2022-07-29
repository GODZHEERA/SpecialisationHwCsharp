string [] array = new string[5] {"cat", "dog", "fridge", "window", "sun"};
int CharsCount = 3;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("==========");

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= CharsCount)
    {
        Console.WriteLine(array[i]);
    }

}