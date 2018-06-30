using System;
using System.Collections.Generic;
using SharedObjects;

namespace FinancialInstructionNet.Controllers.Classes
{
    /// <summary>
    ///     Works out what the settlement date is
    ///     A Work week starts Monday and ends friday, unless the currency of the trade is AED or
    ///     SAR, where the work week starts Sunday and ends thursday. No other holidays to be taken into account.
    ///     A trade can only be settled on a working day
    ///     if and instructed date falls on a weekend, then the settlement date should be changed to the next working
    ///     day
    /// </summary>
    /// <remarks>
    ///     Author: Stephen McCutcheon
    ///     Date:   30/06/2018
    /// </remarks>
    public class SettlementDateCalculator
    {
        #region private variables

        /// <summary>
        ///     All the currencies which working days start on a sunday
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date:   30/06/2018
        /// </remarks>
        private readonly List<string> _sundayWorkingDayCurrencies;

        #endregion private variables

        #region Constructor

        /// <summary>
        ///     Initiates the calculator and ensures all the currencies are in upper case
        ///     to make sure the currency check is case insenstive
        /// </summary>
        /// <param name="sundayWorkingDayCurrencies"></param>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date:   30/06/2018
        /// </remarks>
        public SettlementDateCalculator(List<string> sundayWorkingDayCurrencies)
        {
            //Update all the currencies string to upper case to ensure 
            //the match is case insentive
            _sundayWorkingDayCurrencies = new List<string>();

            foreach (var currency in sundayWorkingDayCurrencies) _sundayWorkingDayCurrencies.Add(currency.ToUpper());
        }

        #endregion

        #region public methods

        /// <summary>
        ///     Works out the settlemnt date based on the rules set above
        /// </summary>
        /// <param name="financialInstruction"></param>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date:   30/06/2018
        /// </remarks>
        public void Update(ref Instruction financialInstruction)
        {
            var isWorkingDate = IsWorkingDate(financialInstruction.Currency, financialInstruction.SettlementDate);

            if (isWorkingDate == false)
            {
                var initialDate = financialInstruction.SettlementDate;

                var errorHandle = 0;

                do
                {
                    initialDate = initialDate.AddDays(1);

                    isWorkingDate = IsWorkingDate(financialInstruction.Currency, initialDate);

                    if (isWorkingDate) financialInstruction.SettlementDate = initialDate;

                    //Only added just in-case something goes wrong and it stop a 
                    //infinite loop happenning
                    ++errorHandle;
                } while (isWorkingDate == false && errorHandle < 3);
            }
        }

        #endregion public methods

        #region private methods

        /// <summary>
        ///     determines if the date passed in is a working date based on the currency
        /// </summary>
        /// <param name="financialInstructionCurrency"></param>
        /// <param name="financialInstructionInstructioDate"></param>
        /// <returns></returns>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date:   30/06/2018
        /// </remarks>
        private bool IsWorkingDate(string financialInstructionCurrency, DateTime financialInstructionInstructioDate)
        {
            var result = true;
            if (_sundayWorkingDayCurrencies.Contains(financialInstructionCurrency.ToUpper()))
                switch (financialInstructionInstructioDate.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                    case DayOfWeek.Saturday:
                    {
                        result = false;
                        break;
                    }
                }
            else
                switch (financialInstructionInstructioDate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                    {
                        result = false;
                        break;
                    }
                }

            return result;
        }

        #endregion private methods
    }
}