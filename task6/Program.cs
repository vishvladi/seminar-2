//Сумма чисел от 1 до А
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int count = 1;
int sum = 0;
while (count <= a)
{
    sum = sum + count;
    count++;
}
Console.WriteLine(sum);