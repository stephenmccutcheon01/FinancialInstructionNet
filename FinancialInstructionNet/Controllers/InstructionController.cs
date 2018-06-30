using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FinancialInstructionNet.Controllers.Classes;
using FinancialInstructionNet.Controllers.Helpers;
using SharedObjects;
using SharedObjects.Enums;
using FinancialInstructionNet.Properties;

namespace FinancialInstructionNet.Controllers
{
   
    /// <summary>
    ///     Instruction Controller for collecting data
    /// </summary>
    /// <remarks>
    ///     Date:   28/06/2018
    ///     Author: Stephen McCutcheon
    /// </remarks>
    public class InstructionController : ApiController
    {

        #region public methods

        /// <summary>
        ///     Returns all the instructions sent
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public IEnumerable<Instruction> Get()
        {
            var instructions = DBHelper.GetFromCache<List<Instruction>>(Settings.Default.cachykey);

            return instructions;
        }


        /// <summary>
        ///     Posts a instruction into the DB
        /// </summary>
        /// <param name="financialInstruction"></param>
        /// <returns></returns>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public PostEnumResult Post(Instruction financialInstruction)
        {



            try
            {
                var instructions = DBHelper.GetFromCache<List<Instruction>>(Settings.Default.cachykey);

                PostEnumResult result = ValidateData();

                if (result == PostEnumResult.Success)
                {
                    SetUSDValue(ref financialInstruction);

                    SetSettlementDate(ref financialInstruction);

                    instructions.Add(financialInstruction);
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return PostEnumResult.Error;
            }
            
            
            
        }

        #endregion methods

        #region private methods

        /// <summary>
        ///     Set the USD Value using the formula
        ///     USD = Price Per Unit * Units * Agreed Fx
        /// </summary>
        /// <param name="financialInstruction"></param>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private void SetUSDValue(ref Instruction financialInstruction)
        {
            financialInstruction.USD = financialInstruction.PricePerUnit *
                                       financialInstruction.Units *
                                       financialInstruction.AgreedFx;
        }

        
 
        /// <summary>
        ///      Set the settlement date based on the rules
        /// </summary>
        /// <param name="financialInstruction"></param>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private void SetSettlementDate(ref Instruction financialInstruction)
        {
            string sundayCurrencySetting = Settings.Default.SundayCurrencyList;

            List<string> sundayWorkingWeekCurrencies = string.IsNullOrEmpty(sundayCurrencySetting) == false ? sundayCurrencySetting.Split(',').ToList() : new List<string>();

            var settlementCalculatore = new SettlementDateCalculator(sundayWorkingWeekCurrencies);

            settlementCalculatore.Update(ref financialInstruction);
        }

        /// <summary>
        ///     Perfom validation here. Not sure what to validate....
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private PostEnumResult ValidateData()
        {
            return PostEnumResult.Success;
        }

        #endregion private methods

    }
}
