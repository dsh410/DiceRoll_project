

namespace DiceRoll_project
{
    internal class Game
    {
        static private int chances;
        static private bool _isGameOver = false;
        static public int Chances
        {
            get { return chances; }
            set { chances = value; }
        }
       
        static public bool isGameOver { get; set; }
        public static void Start()
        {
            Dice.RollDice();
            Player playerOne = new Player();
            Game.Chances = 0;

            Console.WriteLine("Welcome to the Dice Roll Game.");
            Console.WriteLine("In this game you must guess the correct random number between 1 and 3");
            Console.WriteLine("You only get 3 chances, to guess correctly");
            Console.WriteLine("Enter a number whenever you are ready. Good Luck!");

            do
            {
                string? yourGuess = Console.ReadLine();
                Player.NumberGussed = yourGuess;


                if (!IsValid.Guess(Player.NumberGussed))
                {
                    Console.WriteLine("Wrong Answer, Try again");

                }
              
                Game.Chances++;
            } while (Game.Chances < 3 || Game.isGameOver);

            Game.Over();
        }

        static public void EndGame()
        {
            Console.WriteLine("You Gussed the Random Number, You Win!");
            Console.WriteLine("Game Over!");
            Environment.Exit(0);
        }

        static public void Over()
        {
            Console.WriteLine("You have no more chance left, Game Over!");
            Environment.Exit(0);
        }
    }
}
