package exercise3;

import exercise3.models.Toll;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;

public final class MainForm extends JFrame {
    private final Toll toll = new Toll();
    private final DefaultListModel<String> summaryModel = new DefaultListModel<>();

    public MainForm() {
        super("Toll form");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(640, 390);

        JList<String> summaryList = new JList<>(summaryModel);
        JButton registerButton = new JButton("Register toll");
        registerButton.addActionListener(event -> registerDailySummary());
        JButton viewButton = new JButton("View summary");
        viewButton.addActionListener(event -> showSummary());

        JPanel actions = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 8));
        actions.add(registerButton);
        actions.add(viewButton);
        add(actions, BorderLayout.NORTH);
        add(new JScrollPane(summaryList), BorderLayout.CENTER);
        setLocationRelativeTo(null);
    }

    private void registerDailySummary() {
        int[] values = DailySummaryForm.showDialog(this);
        if (values != null) {
            toll.registerDailySummary(values[0], values[1]);
        }
    }

    private void showSummary() {
        summaryModel.clear();
        summaryModel.addElement("The days on which more cars entered than the monthly average:");
        int[] days = toll.getDaysAboveAverage();
        for (int day : days) {
            summaryModel.addElement(String.format("%d (amount: %d)", day, toll.getVehiclesForDay(day)));
        }
        summaryModel.addElement("Which third of the month had the highest traffic?");
        summaryModel.addElement(Integer.toString(toll.calculateMonthThirdWithHighestTraffic()));
    }
}