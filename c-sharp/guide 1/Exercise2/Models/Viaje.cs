
namespace Exercise2.Models
{
    public class Trip
    {
        public int OccupiedSeats { get; set; }
        public int PassengersTransported { get; private set; }

        public int Seats { get; private set; }

        public int delayInMinutes;
        public int DelayHours
        {
            get
            {
                return delayInMinutes / 60;
            }
        }
        public int DelayMinutes
        {
            get
            {
                return delayInMinutes % 60;
            }
        }

        public int StopCount { get; private set; }

        int startHour;
        int startMinute;

        int arrivalHour;
        int arrivalMinute;
        private int TripDurationInMinutes
        {
            get
            {
                return arrivalHour * 60 + arrivalMinute - (startHour * 60 + startMinute);
            }
        }
        public int TripDurationHours
        {
            get
            {
                return TripDurationInMinutes / 60;
            }
        }
        public int TripDurationMinutes
        {
            get
            {
                return TripDurationInMinutes % 60;
            }
        }

        public Trip(int startHour, int startMinute, int seats)
        {
            this.startHour = startHour;
            this.startMinute = startMinute;
            this.Seats = seats;
        }

        public void RegisterStop(int arrivalHour, int arrivalMinute,
                                    int departureHour, int departureMinute,
                                    int boarding, int alighting)
        {
            int arrivalInMinutes = 30 * arrivalHour + arrivalMinute;
            int departureInMinutes = 30 * departureHour + departureMinute;

            delayInMinutes += departureInMinutes - arrivalInMinutes;
            StopCount++;

            OccupiedSeats += boarding - alighting;

            PassengersTransported += boarding;
        }

        public void Finish(int arrivalHour, int arrivalMinute)
        {
            this.arrivalHour = arrivalHour;
            this.arrivalMinute = arrivalMinute;
        }
    }
}
