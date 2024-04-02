using System.ComponentModel.Design;

Console.WriteLine("Enter Number:");
int usernum = Convert.ToInt32(Console.ReadLine());
int result = usernum % 2;
Console.WriteLine(result);
if (result != 0)
{
    Console.WriteLine("Number is odd");
} else
{
    Console.WriteLine("number is even");
}