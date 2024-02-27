List<int>numbers=new List<int>(){1,2,3,4,5}; 
numbers.Remove(3);
numbers.RemoveAt(0);
numbers.RemoveAll(a => a>4);
foreach (var summa in numbers)
{
System.Console.WriteLine(summa);
    
} 
