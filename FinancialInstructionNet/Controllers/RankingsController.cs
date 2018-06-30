using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FinancialInstructionNet.Controllers.Helpers;
using FinancialInstructionNet.Properties;
using SharedObjects;

namespace FinancialInstructionNet.Controllers
{
    /// <summary>
    ///    This Controller for ranking the instruction based on the usd amount
    /// </summary>
    /// <remarks>
    ///     Author: Stephen McCutcheon
    ///     Date: 30/06/2018
    /// </remarks>
    public class RankingsController : ApiController
    {
        #region public methods

        /// <summary>
        ///    Ranks the entries in the instruction DB based on incoming and outgoing
        ///    amount e.g. if entity foo instructs the highest amount fro a buy instruction,
        ///    then foo is rank 1 for outgoingh
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        public List<RankingInstruction> Get(bool buy)
        {
            var instructions = DBHelper.GetFromCache<List<Instruction>>(Settings.Default.cachykey);

            var rankingObjects = (from x in instructions
                where x.BuyOption == buy
                orderby x.USD descending 
                select x).ToList();

            int counter = 0;

            var rankingResults = new List<RankingInstruction>();

            rankingObjects.ForEach(y =>
            { rankingResults.Add(new RankingInstruction() 
                { Ranking = ++counter, 
                  FinancialInstruction = y});
            });


            return rankingResults;
        }

        #endregion public methods      
    }
}
