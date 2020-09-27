namespace David_Hahner_CPRG_200_Lab2
{
    partial class FrmCustomerBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerBill));
            this.txtkWhConsumed = new System.Windows.Forms.TextBox();
            this.lblPowerConsumed = new System.Windows.Forms.Label();
            this.lblAmountCharged = new System.Windows.Forms.Label();
            this.txtSumCharge = new System.Windows.Forms.TextBox();
            this.radInd = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.txtOffPk_kWh = new System.Windows.Forms.TextBox();
            this.lblOffPk_kWh = new System.Windows.Forms.Label();
            this.lblPk_kWh = new System.Windows.Forms.Label();
            this.lblCPC = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblTtlCust = new System.Windows.Forms.Label();
            this.lblSumRes = new System.Windows.Forms.Label();
            this.lblSumInd = new System.Windows.Forms.Label();
            this.lblResSumCharge = new System.Windows.Forms.Label();
            this.lblCustomerNum = new System.Windows.Forms.Label();
            this.lblSumCom = new System.Windows.Forms.Label();
            this.lblComSumCharge = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIndumCharge = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblCustomerData = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.grpCustomer.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkWhConsumed
            // 
            this.txtkWhConsumed.AcceptsReturn = true;
            this.txtkWhConsumed.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtkWhConsumed.CausesValidation = false;
            this.txtkWhConsumed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkWhConsumed.Location = new System.Drawing.Point(362, 170);
            this.txtkWhConsumed.Name = "txtkWhConsumed";
            this.txtkWhConsumed.Size = new System.Drawing.Size(106, 28);
            this.txtkWhConsumed.TabIndex = 2;
            this.txtkWhConsumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPowerConsumed
            // 
            this.lblPowerConsumed.AutoSize = true;
            this.lblPowerConsumed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPowerConsumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerConsumed.ForeColor = System.Drawing.Color.Black;
            this.lblPowerConsumed.Location = new System.Drawing.Point(16, 172);
            this.lblPowerConsumed.Name = "lblPowerConsumed";
            this.lblPowerConsumed.Size = new System.Drawing.Size(241, 24);
            this.lblPowerConsumed.TabIndex = 12;
            this.lblPowerConsumed.Text = "Power Consumption (kWh):";
            this.lblPowerConsumed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountCharged
            // 
            this.lblAmountCharged.AutoSize = true;
            this.lblAmountCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountCharged.ForeColor = System.Drawing.Color.Black;
            this.lblAmountCharged.Location = new System.Drawing.Point(16, 182);
            this.lblAmountCharged.Name = "lblAmountCharged";
            this.lblAmountCharged.Size = new System.Drawing.Size(132, 24);
            this.lblAmountCharged.TabIndex = 13;
            this.lblAmountCharged.Text = "Total Charges:";
            this.lblAmountCharged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSumCharge
            // 
            this.txtSumCharge.BackColor = System.Drawing.Color.Silver;
            this.txtSumCharge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSumCharge.Location = new System.Drawing.Point(234, 182);
            this.txtSumCharge.Name = "txtSumCharge";
            this.txtSumCharge.ReadOnly = true;
            this.txtSumCharge.Size = new System.Drawing.Size(87, 28);
            this.txtSumCharge.TabIndex = 0;
            this.txtSumCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radInd
            // 
            this.radInd.AutoSize = true;
            this.radInd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radInd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radInd.Location = new System.Drawing.Point(335, 47);
            this.radInd.Name = "radInd";
            this.radInd.Size = new System.Drawing.Size(105, 28);
            this.radInd.TabIndex = 3;
            this.radInd.Text = "Industrial";
            this.radInd.UseVisualStyleBackColor = false;
            this.radInd.CheckedChanged += new System.EventHandler(this.radInd_CheckedChanged);
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radCom.Location = new System.Drawing.Point(162, 47);
            this.radCom.Name = "radCom";
            this.radCom.Size = new System.Drawing.Size(132, 28);
            this.radCom.TabIndex = 2;
            this.radCom.Text = "Commercial";
            this.radCom.UseVisualStyleBackColor = false;
            this.radCom.CheckedChanged += new System.EventHandler(this.radCom_CheckedChanged);
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radRes.Checked = true;
            this.radRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radRes.Location = new System.Drawing.Point(20, 47);
            this.radRes.Name = "radRes";
            this.radRes.Size = new System.Drawing.Size(123, 28);
            this.radRes.TabIndex = 1;
            this.radRes.TabStop = true;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = false;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged);
            // 
            // txtOffPk_kWh
            // 
            this.txtOffPk_kWh.AcceptsReturn = true;
            this.txtOffPk_kWh.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOffPk_kWh.CausesValidation = false;
            this.txtOffPk_kWh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOffPk_kWh.Location = new System.Drawing.Point(362, 208);
            this.txtOffPk_kWh.Name = "txtOffPk_kWh";
            this.txtOffPk_kWh.Size = new System.Drawing.Size(106, 28);
            this.txtOffPk_kWh.TabIndex = 3;
            this.txtOffPk_kWh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOffPk_kWh
            // 
            this.lblOffPk_kWh.AutoSize = true;
            this.lblOffPk_kWh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblOffPk_kWh.Location = new System.Drawing.Point(16, 211);
            this.lblOffPk_kWh.Name = "lblOffPk_kWh";
            this.lblOffPk_kWh.Size = new System.Drawing.Size(317, 24);
            this.lblOffPk_kWh.TabIndex = 16;
            this.lblOffPk_kWh.Text = "Off-Peak Power Consumption (kWh):";
            // 
            // lblPk_kWh
            // 
            this.lblPk_kWh.AutoSize = true;
            this.lblPk_kWh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPk_kWh.Location = new System.Drawing.Point(16, 174);
            this.lblPk_kWh.Name = "lblPk_kWh";
            this.lblPk_kWh.Size = new System.Drawing.Size(288, 24);
            this.lblPk_kWh.TabIndex = 13;
            this.lblPk_kWh.Text = "Peak Power Consumption (kWh):";
            // 
            // lblCPC
            // 
            this.lblCPC.AutoSize = true;
            this.lblCPC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPC.Location = new System.Drawing.Point(221, 24);
            this.lblCPC.Name = "lblCPC";
            this.lblCPC.Size = new System.Drawing.Size(311, 36);
            this.lblCPC.TabIndex = 18;
            this.lblCPC.Text = "City Power Company";
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpCustomer.Controls.Add(this.radRes);
            this.grpCustomer.Controls.Add(this.lblPowerConsumed);
            this.grpCustomer.Controls.Add(this.radCom);
            this.grpCustomer.Controls.Add(this.txtOffPk_kWh);
            this.grpCustomer.Controls.Add(this.txtkWhConsumed);
            this.grpCustomer.Controls.Add(this.lblOffPk_kWh);
            this.grpCustomer.Controls.Add(this.radInd);
            this.grpCustomer.Controls.Add(this.lblPk_kWh);
            this.grpCustomer.Controls.Add(this.lblAcctNo);
            this.grpCustomer.Controls.Add(this.txtAccountNo);
            this.grpCustomer.Controls.Add(this.lblCustName);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpCustomer.Location = new System.Drawing.Point(12, 63);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(483, 245);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Info:";
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAcctNo.Location = new System.Drawing.Point(16, 131);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(159, 24);
            this.lblAcctNo.TabIndex = 22;
            this.lblAcctNo.Text = "Account Number:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAccountNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNo.Location = new System.Drawing.Point(192, 127);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(276, 28);
            this.txtAccountNo.TabIndex = 1;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCustName.Location = new System.Drawing.Point(16, 94);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(147, 24);
            this.lblCustName.TabIndex = 24;
            this.lblCustName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.Location = new System.Drawing.Point(192, 91);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(276, 28);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblTtlCust
            // 
            this.lblTtlCust.AutoSize = true;
            this.lblTtlCust.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTtlCust.Location = new System.Drawing.Point(16, 36);
            this.lblTtlCust.Name = "lblTtlCust";
            this.lblTtlCust.Size = new System.Drawing.Size(156, 24);
            this.lblTtlCust.TabIndex = 26;
            this.lblTtlCust.Text = "Total  Customers:";
            // 
            // lblSumRes
            // 
            this.lblSumRes.AutoSize = true;
            this.lblSumRes.Location = new System.Drawing.Point(16, 72);
            this.lblSumRes.Name = "lblSumRes";
            this.lblSumRes.Size = new System.Drawing.Size(183, 24);
            this.lblSumRes.TabIndex = 27;
            this.lblSumRes.Text = "Residential Charges:";
            // 
            // lblSumInd
            // 
            this.lblSumInd.AutoSize = true;
            this.lblSumInd.Location = new System.Drawing.Point(16, 146);
            this.lblSumInd.Name = "lblSumInd";
            this.lblSumInd.Size = new System.Drawing.Size(165, 24);
            this.lblSumInd.TabIndex = 28;
            this.lblSumInd.Text = "Industrial Charges:";
            // 
            // lblResSumCharge
            // 
            this.lblResSumCharge.BackColor = System.Drawing.Color.Silver;
            this.lblResSumCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResSumCharge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblResSumCharge.Location = new System.Drawing.Point(234, 72);
            this.lblResSumCharge.Name = "lblResSumCharge";
            this.lblResSumCharge.Size = new System.Drawing.Size(87, 24);
            this.lblResSumCharge.TabIndex = 29;
            this.lblResSumCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerNum
            // 
            this.lblCustomerNum.BackColor = System.Drawing.Color.Silver;
            this.lblCustomerNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCustomerNum.Location = new System.Drawing.Point(234, 36);
            this.lblCustomerNum.Name = "lblCustomerNum";
            this.lblCustomerNum.Size = new System.Drawing.Size(87, 24);
            this.lblCustomerNum.TabIndex = 31;
            this.lblCustomerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumCom
            // 
            this.lblSumCom.AutoSize = true;
            this.lblSumCom.Location = new System.Drawing.Point(16, 107);
            this.lblSumCom.Name = "lblSumCom";
            this.lblSumCom.Size = new System.Drawing.Size(192, 24);
            this.lblSumCom.TabIndex = 32;
            this.lblSumCom.Text = "Commercial Charges:";
            // 
            // lblComSumCharge
            // 
            this.lblComSumCharge.BackColor = System.Drawing.Color.Silver;
            this.lblComSumCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComSumCharge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblComSumCharge.Location = new System.Drawing.Point(234, 107);
            this.lblComSumCharge.Name = "lblComSumCharge";
            this.lblComSumCharge.Size = new System.Drawing.Size(87, 24);
            this.lblComSumCharge.TabIndex = 33;
            this.lblComSumCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(389, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lblIndumCharge
            // 
            this.lblIndumCharge.BackColor = System.Drawing.Color.Silver;
            this.lblIndumCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndumCharge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblIndumCharge.Location = new System.Drawing.Point(234, 146);
            this.lblIndumCharge.Name = "lblIndumCharge";
            this.lblIndumCharge.Size = new System.Drawing.Size(87, 24);
            this.lblIndumCharge.TabIndex = 36;
            this.lblIndumCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpSummary.Controls.Add(this.lblTtlCust);
            this.grpSummary.Controls.Add(this.txtSumCharge);
            this.grpSummary.Controls.Add(this.lblIndumCharge);
            this.grpSummary.Controls.Add(this.lblAmountCharged);
            this.grpSummary.Controls.Add(this.lblCustomerNum);
            this.grpSummary.Controls.Add(this.lblSumRes);
            this.grpSummary.Controls.Add(this.lblComSumCharge);
            this.grpSummary.Controls.Add(this.lblResSumCharge);
            this.grpSummary.Controls.Add(this.lblSumInd);
            this.grpSummary.Controls.Add(this.lblSumCom);
            this.grpSummary.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpSummary.Location = new System.Drawing.Point(12, 314);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(356, 220);
            this.grpSummary.TabIndex = 37;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary:";
            // 
            // lblCustomerData
            // 
            this.lblCustomerData.AutoSize = true;
            this.lblCustomerData.Location = new System.Drawing.Point(550, 63);
            this.lblCustomerData.Name = "lblCustomerData";
            this.lblCustomerData.Size = new System.Drawing.Size(138, 24);
            this.lblCustomerData.TabIndex = 38;
            this.lblCustomerData.Text = "Customer Data:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 22;
            this.lstCustomers.Location = new System.Drawing.Point(501, 90);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(239, 444);
            this.lstCustomers.TabIndex = 39;
            // 
            // FrmCustomerBill
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 546);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.lblCustomerData);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblCPC);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Bill Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerBill_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomerBill_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkWhConsumed;
        private System.Windows.Forms.Label lblPowerConsumed;
        private System.Windows.Forms.Label lblAmountCharged;
        private System.Windows.Forms.TextBox txtSumCharge;
        private System.Windows.Forms.RadioButton radInd;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.Label lblPk_kWh;
        private System.Windows.Forms.Label lblOffPk_kWh;
        private System.Windows.Forms.TextBox txtOffPk_kWh;
        private System.Windows.Forms.Label lblCPC;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblTtlCust;
        private System.Windows.Forms.Label lblSumRes;
        private System.Windows.Forms.Label lblSumInd;
        private System.Windows.Forms.Label lblResSumCharge;
        private System.Windows.Forms.Label lblCustomerNum;
        private System.Windows.Forms.Label lblSumCom;
        private System.Windows.Forms.Label lblComSumCharge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIndumCharge;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblCustomerData;
        private System.Windows.Forms.ListBox lstCustomers;
    }
}

