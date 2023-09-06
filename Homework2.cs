namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        string input = Console.ReadLine();

        switch (input) {
            case "A":
            Console.WriteLine("GPA Point: 4");
            break;

            case "B":
            Console.WriteLine("GPA Point: 3");
            break;

            case "C":
            Console.WriteLine("GPA Point: 2");
            break;

            case "D":
            Console.WriteLine("GPA Point: 1");
            break;

            case "F":
            Console.WriteLine("GPA Point: 0");
            break;

            default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
        }

       
    }
}
