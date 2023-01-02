// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Величина массива ");
int input = Convert.ToInt32(Console.ReadLine());
int[] array = new int[input];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine($"Введите элемент массива под индексом {i}:\t");  
  array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++; 
    
}
Console.Write($"колличество элементов > 0 {count}");