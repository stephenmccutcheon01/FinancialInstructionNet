using System;
using System.Text;

namespace SharedObjects
{
    /// <summary>
    ///     The instructions sent by client to the web api, Just a simple object which
    ///     Can be converted to json
    /// </summary>
    /// <remarks>
    ///     Date:   28/06/2018
    ///     Author: Stephen McCutcheon
    /// </remarks>
    public class Instruction
    {
        #region constructor
        
        /// <summary>
        ///    Initiates the object
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public Instruction()
        {
            BuyOption = false;
        }


        #endregion constructor

        #region public

        /// <summary>
        ///     Entity
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public string Entity { get; set; }

        /// <summary>
        ///    Buy Options
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public bool BuyOption { get; set; }

        /// <summary>
        ///    Agreed Fx
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public decimal AgreedFx { get; set; }

        /// <summary>
        ///    Currency
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public string Currency { get; set; }

        /// <summary>
        ///     Instruction Date
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public DateTime InstructionDate { get; set; }

        /// <summary>
        ///    Settlement Date
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public DateTime SettlementDate { get; set; }
        
        /// <summary>
        ///     Units
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public int Units { get; set; }


        /// <summary>
        ///    Price Per unit
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public decimal PricePerUnit { get; set; }

        /// <summary>
        ///    USD = Price per unit
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public decimal USD { get; set; }

        #endregion public

        #region public methods

        /// <summary>
        ///    Overriden to allow easy display of the details
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public override string ToString()
        {
            StringBuilder strRow = new StringBuilder();

            strRow.Append("Entity: ");
            strRow.AppendLine(Entity);
            strRow.Append("Buy/Sell: ");
            strRow.AppendLine(BuyOption.ToString());
            strRow.Append("Agreed FX: ");
            strRow.AppendLine(AgreedFx.ToString("F2"));
            strRow.Append("Currency: ");
            strRow.AppendLine(Currency);
            strRow.Append("Instruction Date: ");
            strRow.AppendLine(InstructionDate.ToString("D"));
            strRow.Append("Settlement Date: ");
            strRow.AppendLine(SettlementDate.ToString("D"));
            strRow.Append("Units: ");
            strRow.AppendLine(Units.ToString());
            strRow.Append("Price per unit: ");
            strRow.AppendLine(PricePerUnit.ToString("F2"));
            strRow.Append("USD: ");
            strRow.AppendLine(USD.ToString("F2"));
            strRow.AppendLine();


            return strRow.ToString();
        }

        #endregion public methods
    }
}
