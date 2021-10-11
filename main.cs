/// Hey, sorry, I spent four hours on the part of this where we split the array into the two new arrays, I watched your videos twice, looked at a ton of additional resources, and I really can't figure it out, I'm sorry, I figured submitting something was better than submitting nothing. 



using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {



double[] numbers = new double[10];
double[] even = new double[10];
double[] odd = new double[10];


for(int pos=0; pos < 10; pos++)

{
  Console.WriteLine ("Enter a number:");
  numbers[pos]=Convert.ToDouble(Console.ReadLine());


}
Console.WriteLine ("Numbers");
foreach( int number in numbers)
{
  if( number % 2 == 0)
   { even.Copy(number);
   }
    else
    {odd.Copy(number);
    }
}
  for(int pos=0; pos < numbers.Length; pos++)
{
  
  Array.Sort(even);
  Array.Sort(odd);
  Array.Reverse(odd);
  Console.WriteLine(odd[pos]);
  Console.WriteLine(even[pos]);
}


double oddsum = 1;
double evensum = 2;

Console.WriteLine ("Sum of Odd Numbers is" + oddsum);
Console.WriteLine ("Sum of Even Numbers is" + evensum);
  }
}