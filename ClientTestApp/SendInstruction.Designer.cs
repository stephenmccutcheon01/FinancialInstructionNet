namespace ClientTestApp
{
    partial class SendInstruction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntity = new System.Windows.Forms.Label();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.BuyTicketsLabel = new System.Windows.Forms.Label();
            this.chkBuySell = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxAgreedFx = new System.Windows.Forms.TextBox();
            this.AgreedFxLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.InstructionDatelabel = new System.Windows.Forms.Label();
            this.dateTimeInstructionPicker = new System.Windows.Forms.DateTimePicker();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.PricePerUnitlabel = new System.Windows.Forms.Label();
            this.textBoxPricePerUnit = new System.Windows.Forms.TextBox();
            this.dateTimeSettlementDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SettlementDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(41, 31);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(36, 13);
            this.lblEntity.TabIndex = 0;
            this.lblEntity.Text = "Entity:";
            // 
            // txtEntity
            // 
            this.txtEntity.Location = new System.Drawing.Point(218, 27);
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(100, 20);
            this.txtEntity.TabIndex = 1;
            // 
            // BuyTicketsLabel
            // 
            this.BuyTicketsLabel.AutoSize = true;
            this.BuyTicketsLabel.Location = new System.Drawing.Point(41, 51);
            this.BuyTicketsLabel.Name = "BuyTicketsLabel";
            this.BuyTicketsLabel.Size = new System.Drawing.Size(160, 13);
            this.BuyTicketsLabel.TabIndex = 2;
            this.BuyTicketsLabel.Text = "Buy (Ticked) / Sell (Not Ticked):";
            // 
            // chkBuySell
            // 
            this.chkBuySell.AutoSize = true;
            this.chkBuySell.Location = new System.Drawing.Point(218, 50);
            this.chkBuySell.Name = "chkBuySell";
            this.chkBuySell.Size = new System.Drawing.Size(15, 14);
            this.chkBuySell.TabIndex = 2;
            this.chkBuySell.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(281, 229);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBoxAgreedFx
            // 
            this.textBoxAgreedFx.Location = new System.Drawing.Point(218, 69);
            this.textBoxAgreedFx.Name = "textBoxAgreedFx";
            this.textBoxAgreedFx.Size = new System.Drawing.Size(100, 20);
            this.textBoxAgreedFx.TabIndex = 3;
            this.textBoxAgreedFx.Text = "0.00";
            // 
            // AgreedFxLabel
            // 
            this.AgreedFxLabel.AutoSize = true;
            this.AgreedFxLabel.Location = new System.Drawing.Point(41, 73);
            this.AgreedFxLabel.Name = "AgreedFxLabel";
            this.AgreedFxLabel.Size = new System.Drawing.Size(58, 13);
            this.AgreedFxLabel.TabIndex = 6;
            this.AgreedFxLabel.Text = "Agreed Fx:";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(41, 98);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(52, 13);
            this.CurrencyLabel.TabIndex = 7;
            this.CurrencyLabel.Text = "Currency:";
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(218, 94);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrency.TabIndex = 4;
            // 
            // InstructionDatelabel
            // 
            this.InstructionDatelabel.AutoSize = true;
            this.InstructionDatelabel.Location = new System.Drawing.Point(41, 125);
            this.InstructionDatelabel.Name = "InstructionDatelabel";
            this.InstructionDatelabel.Size = new System.Drawing.Size(85, 13);
            this.InstructionDatelabel.TabIndex = 9;
            this.InstructionDatelabel.Text = "Instruction Date:";
            // 
            // dateTimeInstructionPicker
            // 
            this.dateTimeInstructionPicker.Location = new System.Drawing.Point(218, 119);
            this.dateTimeInstructionPicker.Name = "dateTimeInstructionPicker";
            this.dateTimeInstructionPicker.Size = new System.Drawing.Size(128, 20);
            this.dateTimeInstructionPicker.TabIndex = 5;
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(41, 171);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(34, 13);
            this.unitsLabel.TabIndex = 11;
            this.unitsLabel.Text = "Units:";
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(218, 167);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnits.TabIndex = 7;
            this.textBoxUnits.Text = "0";
            // 
            // PricePerUnitlabel
            // 
            this.PricePerUnitlabel.AutoSize = true;
            this.PricePerUnitlabel.Location = new System.Drawing.Point(41, 196);
            this.PricePerUnitlabel.Name = "PricePerUnitlabel";
            this.PricePerUnitlabel.Size = new System.Drawing.Size(75, 13);
            this.PricePerUnitlabel.TabIndex = 13;
            this.PricePerUnitlabel.Text = "Price Per Unit:";
            // 
            // textBoxPricePerUnit
            // 
            this.textBoxPricePerUnit.Location = new System.Drawing.Point(218, 192);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxPricePerUnit.TabIndex = 8;
            this.textBoxPricePerUnit.Text = "0.00";
            // 
            // dateTimeSettlementDatePicker
            // 
            this.dateTimeSettlementDatePicker.Location = new System.Drawing.Point(218, 144);
            this.dateTimeSettlementDatePicker.Name = "dateTimeSettlementDatePicker";
            this.dateTimeSettlementDatePicker.Size = new System.Drawing.Size(128, 20);
            this.dateTimeSettlementDatePicker.TabIndex = 6;
            // 
            // SettlementDateLabel
            // 
            this.SettlementDateLabel.AutoSize = true;
            this.SettlementDateLabel.Location = new System.Drawing.Point(41, 148);
            this.SettlementDateLabel.Name = "SettlementDateLabel";
            this.SettlementDateLabel.Size = new System.Drawing.Size(86, 13);
            this.SettlementDateLabel.TabIndex = 15;
            this.SettlementDateLabel.Text = "Settlement Date:";
            // 
            // SendInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 266);
            this.Controls.Add(this.dateTimeSettlementDatePicker);
            this.Controls.Add(this.SettlementDateLabel);
            this.Controls.Add(this.textBoxPricePerUnit);
            this.Controls.Add(this.PricePerUnitlabel);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.unitsLabel);
            this.Controls.Add(this.dateTimeInstructionPicker);
            this.Controls.Add(this.InstructionDatelabel);
            this.Controls.Add(this.textBoxCurrency);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.AgreedFxLabel);
            this.Controls.Add(this.textBoxAgreedFx);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chkBuySell);
            this.Controls.Add(this.BuyTicketsLabel);
            this.Controls.Add(this.txtEntity);
            this.Controls.Add(this.lblEntity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SendInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test App: Send Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.Label BuyTicketsLabel;
        private System.Windows.Forms.CheckBox chkBuySell;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxAgreedFx;
        private System.Windows.Forms.Label AgreedFxLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.Label InstructionDatelabel;
        private System.Windows.Forms.DateTimePicker dateTimeInstructionPicker;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label PricePerUnitlabel;
        private System.Windows.Forms.TextBox textBoxPricePerUnit;
        private System.Windows.Forms.DateTimePicker dateTimeSettlementDatePicker;
        private System.Windows.Forms.Label SettlementDateLabel;
    }
}

