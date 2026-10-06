package exercise2;

import exercise2.models.Trip;
import java.awt.Component;
import javax.swing.JOptionPane;

public final class TravelReportForm {
    private TravelReportForm() {
    }

    public static void showReport(Component parent, Trip trip) {
        String report = String.format(
            "Total passengers transported: %d%nTotal travel time: %02d:%02d%nNumber of stops: %d%nTotal delay time at stops: %02d:%02d",
            trip.getPassengersTransported(),
            trip.getTripDurationHours(),
            trip.getTripDurationMinutes(),
            trip.getStopCount(),
            trip.getDelayHours(),
            trip.getDelayMinutes());
        JOptionPane.showMessageDialog(parent, report, "Report", JOptionPane.INFORMATION_MESSAGE);
    }
}