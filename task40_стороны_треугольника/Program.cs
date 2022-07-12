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


/*Console.WriteLine("Введите три целых числа");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());

int check (int a, int b, int c ){
if (a+b<c&b+c<a&c+b<a){
return Console.WriteLine("Такого быть не может");
}
return Console.WriteLine("Законно");
}
check();
*/



/*string f(int a, int b, int c)
{
if ((a + b) > c && (b + c) > a && (c + a) > b)
return "Может существовать треугольник ";
return "Не может существовать треугольник ";
}
int a, b, c;
Console.WriteLine("Задайте сторону a ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте сторону b ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте сторону c ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b, c));
*/