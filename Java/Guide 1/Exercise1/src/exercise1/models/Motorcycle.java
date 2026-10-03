package exercise1.models;

public final class Motorcycle {
    private final String brand;
    private final int modelYear;
    private final double manufacturingValue;

    public Motorcycle(String brand, int modelYear, double manufacturingValue) {
        this.brand = brand;
        this.modelYear = modelYear;
        this.manufacturingValue = manufacturingValue;
    }

    public double calculateAnnualDepreciation(int yearToCalculate, double depreciationRate) {
        return manufacturingValue * Math.pow(1.0 - depreciationRate, yearToCalculate - modelYear);
    }

    public double calculateLinearDepreciation(int yearToCalculate, int usefulLife) {
        if (usefulLife == 0) {
            throw new ArithmeticException("Useful life must not be zero.");
        }
        return manufacturingValue - (manufacturingValue * (yearToCalculate - modelYear) / usefulLife);
    }

    public String getDescription() {
        return String.format("Brand: %s, Model: %d, Manufacturing value: $%.2f", brand, modelYear, manufacturingValue);
    }
}