package exercise1;

import java.awt.BorderLayout;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JLabel;
import javax.swing.JPanel;

public final class ResultsForm extends JDialog {
    public ResultsForm(MainForm owner, String description, double linearValue, double annualValue) {
        super(owner, "Valuation results", true);
        setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);

        JPanel results = new JPanel(new java.awt.GridLayout(0, 1, 6, 6));
        results.add(new JLabel(description));
        results.add(new JLabel(String.format("Linear depreciation: $%.2f", linearValue)));
        results.add(new JLabel(String.format("Annual depreciation: $%.2f", annualValue)));

        JButton closeButton = new JButton("Close");
        closeButton.addActionListener(event -> dispose());
        JPanel footer = new JPanel();
        footer.add(closeButton);

        add(results, BorderLayout.CENTER);
        add(footer, BorderLayout.SOUTH);
        results.setBorder(javax.swing.BorderFactory.createEmptyBorder(16, 16, 16, 16));
        setSize(430, 170);
        setLocationRelativeTo(null);
    }
}