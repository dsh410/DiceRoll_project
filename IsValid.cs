


namespace DiceRoll_project
{
    internal class IsValid
    {
        public static bool Guess(string guess)
        {
            if (!int.TryParse(guess, out int value))
            {
                
                return false;
            }
            if (int.TryParse(guess, out int number))
            {
                if (number < 0 || number > 3 || number != Dice.Roll)
                {
                    
                    return false;
                }

                if (number == Dice.Roll)
                {

                    Game.isGameOver = true;
                    Game.EndGame();
                    
                }
            }
                return true;
        }

    }
}
