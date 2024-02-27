
 var numbers=new List<int>(){1,2,3,4,5,6,7,8,9,10};  
numbers.Add(11);
numbers.AddRange(new [] {15,16,17,18}); 
numbers.InsertRange(11,new List<int>(){12,13,14});
System.Console.WriteLine("********************************************");
System.Console.WriteLine();
foreach (var num in numbers)
{
    System.Console.Write(num+" ");
}  
System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("********************************************");
System.Console.WriteLine();
numbers.Reverse();
foreach (var num in numbers)
{
   System.Console.Write(num+" "); 
}
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("********************************************");
