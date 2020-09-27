using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Calculator to create an energy bill of kWh usage by customer type, validate and unit test the data
 * Individual customer data once added is displayed in a list and stored in a .txt file.
 * Created for use by the City Power Company.
 * Author: David Hahner
 * Date: September 2020
*/

namespace David_Hahner_CPRG_200_Lab2
{
    public partial class FrmCustomerBill : Form
    {
        List<Customer> customerList = new List<Customer>(); // empty list
     
        public FrmCustomerBill()
        {
            InitializeComponent();
        }

        private void FrmCustomerBill_Load(object sender, EventArgs e)
        {
            txtCustomerName.Focus();      // adds focus to the customer name text box
            radRes.Checked = true;        // residential customer set as default as the program starts
            lblPk_kWh.Visible = false;    // hides the peak power label
            lblOffPk_kWh.Visible = false; // hides the off peak power label
            txtOffPk_kWh.Visible = false; // hides the off peak power text
            customerList = CustomerList.ReadCustomers(); // reads customer data from the list, if data exists
            DisplayCustomers(); // display the customer list data, if exists
        }

        // visible lablel/text box settings when residential customer radio selected
        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            lblPowerConsumed.Visible = true; // makes the power consumption text appear
            lblPk_kWh.Visible = false;       // hides the peak power label
            lblOffPk_kWh.Visible = false;    // hides the off peak power label
            txtOffPk_kWh.Visible = false;    // hides the off peak power text
            txtCustomerName.Focus();         // adds focus to the customer name text box
        }

        // visible lablel/text box settings when commercial customer radio selected
        private void radCom_CheckedChanged(object sender, EventArgs e)
        {
            lblPowerConsumed.Visible = true; // makes the power consumption text appear
            lblPk_kWh.Visible = false;       // hides the peak power label
            lblOffPk_kWh.Visible = false;    // hides the off peak power label
            txtOffPk_kWh.Visible = false;    // hides the off peak power text
            txtCustomerName.Focus();         // adds focus to the customer name text box
        }

        // visible lablel/text box settings when industrial customer radio selected
        private void radInd_CheckedChanged(object sender, EventArgs e)
        {
            lblPk_kWh.Visible = true;         // shows the peak power text
            lblPowerConsumed.Visible = false; // makes the power consumption text dissappear
            lblOffPk_kWh.Visible = true;      // shows the off peak power label
            txtOffPk_kWh.Visible = true;      // shows the off peak power text
            txtCustomerName.Focus();          // adds focus to the customer name text box
        }

