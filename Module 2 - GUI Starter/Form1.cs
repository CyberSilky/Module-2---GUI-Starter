using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2___GUI_Starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double OVER_BUDGET_AMOUNT = 100.00;
            int quantity = 0;
            double item_price = 0;
            double total_price = 0;


            quantity = Convert.ToInt32(txtQuantity.Text);
            item_price = Convert.ToDouble(txtPrice.Text);

            //Calculate the total price
            total_price = item_price * quantity;

            if(total_price > OVER_BUDGET_AMOUNT)
            {
                lblResponse.Text = "You are over budget!";

            }
            else
            {
                lblResponse.Text = "You are under budget";
            }
           
            //Below is another way to write String Interpolation pg. 42 beginning C# 7 Programming With Visual studio 2017
            MessageBox.Show($"The total is {total_price.ToString("C")}" , "The Calculation Response");
        }
    }
}
