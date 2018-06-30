using System;
using System.Collections.Generic;
using FinancialInstructionNet.Controllers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedObjects;

namespace FinancialInstructionNetUnitTests
{
    /// <summary>
    ///     Unit tests for checking the following rules work ok
    ///     1. A work week starts monday and ends friday, unless the currency of the trade is AED or SAR,
    ///     where the work week starts sunday and ends thursday, no other holidays to be taken into account
    ///     2. A ttrade can only be settled on a working day
    ///     3. if an instructed settlement date falls on a weekend, then the settlement date should be changed to
    ///     the next working date
    /// </summary>
    /// <remarks>
    ///     Author: Stephen McCutcheon
    ///     Date: 30/06/2018
    /// </remarks>
    [TestClass]
    public class SettlementDateCalculatorTests
    {
        #region tested unit

        /// <summary>
        ///     Unit to be tested
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        private SettlementDateCalculator _settlementDateCalculator;

        #endregion tested unit

        #region set up 

        /// <summary>
        ///     Set up the test
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestInitialize]
        public void Setup()
        {
            var sundayWorkingDayCurrencies = new List<String>()
            {
                "AED",
                "SAR"
            };

            _settlementDateCalculator = new SettlementDateCalculator(sundayWorkingDayCurrencies);
        }

        #endregion set up

        #region tests

        #region sunday 24th June

        /// <summary>
        ///     a non AED, SAR currency  and the date is the sunday 24th June
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void StandardCurrencyRule_Sunday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("24/06/2018"),
                Currency = "GBR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("25/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Sunday 24th June Currency AED has same settlement date
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialAEDCurrencyRule_Sunday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("24/06/2018"),
                Currency = "AED"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("24/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Sunday 24th June Currency SAR has same settlement date
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialSARCurrencyRule_Sunday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("24/06/2018"),
                Currency = "SAR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("24/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        #endregion sunday 24th June

        #region monday 25th June

        /// <summary>
        ///     a non AED, SAR currency  and the date is the monday 25th June
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void StandardCurrencyRule_Monday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("25/06/2018"),
                Currency = "GBR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("25/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Monday 25th June Currency AED has same settlement date
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialAEDCurrencyRule_Monday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("25/06/2018"),
                Currency = "AED"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("25/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on MOnday 25th June Currency SAR has same settlement date
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialSARCurrencyRule_Monday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("25/06/2018"),
                Currency = "SAR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("25/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        #endregion monday 25th June

        #region thursday 28th June

        /// <summary>
        ///     a non AED, SAR currency  and the date is the thursday 28th June
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void StandardCurrencyRule_Thursday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("28/06/2018"),
                Currency = "GBR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("28/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Thursday 28th June Currency AED has same settlement date
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialAEDCurrencyRule_Thursday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("28/06/2018"),
                Currency = "AED"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("28/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Thursday 28th June Currency SAR has same settlement date
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialSARCurrencyRule_Thursday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("28/06/2018"),
                Currency = "SAR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("28/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        #endregion thurday 28th June

        #region friday 29th June

        /// <summary>
        ///     a non AED, SAR currency  and the date is the friday 29th June
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void StandardCurrencyRule_Friday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("29/06/2018"),
                Currency = "GBR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("29/06/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Friday 29th June Currency AED has a setllement date of the 1st July
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialAEDCurrencyRule_Friday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("29/06/2018"),
                Currency = "AED"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("1/07/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Friday 29th June Currency SAR has a settlement date of the 1st July
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialSARCurrencyRule_Friday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("29/06/2018"),
                Currency = "SAR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("01/07/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        #endregion friday 28th June

        #region staurday 30th June

        /// <summary>
        ///     a non AED, SAR currency  and the date is the staurday 30th June
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void StandardCurrencyRule_Saturday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("30/06/2018"),
                Currency = "GBR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("02/07/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Saturday 30th June Currency AED has a setllement date of the 1st July
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialAEDCurrencyRule_Saturday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("30/06/2018"),
                Currency = "AED"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("1/07/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        /// <summary>
        ///     Check on Saturday 30th June Currency SAR has a settlement date of the 1st July
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        [TestMethod]
        [TestCategory("Settlement Date Calculator")]
        public void SpecialSARCurrencyRule_Saturday()
        {
            var financialInstruction = new Instruction
            {
                SettlementDate = Convert.ToDateTime("30/06/2018"),
                Currency = "SAR"
            };

            _settlementDateCalculator.Update(ref financialInstruction);


            var expectedDate = Convert.ToDateTime("01/07/2018");

            Assert.AreEqual(expectedDate, financialInstruction.SettlementDate);
        }

        #endregion Saturday 28th June

        #endregion test
    }
}