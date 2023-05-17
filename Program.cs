internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\tRock Paper Scissors");

        while (true)
        {
            Console.WriteLine("Are you ready?");
            Console.WriteLine("Let´s begin!!!");

            var selectedChoice = SelectChoice().ToLower();
            var yourChoice = char.Parse(selectedChoice);

            Console.WriteLine($"You selected {yourChoice}");

            var opponentChoice = GetOpponentChoice();
            Console.WriteLine($"I chose {opponentChoice}");

            DecideWinner(opponentChoice, yourChoice);

            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("Enter 'Y' to play again or any other key to stop..");
            var playAgain = Console.ReadLine();

            if (playAgain?.ToLower() == "y")
                continue;
            else
                break;
        }

        string SelectChoice()
        {
            Console.WriteLine("Choose R, P or S: [R]ock [P]aper or [S]cissor: ");
            var selectedChoice = Console.ReadLine();

            if (selectedChoice != "r" && selectedChoice != "p" && selectedChoice != "s")
            {
                Console.WriteLine("Please, select only one letter: R, P or S");
                selectedChoice = SelectChoice();
            }

            return selectedChoice;
        }

        char GetOpponentChoice()
        {
            char[] options = new char[] { 'r', 'p', 's' };

            Random random = new Random();
            int randomIndex = random.Next(0, options.Length);

            return options[randomIndex];
        }

        void DecideWinner(char opponentChoice, char yourChoice)
        {

            if (opponentChoice == yourChoice)
            {
                Console.WriteLine("Tie!!");
                return;
            }

            switch (yourChoice)
            {
                case 'r':
                    if (opponentChoice == 'p')
                        Console.WriteLine("Paper beats Rock, I win!!");
                    else if (opponentChoice == 's')
                        Console.WriteLine("Rock beats Scissors, you win!!");
                    break;
                
                case 's':
                    if (opponentChoice == 'r')
                        Console.WriteLine("Rock beats Scissors, I win!!");
                    else if (opponentChoice == 'p')
                        Console.WriteLine("Scissors beats Paper, you win!!");
                    break;

                case 'p':
                    if (opponentChoice == 's')
                        Console.WriteLine("Scissors beats Paper, I win!!");
                    else if (opponentChoice == 'r')
                        Console.WriteLine("Paper beats Rock, you win!!");
                    break;


                default:
                    break;
            }
        }
    }
}