﻿/*44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int a0 = 0, a1 = 1, a2, n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
a2 = a1 + a0;
a0 = a1;
a1 = a2;
Console.Write(a2);
Console.Write(" ");
}

