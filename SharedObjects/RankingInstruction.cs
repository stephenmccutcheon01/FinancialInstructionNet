namespace SharedObjects
{
    /// <summary>
    ///    The ranking Instruction object
    /// </summary>
    /// <remarks>
    ///     Author: Stephen McCutcheon
    ///     Date: 30/06/2018
    /// </remarks>
    public class RankingInstruction
    {
        #region properties

        /// <summary>
        ///     Ranking
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        public int Ranking { get; set; }

        /// <summary>
        ///     Financial Instructio
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        public Instruction FinancialInstruction { get; set; }

        #endregion properties
    }
}
