int facktorial(int n)//функции обозначать маленькими буквами, а классы большими.принимаем n
{
    if (n==1)
        return 1 ;//завершает работу функции именно в этой строке//базисное значение 1
    return n* facktorial(n-1);//возврат значения //иначе необязательно писать else
}
Console.WriteLine(facktorial(5));