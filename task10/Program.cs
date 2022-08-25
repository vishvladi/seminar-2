// Показать кубы чисел заканчивающихся на четную цифру
int n = 100;
int count = 1;
int cube = 1;
while (count <= n)
{ cube = count * count * count;
  if(cube%2 == 0){
    Console.WriteLine(cube);
  }
  count++;  
}
