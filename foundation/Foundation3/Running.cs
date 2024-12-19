using System;

namespace ExerciseTracking{
    public class Running : Activity{
        private double _distance;

        public Running(DateTime date, int minutes, double distance) : base(date, minutes){
            _distance = distance;
        }

        public override double GetDistance() => _distance;
        public override double GetSpeed() => (GetDistance() / Minutes) * 60;
        public override double GetPace() => Minutes / GetDistance();

        public override string GetSummary(){
            return $"{Date:dd MMM yyyy} Running ({Minutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
        }
    }
}
