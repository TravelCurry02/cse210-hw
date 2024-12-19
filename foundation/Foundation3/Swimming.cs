using System;

namespace ExerciseTracking{
    public class Swimming : Activity{
        private int _laps;

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes){
            _laps = laps;
        }

        public override double GetDistance() => _laps * 50 / 1000.0 * 0.62; 
        public override double GetSpeed() => (GetDistance() / Minutes) * 60;
        public override double GetPace() => Minutes / GetDistance();

        public override string GetSummary(){
            return $"{Date:dd MMM yyyy} Swimming ({Minutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
        }
    }
}