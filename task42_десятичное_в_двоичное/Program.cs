/*42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("введите десятичное число: ");
int n  =  Convert.ToInt32(Console.ReadLine());
int nn = n;
int position = 1;
int binary = 0;
while(n > 0)
{
    binary = binary + (n % 2) *position;
    position = position * 10;
     n = n / 2;
} 
Console.WriteLine($"Десятичное число {nn} в двоичной системе равно: {binary}");


/*
List<int> array = new List<int>();//массив список безразмерный
array.Add(6);
array.Add(7);
array.Add(7);
array.Add(7);
array.Add(7);
array.Add(7);
Console.WriteLine(string.Join(", ",array));
*/


/*ЧЕРЕЗ ДИНАМИЧЕСКИЙ МАССИВ

int count = 0, x, n = Convert.ToInt32(Console.ReadLine());
List<int> array = new List<int>();//динамический массив
while (n > 0)
{
x = n % 2;
array.Add(x);
count++;
//Console.Write(x);
n /= 2;
}
for (int i = count - 1; i >= 0; i--)
{
Console.Write(array[i]);
}
*/