//Multiplying numbers from 1 to N
int n = new Random().Next(1, 10);
Console.WriteLine(n);
int count = 1;
int mult = 1;
while (count <= n){
mult = mult * count;
count++;}
Console.WriteLine(mult);
