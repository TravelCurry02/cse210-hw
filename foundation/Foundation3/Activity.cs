using System;

namespace ExerciseTracking{
    public abstract class Activity{
        private DateTime _date;
        private int _minutes;

        protected Activity(DateTime date, int minutes){
            _date = date;
            _minutes = minutes;
        }

        public DateTime Date => _date;
        public int Minutes => _minutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary(){
            return $"{Date:dd MMM yyyy} ({Minutes} min): Distance: {GetDistance():F2}, Speed: {GetSpeed():F2}, Pace: {GetPace():F2}";
        }
    }
}