package exercise2;

import java.awt.Component;
import java.awt.GridLayout;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public final class StopForm {
    private StopForm() {
    }

    public static int[] showDialog(Component parent) {
        JTextField arrivalHour = new JTextField("0", 4);
        JTextField arrivalMinute = new JTextField("0", 4);
        JTextField departureHour = new JTextField("0", 4);
        JTextField departureMinute = new JTextField("0", 4);
        JTextField boarding = new JTextField("0", 5);
        JTextField alighting = new JTextField("0", 5);

        JPanel panel = new JPanel(new GridLayout(0, 2, 8, 8));
        panel.add(new JLabel("Arrival hour"));
        panel.add(arrivalHour);
        panel.add(new JLabel("Arrival minute"));
        panel.add(arrivalMinute);
        panel.add(new JLabel("Departure hour"));
        panel.add(departureHour);
        panel.add(new JLabel("Departure minute"));
        panel.add(departureMinute);
        panel.add(new JLabel("Get on"));
        panel.add(boarding);
        panel.add(new JLabel("Get off"));
        panel.add(alighting);

        int result = JOptionPane.showConfirmDialog(parent, panel, "Stop data entry", JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE);
        if (result != JOptionPane.OK_OPTION) {
            return null;
        }
        try {
            return new int[] {
                Integer.parseInt(arrivalHour.getText().trim()),
                Integer.parseInt(arrivalMinute.getText().trim()),
                Integer.parseInt(departureHour.getText().trim()),
                Integer.parseInt(departureMinute.getText().trim()),
                Integer.parseInt(boarding.getText().trim()),
                Integer.parseInt(alighting.getText().trim())
            };
        } catch (NumberFormatException exception) {
            MainForm.showInvalidNumber();
            return showDialog(parent);
        }
    }
}