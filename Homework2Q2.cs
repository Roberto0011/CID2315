namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num:");
        string firstString = Console.ReadLine();
        int n1 = Convert.ToInt16(firstString);

        Console.WriteLine("Please input the Second num:");
        string secondString = Console.ReadLine();
        int n2 = Convert.ToInt16(secondString);

        Console.WriteLine("Please input the third num:");
        string thirdString = Console.ReadLine();
        int n3 = Convert.ToInt16(thirdString);

        if(n1<n2){
            if(n1<n3){
                Console.WriteLine($"The smallest value is:{n1}");
            }
            else{
                Console.WriteLine($"The smallest value is:{n3}");
            }
        }
        else{ 
            if(n2<n3){
                Console.WriteLine($"The smallest value is:{n2}");
            }
            else{
                Console.WriteLine($"The smallest value is:{n3}");
            }
        
        }
        
        
        
        }

        
    
}
