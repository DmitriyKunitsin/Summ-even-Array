// See https://aka.ms/new-console-template for more information
Console.Write("Введите колличество элементов массива: \t");
int NumberArray = int.Parse(Console.ReadLine());
int[] NewArray = new int[NumberArray];
int even_numb = 0;
for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write($"Вы вводите значение массива {i}: \t");
    NewArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nВывод массива : \t");
for (int i = 0; i < NewArray.Length; i++)
{
        Console.WriteLine(NewArray[i]);
        if (NewArray[i] % 2 == 0 )
    {
        even_numb += NewArray[i];
    }
}
Console.WriteLine("Сумма четных чисел :\t"+even_numb.ToString());
Console.ReadLine();