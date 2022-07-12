Console.WriteLine("Введи количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Введи число: ");
    array[i] =  Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("["+ string.Join(", ", array) + "]");