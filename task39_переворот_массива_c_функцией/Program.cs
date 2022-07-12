/*39/ 
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*//*
int[] f(int[] array)//возвращаем массив[] принимаем ед.аргумент,тот же массив, который случайным образом сгенерировался
{
    for (int i = 0; i < array.Length/2;i++)//проходимся по нему до середины
    {
        (array[i], array[array.Length - (i + 1)]) = (array[array.Length-(i + 1)],array [i]);//меняем местами 0 -> n-1
    }                                                                                                    //  1 -> n-2
    return array;     //Возвращаем   массив                                                              //  2 -> n-3  и тд до n/2
}


Console.WriteLine("Введи количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();             //массив сгенерирован
for(int i = 0; i < array.Length; i++)
{
    
    array[i] =  random.Next(100, 999);
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("["+ string.Join(", ", array) + "]");
Console.WriteLine("["+ string.Join(", ", f(array)) + "]");// вызываем свою функцию и передаю туда массив, а она уже 
                                                          // вместо обыкновенного массива, вставляет перевернутый и выводим
*/





int[] f(int[] array)//возвращаем массив[] принимаем ед.аргумент,тот же массив, который случайным образом сгенерировался
{
    int x;
    for (int i = 0; i < array.Length/2; i++)//проходимся по нему до середины
    {
        x = array[i];
        array[i] = array[array.Length - (i + 1)];
        array[array.Length-(i + 1)] = x;
    }                                                                                                    //  1 -> n-2
    return array;     //Возвращаем   массив                                                              //  2 -> n-3  и тд до n/2
}


Console.WriteLine("Введи количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();             //массив сгенерирован
for(int i = 0; i < array.Length; i++)
{
    
    array[i] =  random.Next(100, 999);
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("["+ string.Join(", ", array) + "]");
Console.WriteLine("["+ string.Join(", ", f(array)) + "]");// вызываем свою функцию и передаю туда массив, а она уже 
                                                          // вместо обыкновенного массива, вставляет перевернутый и выводим



