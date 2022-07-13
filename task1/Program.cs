int n = new Random().Next(9, 100);
Console.WriteLine(n);
int N1 = n / 10;
int N2 = n%10;
if (N1>N2)
Console.WriteLine(N1);
else Console.WriteLine(N2);
 
