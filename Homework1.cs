namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        double X = 2.5;
        double Y = 3.3;
        double Z = 4*X*X+3*Y;
        /*
        
        First shot, dont I just love over complicating things...
        
        string xValue = "X = "+ X;
        string yValue = ", Y = "+ Y;
        string zValue = "The value of Z is "+Z;
        Console.Write(xValue);
        Console.WriteLine(yValue);
        Console.WriteLine(zValue);*/

        Console.WriteLine($"X = {X}, Y = {Y}");
        Console.WriteLine($"The value of z is {Z}");
        
        

    }
}
