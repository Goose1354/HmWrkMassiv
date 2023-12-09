Console.Clear();
int[] array = new int[10]; 
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100); 
Console.WriteLine(string.Join(", ", array));
bool flag = false;      //Да, жалуется. В программировании я очень слаб, пытался в силу своих
int count = 0;          // знаний исправить это, но у меня совсем не получилось:(
for (int i = 0; i < array.Length; i++) 
{    
    if (array[i] >=20 && array[i] <=90)
    {    
        flag = true;
        count++; 
        
    }
}   

Console.WriteLine("колличество совпадений в отрезке[20,90]: " + count);

