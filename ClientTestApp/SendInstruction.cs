using System;
using System.Net;
using System.Windows.Forms;
using ClientTestApp.Properties;
using Newtonsoft.Json;
using SharedObjects;
using SharedObjects.Enums;

namespace ClientTestApp
{

    /// <summary>
    ///     A Test app to send instructions to the web api
    /// </summary>
    /// <remarks>
    ///     Date:   28/06/2018
    ///     Author: Stephen McCutcheon
    /// </remarks>
    public partial class SendInstruction : Form
    {
        #region constructor

        /// <summary>
        ///    Intiates the test client
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public SendInstruction()
        {
            InitializeComponent();

            ClearValues();
        }

        #endregion constructor

        #region public methods

        /// <summary>
        ///     Send a instruction to the API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private void btnSend_Click(object sender, EventArgs e)
        {
            decimal agreedFx;
            int units;
            decimal pricePerUnit;

            if (decimal.TryParse(textBoxAgreedFx.Text, out agreedFx) == false)
            {
                MessageBox.Show(Settings.Default.ErrorAgreedFx, Settings.Default.ErrorMsg, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(textBoxUnits.Text, out units) == false)
            {
                MessageBox.Show(Settings.Default.UnitsMustBeint, Settings.Default.ErrorMsg, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(textBoxPricePerUnit.Text, out pricePerUnit) == false)
            {
                MessageBox.Show(Settings.Default.PricePerUnitMsg, Settings.Default.ErrorMsg, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            var instruction = new Instruction
            {
                Entity = txtEntity.Text,
                BuyOption = chkBuySell.Checked,
                AgreedFx = agreedFx,
                Currency = textBoxCurrency.Text,
                InstructionDate = dateTimeInstructionPicker.Value,
                SettlementDate = dateTimeSettlementDatePicker.Value,
                Units = units,
                PricePerUnit = pricePerUnit
            };

            var apiServiceUrl = Settings.Default.APIFinancialNet;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var jsonObj = JsonConvert.SerializeObject(instruction);
                var dataString = client.UploadString(apiServiceUrl, jsonObj);
                var data = JsonConvert.DeserializeObject<PostEnumResult>(dataString);

                if (data == PostEnumResult.Success)
                {
                    MessageBox.Show(Settings.Default.APICallSuccessfull, Settings.Default.APICallTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearValues();
                }
                else if (data == PostEnumResult.Error)
                {
                    MessageBox.Show(Settings.Default.APICallGenralError, Settings.Default.APICallTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearValues();
                }
                else if (data == PostEnumResult.ValudationError)
                {
                    MessageBox.Show(Settings.Default.APIValidationFail, Settings.Default.APICallTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        #endregion public methods

        #region private methods

        /// <summary>
        ///     Clear the Values ready to send another message
        /// </summary>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private void ClearValues()
        {
            txtEntity.Text = "";
            textBoxCurrency.Text = "";
            textBoxAgreedFx.Text = Settings.Default.ZeroDecimal;
            textBoxUnits.Text = Settings.Default.ZeroInt;
            textBoxPricePerUnit.Text = Settings.Default.ZeroDecimal;
            txtEntity.Focus();
        }

        #endregion private methods
    }
}