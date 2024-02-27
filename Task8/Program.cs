var numbers=new List<int>(){1,2,3,4,5,6,7,8,9,10};  

 var num1=numbers.Contains(3); 
 System.Console.WriteLine(num1);
 var num2=numbers.Exists(num=>num%2!=0);
  System.Console.WriteLine(num2);
var num3=numbers.Find(num1 => num1%2==0);
System.Console.WriteLine(num3);
