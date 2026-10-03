using Exercise2.Models;
using System;
using System.Windows.Forms;

namespace Exercise2
{

    public partial class MainForm : Form
    {
        Trip trip;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartTrip_Click(object sender, EventArgs e)
        {
            TripStartForm tripStartForm = new TripStartForm();

            if (tripStartForm.ShowDialog() == DialogResult.OK)
            {
                int startHour = Convert.ToInt32(tripStartForm.tbHInicio.Text);
                int startMinute = Convert.ToInt32(tripStartForm.tbMInicio.Text);
                int seats = Convert.ToInt32(tripStartForm.tbAsientos.Text);

                #region verificando
                bool validHour = startHour >= 0 && startHour <= 23;
                if (validHour == false)
                {
                    MessageBox.Show("Incorrect hour value - the value must be between 0 and 23");
                }

                bool validMinute = startMinute >= 0 && startMinute <= 59;
                if (validMinute == false)
                {
                    MessageBox.Show("Incorrect minute value - the value must be between 0 and 59");
                }
                #endregion

                if (validHour && validMinute)
                {
                    trip = new Trip(startHour, startMinute, seats);

                    #region limpiando controles
                    btnFinalizar.Enabled = true;
                    tbHLLegada.Enabled = true;
                    tbMLLegada.Enabled = true;
                    gbFinalizar.Enabled = true;
                    btnIngresadaParada.Enabled = true;
                    btnIniciar.Enabled = false;
                    tbHLLegada.Clear();
                    tbMLLegada.Clear();
                    #endregion
                }
                else 
                {
                    MessageBox.Show("There was an error entering the data! Please try again.");
                }
            }
            else
            {
                MessageBox.Show("You canceled entering the trip start.");
            }
        }

        private void btnStopEntered_Click(object sender, EventArgs e)
        {
            StopForm stopForm = new StopForm();

            if (stopForm.ShowDialog() == DialogResult.OK)
            {
                int stopArrivalHour = Convert.ToInt32(stopForm.tbHLLegadaParada.Text);
                int stopArrivalMinute = Convert.ToInt32(stopForm.tbMLLegadaParada.Text);

                int stopDepartureHour = Convert.ToInt32(stopForm.tbHSalidaParada.Text);
                int stopDepartureMinute = Convert.ToInt32(stopForm.tbMSalidaParada.Text);

                int boarding = Convert.ToInt32(stopForm.tbAscienden.Text);
                int alighting = Convert.ToInt32(stopForm.tbDescienden.Text);

                #region verificando
                bool validArrivalHour = stopArrivalHour >= 0 && stopArrivalHour <= 23;
                if (validArrivalHour == false)
                {
                    MessageBox.Show("Incorrect hour value - the value must be between 0 and 23");
                }

                bool validArrivalMinute = stopArrivalMinute >= 0 && stopArrivalMinute <= 59;
                if (validArrivalMinute == false)
                {
                    MessageBox.Show("Incorrect minute value - the value must be between 0 and 59");
                }

                bool validDepartureHour = stopDepartureHour >= 0 && stopDepartureHour <= 23;
                if (validDepartureHour == false)
                {
                    MessageBox.Show("Incorrect hour value - the value must be between 0 and 23");
                }

                bool validDepartureMinute = stopDepartureMinute >= 0 && stopDepartureMinute <= 59;
                if (validDepartureMinute == false)
                {
                    MessageBox.Show("Incorrect minute value - the value must be between 0 and 59");
                }
                #endregion

                if (validArrivalHour && validArrivalMinute && validDepartureHour && validDepartureMinute)
                {
                    trip.RegisterStop(stopArrivalHour, stopArrivalMinute,
                                        stopDepartureHour, stopDepartureMinute,
                                        boarding, alighting);
                }
                else
                {
                    MessageBox.Show("There was an error entering the data! Please try again.");
                }
            }
            else
            {
                MessageBox.Show("You canceled entering the stop.");
            }
        }

        private void btnFinishTrip_Click(object sender, EventArgs e)
        {
            int arrivalHour = Convert.ToInt32(tbHLLegada.Text);
            int arrivalMinute = Convert.ToInt32(tbMLLegada.Text);

            #region verificando
            bool validHour = arrivalHour >= 0 && arrivalHour <= 23;
            if (validHour == false)
            {
                MessageBox.Show("Incorrect hour value - the value must be between 0 and 23");
            }

            bool validMinute = arrivalMinute >= 0 && arrivalMinute <= 59;
            if (validMinute == false)
            {
                MessageBox.Show("Incorrect minute value - the value must be between 0 and 59");
            }
            #endregion

            if (validHour && validMinute)
            {
                trip.Finish(arrivalHour, arrivalMinute);

                #region informando resultados

                TravelReportForm travelReportForm = new TravelReportForm();

                travelReportForm.ltbResultados.Items.Clear();
                travelReportForm.ltbResultados.Items.Add($"Total passengers transported: {trip.PassengersTransported}");
                travelReportForm.ltbResultados.Items.Add($"Total travel time: {trip.TripDurationHours,00}:{trip.TripDurationMinutes,00}");
                travelReportForm.ltbResultados.Items.Add($"Number of stops: {trip.StopCount}");
                travelReportForm.ltbResultados.Items.Add($"Total delay time at stops: {trip.DelayHours,00}:{trip.DelayMinutes,00}");

                travelReportForm.ShowDialog();
                #endregion

                #region limpiando controles
                btnFinalizar.Enabled = false;
                tbHLLegada.Enabled = false;
                tbMLLegada.Enabled = false;
                btnIngresadaParada.Enabled = false;
                btnIniciar.Enabled = true;
                #endregion
            }
        }

        private void tbPositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)  || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
