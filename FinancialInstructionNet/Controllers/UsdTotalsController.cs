using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FinancialInstructionNet.Controllers.Helpers;
using FinancialInstructionNet.Properties;
using SharedObjects;

namespace FinancialInstructionNet.Controllers
{
    /// <summary>
    ///      This controller work out the following reports
    ///
    ///      1. Amount in USD Settled incoming everyday
    ///      2. Amount in USD Settled outgoing everyday
    /// </summary>
    /// <remarks>
    ///      Author: Stephen McCutcheon
    ///      Created Date: 30/06/2018
    /// </remarks>
    public class UsdTotalsController : ApiController
    {
        #region methods

        /// <summary>
        ///     Gets the USD Sums for each day
        /// </summary>
        /// <param name="buy"></param>
        /// <returns></returns>
        /// <remarks>
        ///      Author: Stephen McCutcheon
        ///      Created Date: 30/06/2018
        /// </remarks>
        public List<UsdTotal> Get(bool buy)
        {
            var instructions = DBHelper.GetFromCache<List<Instruction>>(Settings.Default.cachykey);


            var totals = (from x in instructions
                where x.BuyOption == buy
                group x.USD by x.SettlementDate
                into g
                select new UsdTotal()
                {
                    Date = g.Key,
                    Total = g.Sum()
                }).ToList();
                         

            return totals;
        }

        #endregion methods
    }
}
