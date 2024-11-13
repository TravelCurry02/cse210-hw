using System;
class Program
{
    static void Main(string[] args)
    {
        Job job01 = new Job();
        job01._jobTitle = "Software Engineer";
        job01._companyName = "Microsoft";
        job01._startYear = 2012;
        job01._endYear = 2020;

        Job job02 = new Job();
        job02._jobTitle = "Supervisor";
        job02._companyName = "Apple";
        job02._startYear = 2020;
        job02._endYear = 2024; 

        Resume my_Resume = new Resume();
        my_Resume._name = "Iguss Self";

        my_Resume._jobs.Add(job01);
        my_Resume._jobs.Add(job02);

        my_Resume.Display();


    }
}