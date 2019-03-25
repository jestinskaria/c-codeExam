using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Train trainObj = new Train();
            txtSeatFare.Text = Convert.ToString(trainObj.seatFare);
            txtFarePerKg.Text = Convert.ToString(trainObj.farePerKg);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFarePerKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Train trainObj = new Train();
            Luggage luggageObj = new Luggage();
            Fare fareObj = new Fare();

            trainObj.SetCustomerDetails(Convert.ToDouble(txtResId.Text), txtCustomerName.Text, txtContactNo.Text,
                Convert.ToDouble(txtNoOfSeats.Text), Convert.ToDouble(txtTotalWeight.Text));

            double totalSeatFare = fareObj.TotalSeatFare(Convert.ToDouble(txtNoOfSeats.Text));
            double totalLuggageFare = luggageObj.TotalLuggageFare(Convert.ToDouble(txtTotalWeight.Text));

            double totalAllFare = totalSeatFare + totalLuggageFare;

            txtTotalSeatFare.Text = Convert.ToString(totalSeatFare);
            txtTotalLuggFare.Text = Convert.ToString(totalLuggageFare);

            string message = "Your seat charge is $" + totalSeatFare + " & Your luggage charge is $" + totalLuggageFare +
                " Total Ticket Charge is $"+ totalAllFare;
            MessageBox.Show(message, "Ticket Charge", MessageBoxButtons.OK);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtResId.Text = "";
            txtContactNo.Text = "";
            txtNoOfSeats.Text = "";
            txtTotalWeight.Text = "";
        }
    }
}
