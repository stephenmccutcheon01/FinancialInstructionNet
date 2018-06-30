using System;
using System.Text;

namespace SharedObjects
{
    /// <summary>
    ///     The class represents the object used in the reports
    ///
    ///     1. Amount in USD settled incomiong everyday
    ///     2. Amount in USD settled outgoing erevyday
    /// </summary>
    /// <remarks>
    ///       Author: Stephen McCutcheon
    ///       Created Date: 30/06/2018
    /// </remarks>
    public class UsdTotal
    {
        #region properties

        /// <summary>
        ///     Date
        /// </summary>
        /// <remarks>
        ///       Author: Stephen McCutcheon
        ///       Created Date: 30/06/2018
        /// </remarks>
        public DateTime Date { get; set; }

        /// <summary>
        ///     Total
        /// </summary>
        /// <remarks>
        ///       Author: Stephen McCutcheon
        ///       Created Date: 30/06/2018
        /// </remarks>
        public decimal  Total { get; set; }

        #endregion properties

        #region methods

        /// <summary>
        ///    To String
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///       Author: Stephen McCutcheon
        ///       Created Date: 30/06/2018
        /// </remarks>
        public override string ToString()
        {
            StringBuilder strRow = new StringBuilder();
            strRow.AppendLine("Date: " + Date.Date.ToString("d"));
            strRow.AppendLine("Total: " + Total.ToString("F2"));
            return strRow.ToString();
        }

        #endregion
    }
}
