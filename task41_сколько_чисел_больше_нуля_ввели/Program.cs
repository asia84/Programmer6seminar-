 /*41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0,7,8,-2,-2-> 2
1,-7,567,89,223-> 4
*/

Console.WriteLine("сколько чисел вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");
int countN = 0;
int i;
int [] n = new int[size];

for(i = 0; i < size; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
    if (n[i]>0) 
    {
        countN++;
    }
}
Console.WriteLine($"вы ввели {countN} положительных чисел");