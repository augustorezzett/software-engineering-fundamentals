using System;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class MainForm : Form
    {
        Toll toll = new Toll();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            DailySummaryForm summaryForm = new DailySummaryForm();

            if (summaryForm.ShowDialog() == DialogResult.OK)
            {
                int day = Convert.ToInt32(summaryForm.nudDia.Value);
                int vehicleCount = Convert.ToInt32(summaryForm.tbCantidadAutos.Text);

                toll.RegisterDailySummary(day, vehicleCount);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbVer.Items.Clear();

            lbVer.Items.Add("The days on which more cars entered than the monthly average:");
            int[] days = toll.GetDaysAboveAverage(out int dayCount);

            for (int n = 0; n < dayCount; n++)
            {
                lbVer.Items.Add($"{days[n]} (amount: {toll.GetVehiclesForDay(days[n])})");
            }

            lbVer.Items.Add("Which third of the month had the highest traffic?");
            int third = toll.CalculateMonthThirdWithHighestTraffic();
            
            lbVer.Items.Add(third);
            

        }
    }
}
