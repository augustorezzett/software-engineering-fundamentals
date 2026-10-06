package exercise3;

import java.awt.Component;
import java.awt.GridLayout;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JSpinner;
import javax.swing.SpinnerNumberModel;
import javax.swing.JTextField;

public final class DailySummaryForm {
    private DailySummaryForm() {
    }

    public static int[] showDialog(Component parent) {
        JSpinner dayField = new JSpinner(new SpinnerNumberModel(1, 1, 31, 1));
        JTextField vehicleCountField = new JTextField("0", 8);
        JPanel panel = new JPanel(new GridLayout(0, 2, 8, 8));
        panel.add(new JLabel("Day"));
        panel.add(dayField);
        panel.add(new JLabel("Number of cars"));
        panel.add(vehicleCountField);

        int result = JOptionPane.showConfirmDialog(parent, panel, "Toll entry", JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE);
        if (result != JOptionPane.OK_OPTION) {
            return null;
        }
        try {
            int vehicleCount = Integer.parseInt(vehicleCountField.getText().trim());
            if (vehicleCount < 0) {
                throw new NumberFormatException();
            }
            return new int[] {(Integer) dayField.getValue(), vehicleCount};
        } catch (NumberFormatException exception) {
            JOptionPane.showMessageDialog(parent, "Enter a non-negative whole number of cars.", "Invalid input", JOptionPane.ERROR_MESSAGE);
            return showDialog(parent);
        }
    }
}