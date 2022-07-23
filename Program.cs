Random random = new Random();
bool PlayAgain = true;
string Player;
string computer;
string answer;

while (PlayAgain)
{
    Player = "";
    computer = "";
    while (Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER, Or SCISSORS: ");
        Player = Console.ReadLine();
        Player = Player.ToUpper();
        //Console.WriteLine(Player);
    }

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine("Player " + Player);
    Console.WriteLine("computer " + computer);
    switch (Player)
    {
        case "ROCK":
            if (computer == "PAPER")
            {
                Console.WriteLine("You Lose");
            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("it's a draw");
            }
            else
            {
                Console.WriteLine("You Win");
            }
            break;
        case "PAPER":
            if (computer == "PAPER")
            {
                Console.WriteLine("it's a draw");

            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("You WIN");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
            break;
        case "SCISSORS":
            if (computer == "PAPER")
            {
                Console.WriteLine("You WIN");
            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("It's a Draw");
            }
            break;
    }

        Console.WriteLine("Would you play again Y/N");
        answer = Console.ReadLine();
        answer = answer.ToUpper();
    if (answer == "Y")
    {
        PlayAgain = true;
    }
    else
    {
        PlayAgain = false;
        Console.WriteLine("*******Thanks for Playing ROCK - PAPER - SCISSORS********");
    }
    Console.ReadKey();
}