        // validates the data entries and creates the customers from the inputs when add button clicked
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            if (radRes.Checked) // residential customer radio button selected
            {
                // validation methods to make sure user input is correct for residential customer
                if (Validator.IsProvided(txtAccountNo, "AccountNo") &&
                    Validator.IsNonNegativeInt(txtAccountNo, "AccountNo") &&
                    Validator.IsUnique(txtAccountNo, customerList, "AccountNo") &&
                    Validator.IsProvided(txtCustomerName, "Customer Name") &&
                    Validator.IsProvided(txtkWhConsumed, "Overall Usage") &&
                    Validator.IsNonNegativeInt(txtkWhConsumed, "Overall Usage"))
                {
                    // create a residential customer and get inputs                 
                    ResidentialCustomer c = new ResidentialCustomer();
                    c.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                    c.CustomerName = txtCustomerName.Text;
                    c.kWhConsumed = Convert.ToDouble(txtkWhConsumed.Text);
                    c.ChargeAmount = c.CalculateCharge(); // calculate the customer charge
                    customerList.Add(c); // add the new customer data into the list  
                    Clear(); // clear out the inputs for the next entry
                    DisplayCustomers();  // re-display customers
                }
            }
            else if (radCom.Checked) // commercial customer radio button selected
            {
                // validate the input text boxes 
                if (Validator.IsProvided(txtAccountNo, "AccountNo") &&
                    Validator.IsNonNegativeInt(txtAccountNo, "AccountNo") &&
                    Validator.IsUnique(txtAccountNo, customerList, "AccountNo") &&
                    Validator.IsProvided(txtCustomerName, "Customer Name") &&
                    Validator.IsProvided(txtkWhConsumed, "Overall Usage") &&
                    Validator.IsNonNegativeInt(txtkWhConsumed, "Overall Usage"))
                {
                    // create a commercial customer
                    CommercialCustomer c = new CommercialCustomer();
                    c.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                    c.CustomerName = txtCustomerName.Text;
                    c.kWhConsumed = Convert.ToDouble(txtkWhConsumed.Text);
                    c.ChargeAmount = c.CalculateCharge();
                    customerList.Add(c); // add the new customer data into the list  
                    Clear(); // clear out the inputs for the next entry
                    DisplayCustomers();  // re-display customers
                }
            }
            else // if residential or commercial customer type is not selected, proceeds to the industrial customer
            {
                // validate the input text boxes
                if (Validator.IsProvided(txtAccountNo, "AccountNo") &&
                    Validator.IsNonNegativeInt(txtAccountNo, "AccountNo") &&
                    Validator.IsUnique(txtAccountNo, customerList, "AccountNo") &&
                    Validator.IsProvided(txtCustomerName, "Customer Name") &&
                    Validator.IsProvided(txtkWhConsumed, "Peak Hours Usage") &&
                    Validator.IsNonNegativeInt(txtkWhConsumed, "Peak Hours Usage") &&
                    Validator.IsProvided(txtOffPk_kWh, "Off-peak Hours Usage") &&
                    Validator.IsNonNegativeInt(txtOffPk_kWh, "Off-peak Hours Usage"))
                {
                    // create an industrial customer
                    IndustrialCustomer c = new IndustrialCustomer();
                    c.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                    c.CustomerName = txtCustomerName.Text;
                    c.kWhConsumed = Convert.ToDouble(txtkWhConsumed.Text);
                    c.OffPk_kWh = Convert.ToDouble(txtOffPk_kWh.Text);
                    c.ChargeAmount = c.CalculateCharge();
                    customerList.Add(c); // add the new customer data into the list 
                    Clear(); // clear out the inputs for the next entry
                    DisplayCustomers();  // re-display customers
                }
            }
        }

        // calculate the sum of all the customers charges in the list
        private double SumCharge()
        {
            double sum = 0; 
            foreach (Customer c in customerList)
                sum += c.ChargeAmount;
                    return sum; // sum of all the customer types charges
        }

        // calculate the sum of all the residential customers charge amount in the list
        private double ResSumCharge()
        {
            double resSum = 0; 
            foreach (Customer c in customerList)
                if (c.CustomerType == "R") resSum += c.ChargeAmount;
                    return resSum; // sum of all the residential customer charges
        }

        // calculate the sum of all the commercial customers charge amount in the list
        private double ComSumCharge()
        {
            double comSum = 0; 
            foreach (Customer c in customerList)
                if (c.CustomerType == "C") comSum += c.ChargeAmount;
                    return comSum; // sum of all the commercial customer charges
        }

        // calculate the sum of all the industiral customers charge amount in the list
        private double IndSumCharge()
        {
            double indSum = 0; 
            foreach (Customer c in customerList)
                if (c.CustomerType == "I") indSum += c.ChargeAmount;
                    return indSum; // sum of all the industiral customer charges
        }

        // display the customerlist       
        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear(); // start with empty list box
            foreach (Customer c in customerList)
                lstCustomers.Items.Add(c); // add to the list box
                lblCustomerNum.Text = customerList.Count.ToString(); // count of the customers
                txtSumCharge.Text = SumCharge().ToString("c"); // calculate and display the sum charge 
                // calculate and display the sum charges for each customer type
                lblResSumCharge.Text = ResSumCharge().ToString("c");
                lblComSumCharge.Text = ComSumCharge().ToString("c");
                lblIndumCharge.Text = IndSumCharge().ToString("c");
        }
       
        // reset the inputs to be used after the add button clicked
        private void Clear()
        {
            txtAccountNo.Text = "";
            txtCustomerName.Text = "";
            txtkWhConsumed.Text = "";
            txtOffPk_kWh.Text = "";
            radRes.Checked = true;   // resets to the residential customer as the default
            txtCustomerName.Focus(); // sets focus on customer name as default
        }

        private void FrmCustomerBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerList.SaveCustomers(customerList);  // save the data in the .txt file when form closes
        }
    }
}
