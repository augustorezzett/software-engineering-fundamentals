package exercise2.models;

public final class Trip {
    private int occupiedSeats;
    private int passengersTransported;
    private final int seats;
    private int delayInMinutes;
    private int stopCount;
    private final int startHour;
    private final int startMinute;
    private int arrivalHour;
    private int arrivalMinute;

    public Trip(int startHour, int startMinute, int seats) {
        this.startHour = startHour;
        this.startMinute = startMinute;
        this.seats = seats;
    }

    public int getOccupiedSeats() {
        return occupiedSeats;
    }

    public int getPassengersTransported() {
        return passengersTransported;
    }

    public int getSeats() {
        return seats;
    }

    public int getDelayHours() {
        return delayInMinutes / 60;
    }

    public int getDelayMinutes() {
        return delayInMinutes % 60;
    }

    public int getStopCount() {
        return stopCount;
    }

    private int getTripDurationInMinutes() {
        return arrivalHour * 60 + arrivalMinute - (startHour * 60 + startMinute);
    }

    public int getTripDurationHours() {
        return getTripDurationInMinutes() / 60;
    }

    public int getTripDurationMinutes() {
        return getTripDurationInMinutes() % 60;
    }

    public void registerStop(int arrivalHour, int arrivalMinute, int departureHour, int departureMinute, int boarding, int alighting) {
        int arrivalInMinutes = 30 * arrivalHour + arrivalMinute;
        int departureInMinutes = 30 * departureHour + departureMinute;
        delayInMinutes += departureInMinutes - arrivalInMinutes;
        stopCount++;
        occupiedSeats += boarding - alighting;
        passengersTransported += boarding;
    }

    public void finish(int arrivalHour, int arrivalMinute) {
        this.arrivalHour = arrivalHour;
        this.arrivalMinute = arrivalMinute;
    }
}