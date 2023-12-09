Console.Clear();
int x = 10; 
int[] array = new int[x]; 
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); 
Console.WriteLine(string.Join(", ", array));
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {    
        count++;
    }    
}
Console.WriteLine("Колличество четных чисел:" + count);

