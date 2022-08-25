// Count the sum of  the digits of a number
Console.WriteLine(" Input any number upto 9999");
int n = int.Parse(Console.ReadLine());
int sum = 0;
if(n < 10)
{
   sum = n;
    Console.WriteLine("The sum of the digits is" + " " + sum);
    }
else if(n >= 10 && n < 100)
{
    sum = n/10+n%10;
    Console.WriteLine("The sum of the digits is" + " " + sum);
    }
else if(n >= 100 && n < 1000)
{
    sum = n/100+n%10+n%100/10;
    Console.WriteLine("The sum of the digits is" + " " + sum);
    }
else if(n >= 1000 && n < 10000)
{
    sum = n / 1000 + n % 1000 / 100 + n % 100 / 10 + n % 10;
    Console.WriteLine("The sum of the digits is" + " " + sum);
    }