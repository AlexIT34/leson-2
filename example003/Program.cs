int[] Array = {1,12,31,18,4,15,16,17,18};

int n = Array.Length;
int find = 18;

int index = 0 ;
 
while (index < n)
{
    if(Array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}    
