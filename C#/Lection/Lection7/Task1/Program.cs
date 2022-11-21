int n = 5;
int a = 3;
int powerRec = PowerRec(a,n);
int PowerRec(int a,int n)
{
 return n==0 ? 1 : PowerRec(a,n-1)*a;
}
Console.WriteLine(powerRec);
