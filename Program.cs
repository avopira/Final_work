 Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

int count = 0;
foreach (string str in originalArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}


string[] newArray = new string[count];
int index = 0;
foreach (string str in originalArray)
{
    if (str.Length <= 3)
    {
        newArray[index] = str;
            index++;
    }
}

Console.WriteLine("Новый массив строк:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}