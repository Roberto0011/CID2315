namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        int[] int_array = {11,23,31,42,53};
         ArraySum(int_array);


        int[,] array_2d = 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
        };

        PrintAllOddNumber(array_2d);

        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        int[,] Q2_3 = DoubleArray(array_2d);

        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
            Console.Write(num + " ");
        }


    }



    public static void ArraySum(int[] int_array){

        int sum = 0;
        for(int idx = 0; idx<5; idx++){
            sum += int_array[idx];
        }

        Console.WriteLine($"The sum of int_array is: {sum}");
    }

    public static void PrintAllOddNumber(int[,] array_2d){
        foreach(int value in array_2d){
            if(value%2!=0){
                Console.Write($"{value} ");
            }
        }

    }

     public static int ElementSum(int[ , ] array_2d){
            int sum = 0;
            for(int row = 0; row<3;row++){
                for(int col = 0; col<3;col++){
                sum += array_2d[row,col];
                }
            }
            
            return sum;
            
        } 
        public static int[,] DoubleArray(int[,] array_2d){

              int[,] double_array_2d = new int[3, 3]; 
              for(int row = 0; row<3;row++){
                for(int col = 0; col<3;col++){
                double_array_2d[row,col] = array_2d[row,col] *2;
                }
            }
            
            return double_array_2d;
        }
       
    }


   

