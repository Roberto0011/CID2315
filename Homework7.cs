using System.Data.Common;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer ( input_id: 110, input_name:"Alice", input_age: 28);
        Alice.PrintCusInfo();
        Customer Bob = new Customer ( input_id: 111, input_name:"Bob", input_age: 30);
        Bob.PrintCusInfo();
        Alice.ChangeID();
        Alice.PrintCusInfo();
        Bob.ChangeID();
        Bob.PrintCusInfo();
        Alice.CompAge(Bob);
        

    }

    class Customer{
        private int id = 0;
        public int age {get;set;} = 0;
        public string name {get;set;} = string.Empty;

        


         public void PrintCusInfo(){
            Console.WriteLine($"Customer: {id}, Name: {name}, Age:{age}.");

         }

         public Customer(int input_id, int input_age, string input_name) {
        id = input_id;
        age = input_age;
        name = input_name;
        
        

        }

        public void ChangeID(){
            id += 110;
            
        }

        public void CompAge(Customer objCustomer){
            if(this.age >= objCustomer.age){
                Console.WriteLine($"{this.name} is older.");
            } else {
                Console.WriteLine($"{objCustomer.name} is older.");
            }

        }


    }

   






}
