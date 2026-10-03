package exercise2;

import java.awt.Component;
import java.awt.GridLayout;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public final class TripStartForm {
    private TripStartForm() {
    }

    public static int[] showDialog(Component parent) {
        JTextField hourField = new JTextField("0", 5);
        JTextField minuteField = new JTextField("0", 5);
        JTextField seatsField = new JTextField("0", 5);
        JPanel panel = new JPanel(new GridLayout(0, 2, 8, 8));
        panel.add(new JLabel("Departure hour"));
        panel.add(hourField);
        panel.add(new JLabel("Departure minute"));
        panel.add(minuteField);
        panel.add(new JLabel("Seats"));
        panel.add(seatsField);

        int result = JOptionPane.showConfirmDialog(parent, panel, "Trip start", JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE);
        if (result != JOptionPane.OK_OPTION) {
            return null;
        }
        try {
            return new int[] {
                Integer.parseInt(hourField.getText().trim()),
                Integer.parseInt(minuteField.getText().trim()),
                Integer.parseInt(seatsField.getText().trim())
            };
        } catch (NumberFormatException exception) {
            MainForm.showInvalidNumber();
            return showDialog(parent);
        }
    }
}