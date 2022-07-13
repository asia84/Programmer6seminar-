/* 45: Напишите программу, которая будет создавать 
 заданного массива с помощью поэлементного копирования.
*/
int[] arr1 = new int[] {1, 2, 56, 0, -10};
int[] arr2 = new int[arr1.Length];
int x;
for (int i = 0; i < arr2.Length; i++)
{
x = arr1[i];
arr2[i] = x;
}
Console.WriteLine("[" + string.Join(", ", arr1) + "]");
Console.WriteLine("[" + string.Join(", ", arr2) + "]");