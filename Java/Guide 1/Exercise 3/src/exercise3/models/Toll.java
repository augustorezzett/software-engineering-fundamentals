package exercise3.models;

public final class Toll {
    private final int[] vehicleCounts = new int[31];

    public int getVehiclesForDay(int day) {
        if (day >= 1 && day <= 31) {
            return vehicleCounts[day - 1];
        }
        return -1;
    }

    public double getAverageVehiclesPerMonth() {
        int total = 0;
        for (int count : vehicleCounts) {
            total += count;
        }
        return total / 31.0;
    }

    public void registerDailySummary(int day, int vehicleCount) {
        if (day >= 1 && day <= 31) {
            vehicleCounts[day - 1] = vehicleCount;
        }
    }

    public int[] getDaysAboveAverage() {
        double average = getAverageVehiclesPerMonth();
        int count = 0;
        for (int vehicleCount : vehicleCounts) {
            if (vehicleCount > average) {
                count++;
            }
        }
        int[] days = new int[count];
        int index = 0;
        for (int day = 0; day < vehicleCounts.length; day++) {
            if (vehicleCounts[day] > average) {
                days[index++] = day + 1;
            }
        }
        return days;
    }

    public int calculateMonthThirdWithHighestTraffic() {
        int[] periods = new int[3];
        for (int dayIndex = 0; dayIndex < vehicleCounts.length; dayIndex++) {
            if (dayIndex < 10) {
                periods[0] += vehicleCounts[dayIndex];
            } else if (dayIndex < 20) {
                periods[1] += vehicleCounts[dayIndex];
            } else {
                periods[2] += vehicleCounts[dayIndex];
            }
        }
        int highestPeriod = 0;
        for (int period = 1; period < periods.length; period++) {
            if (periods[period] > periods[highestPeriod]) {
                highestPeriod = period;
            }
        }
        return highestPeriod + 1;
    }
}