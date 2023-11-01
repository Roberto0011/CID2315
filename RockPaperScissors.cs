namespace MidtermBonus;

class Program
{
    static void Main(string[] args)
    {
       HumanPlayer hPlayer = new HumanPlayer(5);
       ComputerPlayer cPlayer = new ComputerPlayer();

      

       

       while(hPlayer.GetPoints() > 0){ 
        
        Console.WriteLine("****Rock Paper Scissors****");

        Console.WriteLine($"You have {hPlayer.GetPoints()} points");
        string humanShoot = hPlayer.HumanDesicion();
        string computerShoot = cPlayer.ComputerDesicion();

        Console.WriteLine($"--->Your Desicion: {humanShoot}");
        Console.WriteLine($"--->Computer Desicion: {computerShoot}");

        if (humanShoot == computerShoot){
            Console.WriteLine("It's a tie!");

            }else if(humanShoot == "rock" && computerShoot == "scissors" || humanShoot == "scissors" && computerShoot == "paper"
            || humanShoot == "paper" && computerShoot == "rock"){
                Console.WriteLine("You Win!");
                hPlayer.WinRound();

            }else if(computerShoot == "rock" && humanShoot == "scissors" || computerShoot == "scissors" && humanShoot == "paper"
            || computerShoot == "paper" && humanShoot == "rock"){
                Console.WriteLine("You lose!");
                hPlayer.LoseRound();
            }

            if(hPlayer.GetPoints() == 0){
                Console.WriteLine("Sorry, you don't have enough points, thanks for playing.\nThank you for playing");
                break;
            }
            Console.WriteLine("--->Play again? Input y to continue, or n to exit ");
            string playAgain = Console.ReadLine();
            if(playAgain != "y"){
                break;
            } 

       } 



    }

    class HumanPlayer{
        private int initial = 5;

        public HumanPlayer(int initial){

        }

        public int GetPoints(){
            return initial;

        }

        public void WinRound(){
            initial += 5;

        }

        public void LoseRound(){
            initial -= 5;

        }

        public string HumanDesicion(){
            Console.WriteLine("Input your choice: rock, paper, scissors.");
            return Console.ReadLine();

        }
    }

    class ComputerPlayer{
        public string ComputerDesicion(){
            Random rnd = new Random();
            
            int rnd_num = rnd.Next(0,3);
            
            if(rnd_num == 0){
                return "rock";
            }else if( rnd_num == 1){
                return "paper";
            }else{
                return "scissors";
            }
        }

        
    }


}
