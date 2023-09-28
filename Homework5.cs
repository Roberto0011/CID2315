namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        
        //Q1
        Console.WriteLine("Please input four integers.");
        int a = GetInt();
        int b = GetInt();
        int c = GetInt();
        int d = GetInt();
        int fourComp = Compare(a, b, c : 0, d : 0);
        Console.WriteLine($"a = {a}; b = {b}\nThe largest number is: {fourComp}");
        int twoComp = Compare(a, b, c, d);
        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}\nThe largest number is: {twoComp}");
        /*
        //Q2
        CreateAccount();*/
        
     }

       //Q1-2
    static int GetInt(){
        string string_input = Console.ReadLine();
        int int_return = Convert.ToInt16(string_input);
        return int_return;}

    static int Compare(int a, int b, int c, int d){
            int max1=0;
            int max2=0;
            int max=0;
            if(a>b){
                max1=a;
            } else {
                max1=b;   
            } 
            if(c>d){
                max2=c;
            }else {
                max2=d;
            }
            if(max1>max2){
                max=max1;
            }else{
                max=max2;
            }
            return max;
            }
            
        /*Q2
         static bool CheckAge(int birth_year){
            
            int age = 2022 - birth_year;
            if ( age >= 18){
                return true;
            }
            else{
                return false;
            }
             } 
        static void CreateAccount(){
           Console.WriteLine($"Enter your Username:");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine($"Enter your password again:");
            string password2 = Console.ReadLine();
            Console.WriteLine($"Enter your Birthyear:");
            int birth_year = Convert.ToInt16(Console.ReadLine());
            if(CheckAge(birth_year)== false){
                Console.WriteLine("Could not make account.");
            } else if(password != password2){
                Console.WriteLine("Incorrect Password.");
            } else { 
               Console.WriteLine("Account created Succefully.");
             }

        }*/

        
}
