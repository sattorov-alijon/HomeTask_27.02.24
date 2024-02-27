List<int> numbers = new List<int>{ 1, 2, 3, 4, 5,6,7,8,9,10 };
Console.WriteLine("The filtered numbers are:");
List<int> evenNumbers=new List<int>();
evenNumbers=numbers.FindAll(p => p%2==0);
foreach(int number in evenNumbers)
{
 Console.WriteLine(number);
}