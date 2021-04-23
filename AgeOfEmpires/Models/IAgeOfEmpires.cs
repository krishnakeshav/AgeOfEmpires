namespace AgeOfEmpires
{
    /// <summary>
    /// Handles requests related to game.
    /// </summary>
    public interface IAgeOfEmpires
    {
        /// <summary>
        /// Generate a battle/fight between 2 units
        /// </summary>
        /// <returns>Result of a battle</returns>
        FightResult DoBattle();
    }
}
