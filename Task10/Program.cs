var numbers=new List<int>(); 
 Random rand=new Random();  

 for (int i = 0; i < 20; i++)
 {
    int nums=rand.Next(-10,10); 
    numbers.Add(nums); 
    System.Console.Write(nums+" ");
 }
 
  