//написать цикл, который принимает на вход два числа и возводит число А в натуральную степень В

int Stepen (int osn,int pok)
{
    int prom = 1;
    if (pok>0)
    {
    for (int i=1; i<=pok;i++)
    {
        prom*=osn;
    }
    return prom;
    }
    else 
    {
        Console.WriteLine ("данная функция не считает отрицательную степень");
        return 0;
    }
}



Console.Write ("Введите основание А = ");
int A = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите показатель В = ");
int B = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ($"{A} в степени {B} равно {Stepen (A, B)}");