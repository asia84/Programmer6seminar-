/*40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.WriteLine("Укажите первую сторону треугольника: ");
int a1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите вторую сторону треугольника: ");
int a2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите третью сторону треугольника: ");
int a3= Convert.ToInt32(Console.ReadLine());
    if((a1 < a2 +a3) && (a2 < a1 +a3) && (a3 < a2 +a1)) 
    {
        Console.WriteLine("это треугольник");
    }
    else
    {
       Console.WriteLine("это НЕ треугольник");        
    }

