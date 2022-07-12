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


