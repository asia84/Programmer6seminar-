/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2,
k1 = 5,
b2 = 4, 
k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Введите величину b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите величину k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите величину b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите величину k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
int x,y;//координаты пересечения

if(k1!=k2)//не должны быть равны, иначе пересечения нет
{
    x = (b2-b1)/(k1-k2);//нахождение x координаты
    y = k1 * x + b1;//y координаты
    Console.WriteLine($"координаты пересечения прямых: ({x}; {y})");
}
else{
    Console.WriteLine("прямые - параллельны");
}




