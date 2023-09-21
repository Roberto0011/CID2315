namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        /*Q1
        Console.WriteLine("Please input an Int for a:");
        string a = Console.ReadLine();
        int a_input = Convert.ToInt16(a);
        Console.WriteLine("please Input an Int for b:");
        //int n = 0;
        string b = Console.ReadLine();
        int b_input = Convert.ToInt16(b);
        Console.WriteLine($"The Largest number is:{CheckLargest(a_input,b_input)}");
        */

        //Q2
        Console.WriteLine("Please input a Number:");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Right or Left?");
        string shape = Console.ReadLine();
        Console.WriteLine($"N is:{N} shape is {shape}");
        ShapeFUnction(N, shape);
        

        
    }

        /*Q1
          static int CheckLargest(int a_input, int b_input)
        {
            if(a_input > b_input){
            return a_input;
            } 
            else if(b_input > a_input){
              return b_input;  
            } else{
                return b_input;
            }
            
            
        } */



        /*
        }*/

        static void ShapeFUnction(int N, string shape)
        
        {

        
            if(shape=="Left") 
            {
                for(int col=0; col<5; col++)
                {
            for(int row=0; row<N; row++)
            {
                if(col>=row)
                Console.Write('*');
            }
        
            Console.WriteLine("");
                }
            }
            else if(shape=="Right"){
                
                // Help from https://codewithshadman.com/csharp-pattern-programs/ for right triangle 
                //And Chat Gpt "Fix Error in else if statement"(Last resort)
             Console.WriteLine("works");

               for (int i=1; i<=N; i++)
            {
                for (int j=1; j <= N-i; j++)
                {
                    Console.Write("");
                }
                for (int k=1; k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            








            
            }
            else
            {
                Console.WriteLine("Shape not found");
            }
        } 
        
        
        
}
