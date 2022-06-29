int a, i;
Console.Write("Введите число ");
a = Convert.ToInt32(Console.ReadLine());
i = 1;
while (i <= a)
{
    if (i%2 == 0)
    {   
        Console.Write(i + " ");
    }
    i++;
}