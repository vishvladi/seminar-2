//Определить количество цифр в числе
Console.WriteLine("Введите любое число");
int n = int.Parse(Console.ReadLine());
if(n <= 10)
{
 Console.WriteLine("Одна цифра");   
}
else if(n < 100 && n >=10)
{
Console.WriteLine("Две цифры");
}
else if(n > 99 && n < 1000)
{
Console.WriteLine("Три цифры");
}
else if(n > 999 && n < 10000)
{
Console.WriteLine("Четыре цифры");
}
else if(n > 9999 && n < 100000)
{
Console.WriteLine("Пять цифр");
}
else if(n > 99999){
Console.WriteLine("Больше пяти цифр");
}