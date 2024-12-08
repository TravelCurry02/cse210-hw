using System;

// The breathing activity with dynamic animations for the stretch requirement 
class BreathingActivity : MindfulnessActivity{
    public override void RunActivity(){
        StartMessage("Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Each breathing cycle is 6 seconds (3 in, 3 out)
        int cycles = Duration / 6; 
        for (int i = 0; i < cycles; i++){
            Console.Write("Breathe in... ");
            GrowingTextAnimation(3);
            Console.Write("Breathe out... ");
            ShrinkingTextAnimation(3);
        }
        EndMessage("Breathing Activity");
    }

    private void GrowingTextAnimation(int seconds){
        for (int i = 1; i <= seconds; i++){
            Console.Write(new string(' ', i) + "*\r");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    private void ShrinkingTextAnimation(int seconds){
        for (int i = seconds; i >= 1; i--){
            Console.Write(new string(' ', i) + "*\r");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

