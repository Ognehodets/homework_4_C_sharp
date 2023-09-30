//написать программу, которая принимает на вход число и выдает сумму цифр в числе

Console.Write ("Введите число А = ");
int A = Math.Abs(Convert.ToInt32 (Console.ReadLine ()));//обработан ввод отрицательного числа
string s = Convert.ToString (A);
int sum = 0;
string prom="";
int promt;
for (int i=0;i<s.Length;i++)
{
prom = prom+s[i];
promt =  Convert.ToInt32(prom);  
sum=sum+promt;
Console.WriteLine (promt);
prom="";
}
Console.WriteLine ("сумма цифр равна "+sum);
