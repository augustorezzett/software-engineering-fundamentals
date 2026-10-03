package exercise2;

import exercise2.models.Trip;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public final class MainForm extends JFrame {
    private final JButton startButton = new JButton("Start trip");
    private final JButton stopButton = new JButton("Stop entered");
    private final JButton finishButton = new JButton("Finish trip");
    private final JTextField arrivalHourField = new JTextField(3);
    private final JTextField arrivalMinuteField = new JTextField(3);
    private Trip trip;

    public MainForm() {
        super("Travel company");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setResizable(false);

        startButton.addActionListener(event -> startTrip());
        stopButton.addActionListener(event -> enterStop());
        finishButton.addActionListener(event -> finishTrip());

        JPanel controls = new JPanel(new FlowLayout(FlowLayout.LEFT, 10, 10));
        controls.add(startButton);
        controls.add(stopButton);

        JPanel finishPanel = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 8));
        finishPanel.setBorder(javax.swing.BorderFactory.createTitledBorder("Trip completion"));
        finishPanel.add(new JLabel("End time (HH:MM)"));
        finishPanel.add(arrivalHourField);
        finishPanel.add(new JLabel(":"));
        finishPanel.add(arrivalMinuteField);
        finishPanel.add(finishButton);

        JPanel content = new JPanel(new BorderLayout(8, 8));
        content.add(controls, BorderLayout.NORTH);
        content.add(finishPanel, BorderLayout.CENTER);
        content.setBorder(javax.swing.BorderFactory.createEmptyBorder(8, 8, 8, 8));
        setContentPane(content);

        stopButton.setEnabled(false);
        setTripActive(false);
        pack();
        setLocationRelativeTo(null);
    }

    private void startTrip() {
        int[] values = TripStartForm.showDialog(this);
        if (values == null) {
            JOptionPane.showMessageDialog(this, "You canceled entering the trip start.");
            return;
        }
        if (!isValidTime(values[0], values[1])) {
            return;
        }
        trip = new Trip(values[0], values[1], values[2]);
        arrivalHourField.setText("");
        arrivalMinuteField.setText("");
        stopButton.setEnabled(true);
        setTripActive(true);
    }

    private void enterStop() {
        if (trip == null) {
            return;
        }
        int[] values = StopForm.showDialog(this);
        if (values == null) {
            JOptionPane.showMessageDialog(this, "You canceled entering the stop.");
            return;
        }
        if (!isValidTime(values[0], values[1]) || !isValidTime(values[2], values[3])) {
            return;
        }
        trip.registerStop(values[0], values[1], values[2], values[3], values[4], values[5]);
    }

    private void finishTrip() {
        if (trip == null) {
            return;
        }
        try {
            int hour = Integer.parseInt(arrivalHourField.getText().trim());
            int minute = Integer.parseInt(arrivalMinuteField.getText().trim());
            if (!isValidTime(hour, minute)) {
                return;
            }
            trip.finish(hour, minute);
            TravelReportForm.showReport(this, trip);
            trip = null;
            stopButton.setEnabled(false);
            setTripActive(false);
        } catch (NumberFormatException exception) {
            showInvalidNumber();
        }
    }

    private boolean isValidTime(int hour, int minute) {
        if (hour < 0 || hour > 23) {
            JOptionPane.showMessageDialog(this, "Incorrect hour value - the value must be between 0 and 23");
            return false;
        }
        if (minute < 0 || minute > 59) {
            JOptionPane.showMessageDialog(this, "Incorrect minute value - the value must be between 0 and 59");
            return false;
        }
        return true;
    }

    private void setTripActive(boolean active) {
        startButton.setEnabled(!active);
        arrivalHourField.setEnabled(active);
        arrivalMinuteField.setEnabled(active);
        finishButton.setEnabled(active);
    }

    static void showInvalidNumber() {
        JOptionPane.showMessageDialog(null, "Enter valid numeric values.", "Invalid input", JOptionPane.ERROR_MESSAGE);
    }
}