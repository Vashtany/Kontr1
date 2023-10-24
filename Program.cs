string[] array = {"Hello", "2", "world", ":-)"};

string[] newArray = new string[0];
        
int i = 0;

while (i < array.Length)
    {
        if (array[i].Length <= 3)
            {
                Array.Resize(ref newArray, newArray.Length + 1);
                
                newArray[newArray.Length - 1] = array[i];
            }
            
        i++;
    }
        
Console.WriteLine("Новый массив:");
foreach (string s in newArray)
{
    Console.WriteLine(s);
}
