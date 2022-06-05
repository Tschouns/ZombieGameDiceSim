

namespace ZombieGameDiceSim
{
    /// <summary>
    /// Implements basic game rules.
    /// </summary>
    internal static class Rules
    {
        public static int GetHits(int playerDice, int enemyDice)
        {
            if (playerDice > enemyDice)
            {
                return 1;
            }

            if (playerDice < enemyDice)
            {
                return -1;
            }

            return 0;
        }
    }
}
