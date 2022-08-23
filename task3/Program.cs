Console.WriteLine("Введите номер четверти");
int n = int.Parse(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Возможные координаты: x > 0, y > 0");
}
if (n == 2)
{
  Console.WriteLine("Возможные координаты: x < 0, y > 0"); 
}
if (n == 3)
{
    Console.WriteLine("Возможные координаты: x < 0, y < 0");
}
if (n == 4)
{
  Console.WriteLine("Возможные координаты: x > 0, y < 0"); 
}