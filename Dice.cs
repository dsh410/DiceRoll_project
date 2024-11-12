

namespace DiceRoll_project
{
     public class Dice
    {
        static public int Roll { get; private set; }
   
        static public void RollDice()
        {
            Random randomNumber = new Random();
            Roll = randomNumber.Next(1,4);
            
        }

    }
}
