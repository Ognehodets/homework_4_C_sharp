//написать программу, которая задает массив из 8 элементов и выводит на экран

Console.WriteLine ("Введите массив из восьми целых чисел: ");
int [] a = new int [8];
for (int i = 0;i<8;i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine ());
}
Console.Clear();
Console.Write ("[ ");
for (int i = 0;i<8;i++)
{
     Console.Write (a[i]+" ");
}
Console.Write ("]");