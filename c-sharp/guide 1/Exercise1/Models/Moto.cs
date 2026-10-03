using System;

namespace Exercise1.Models
{
    public class Motorcycle
    {
        public string Brand { get; private set; }
        public int Model { get; private set; }
        public double ManufacturingValue { get; private set; }

        public Motorcycle(string brand, int model, double manufacturingValue)
        {
            Brand = brand;
            Model = model;
            ManufacturingValue = manufacturingValue;
        }

        public double CalculateAnnualDepreciation(int yearToCalculate, double depreciationRate)
        {
            return ManufacturingValue * (Math.Pow(1 - 0.1, yearToCalculate - Model));
        }

        public double CalculateLinearDepreciation(int yearToCalculate, int usefulLife)
        {
            return ManufacturingValue - (ManufacturingValue * (yearToCalculate - Model) / usefulLife);
        }

        public string GetDescription()
        {
            return $"Brand:{Brand}, Model:{Model}, Manufacturing value:${ManufacturingValue,10:f2}";
        }
    }
}
