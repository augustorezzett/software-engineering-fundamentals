package exercise1;

import exercise1.models.Motorcycle;
import java.awt.BorderLayout;
import java.awt.GridLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JSpinner;
import javax.swing.SpinnerNumberModel;

public final class MainForm extends JFrame {
    private final JTextField brandField = new JTextField();
    private final JSpinner modelYearField = new JSpinner(new SpinnerNumberModel(1800, 1800, 3000, 1));
    private final JSpinner calculationYearField = new JSpinner(new SpinnerNumberModel(1800, 1800, 3000, 1));
    private final JTextField manufacturingValueField = new JTextField();
    private final JTextField depreciationRateField = new JTextField();
    private final JTextField usefulLifeField = new JTextField();

    public MainForm() {
        super("Motorcycle valuation");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setResizable(false);

        JPanel fields = new JPanel(new GridLayout(0, 2, 8, 8));
        addField(fields, "Brand", brandField);
        addField(fields, "Model (year)", modelYearField);
        addField(fields, "Year to calculate", calculationYearField);
        addField(fields, "Manufacturing value ($)", manufacturingValueField);
        addField(fields, "Depreciation rate (e.g. 0.10)", depreciationRateField);
        addField(fields, "Useful life (years)", usefulLifeField);

        JButton calculateButton = new JButton("Calculate cost");
        calculateButton.addActionListener(event -> calculateCost());
        JButton closeButton = new JButton("Close");
        closeButton.addActionListener(event -> dispose());

        JPanel actions = new JPanel();
        actions.add(calculateButton);
        actions.add(closeButton);

        JPanel content = new JPanel(new BorderLayout(8, 12));
        content.add(fields, BorderLayout.CENTER);
        content.add(actions, BorderLayout.SOUTH);
        content.setBorder(javax.swing.BorderFactory.createEmptyBorder(14, 14, 14, 14));
        setContentPane(content);
        pack();
        setLocationRelativeTo(null);
    }

    private static void addField(JPanel panel, String label, java.awt.Component field) {
        panel.add(new JLabel(label));
        panel.add(field);
    }

    private void calculateCost() {
        try {
            String brand = brandField.getText().trim();
            int modelYear = (Integer) modelYearField.getValue();
            int calculationYear = (Integer) calculationYearField.getValue();
            double manufacturingValue = Double.parseDouble(manufacturingValueField.getText().trim());
            double depreciationRate = Double.parseDouble(depreciationRateField.getText().trim());
            int usefulLife = Integer.parseInt(usefulLifeField.getText().trim());

            Motorcycle motorcycle = new Motorcycle(brand, modelYear, manufacturingValue);
            double linearValue = motorcycle.calculateLinearDepreciation(calculationYear, usefulLife);
            double annualValue = motorcycle.calculateAnnualDepreciation(calculationYear, depreciationRate);
            new ResultsForm(this, motorcycle.getDescription(), linearValue, annualValue).setVisible(true);
        } catch (NumberFormatException exception) {
            JOptionPane.showMessageDialog(this, "Enter valid numeric values.", "Invalid input", JOptionPane.ERROR_MESSAGE);
        } catch (ArithmeticException exception) {
            JOptionPane.showMessageDialog(this, exception.getMessage(), "Invalid input", JOptionPane.ERROR_MESSAGE);
        }
    }
}