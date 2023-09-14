namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Help from https://www.tutorialspoint.com/Chash-Program-to-check-if-a-number-is-prime-or-not
        /*
        //Q1
        Console.WriteLine("Input a number:");
        string input_num = Console.ReadLine();
        int N = Convert.ToInt16(input_num), s = 0;

        for(int i = 1; i <= N; i++){
            if (N % i == 0) {
                
                
                s++;
                // For study Console.WriteLine(s+"s");
            }
             //For Study Console.WriteLine(i+"i");
        }
        if (s==2){
            Console.WriteLine($"{N} is prime");
        }else {
            Console.WriteLine($"{N} is not prime");
            
        }*/
     

       //Q2

       Console.WriteLine("Assign a value to N:"); 
       int N = Convert.ToInt16(Console.ReadLine()), B = N + 1;
       for(int row = 0; row<N; row++){
        for(int col = 0; col<N; col++){
            
            Console.Write("#");
        }
        Console.WriteLine("");
       }
    }
}
