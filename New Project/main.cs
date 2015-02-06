using System.IO;
using System;

class Program
{
    static void Main()
    {
        int a=10,b=20,d;
        double c=30.233;
        string name="yang";
        d=(int)c;
        string input="";
        
        Console.WriteLine("a={0},b={1},c={2},d={3},name={4}",a,b,c,d,name);
        Console.WriteLine("input= "+input);
        input=Console.ReadLine();
        Console.WriteLine("here is out\nput= "+input);
        
    }
}
