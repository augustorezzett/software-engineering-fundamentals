using Exercise1.Models;
using System;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            string brand = tbMarca.Text;
            int model = Convert.ToInt32(nupModelo.Value);
            int yearToCalculate = Convert.ToInt32(nupAñoCalcular.Value);
            double manufacturingValue = Convert.ToDouble(tbValorFabrica.Text);
            int usefulLife = Convert.ToInt32(tbValorFabrica.Text);
            double depreciationRate = Convert.ToDouble(tbValorFabrica.Text);

            Motorcycle motorcycle = new Motorcycle(brand, model, manufacturingValue);

            ResultsForm resultsForm = new ResultsForm();
            resultsForm.lbxResultados.Items.Add(motorcycle.GetDescription());

            double linearValue = motorcycle.CalculateLinearDepreciation(yearToCalculate, usefulLife);
            resultsForm.lbxResultados.Items.Add($"Linear depreciation: ${linearValue,10:f2}");

            double annualValue = motorcycle.CalculateAnnualDepreciation(yearToCalculate, depreciationRate);
            resultsForm.lbxResultados.Items.Add($"Annual depreciation: ${annualValue,10:f2}");

            resultsForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
