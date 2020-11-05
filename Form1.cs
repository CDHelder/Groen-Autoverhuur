using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groen__Autoverhuur
{
    public partial class Form1 : Form
    {
        bool LoadNullCheck = false;
        public Form1()
        {
            InitializeComponent();

            //makes sure only one of the type of car options can be checked
            if (rbPassengerBus.Checked)
            {
                rbPassengerCar.Checked = false;
            }
            if (rbPassengerCar.Checked)
            {
                rbPassengerBus.Checked = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPrice.Visible = false;
            labelRentalPrice.Visible = false;
        }
        private void NullCheck()
        {
            //Check if all information needed for calculation is given
            if (dateTimePickerStart.Value.Minute == DateTime.Now.Minute)
            {
                MessageBox.Show("Please enter a start date");
                LoadNullCheck = true;
                return;
            }

            if (rbPassengerCar.Checked == false && rbPassengerBus.Checked == false)
            {
                MessageBox.Show("Please enter the type of car");
                LoadNullCheck = true;
                return;
            }

            if (nudAmountKm.Value == 0)
            {
                MessageBox.Show("Please enter the amount of Km");
                LoadNullCheck = true;
                return;
            }
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            //If any information is not given the calculation will stop before it can begin
            NullCheck();
            if (LoadNullCheck == true)
            {
                return;
            }

            //Calculation of days and money for those days
            int rentalDays;
            string rentalDaysMoney;
            rentalDays = dateTimePickerEnd.Value.Day - dateTimePickerStart.Value.Day;
            if (rbPassengerBus.Checked)
            {
                rentalDaysMoney = (rentalDays * 95).ToString();
            }
            if (rbPassengerCar.Checked)
            {
                rentalDaysMoney = (rentalDays * 50).ToString();
            }

            //Calculation of money for kilometers
            int freeKm;
            int payKm;
            freeKm = rentalDays * 100;
            payKm = Convert.ToInt32(nudAmountKm.Value) - freeKm;
            if (payKm < 0)
            {
                payKm = 0;
            }
            if (rbPassengerBus.Checked)
            {
                payKm = payKm * (3/10);
            }
            if (rbPassengerCar.Checked)
            {
                payKm = payKm * (2 / 10);
            }

            /* ~~~~~~ Calculation for refauling the car or bus ~~~~~~
            Since a couple of relevant variables are missing we will be making them
            The avarage gasoline price at 5/11/2020 in the Netherlands is about 1,55 per liter
            According to the internet the most common car in the netherlands is the Volkswagen
            According to research their brand wide avarage L/KM consumption is 8,5L/100Km
            https://www.nrcan.gc.ca/sites/www.nrcan.gc.ca/files/oee/pdf/transportation/tools/fuelratings/2019%20Fuel%20Consumption%20Guide.pdf
            For the passangerbus we will take a standard Volvo bus wich has 13L/100Km consumption
            Gasoline price: 1,55 per liter
            Passanger Car: 8,5L/100Km
            Passanger Bus: 13L/100Km
            */
            int gasMoney;
            if (rbPassengerBus.Checked)
            {
                gasMoney = (Convert.ToInt32(nudAmountKm.Value) / 100) * 13;
            }
            if (rbPassengerCar.Checked)
            {
                gasMoney = (Convert.ToInt32(nudAmountKm.Value) / 100) * (85/10);
            }

            //Total Calculation



            labelPrice.Visible = true;
            labelRentalPrice.Visible = true;
        }
    }
}
