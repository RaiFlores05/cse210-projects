using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "CIBERTEC";
        job1._startYear = 2024;
        job1._endYear = 2026;

        //job1.DisplayJobInformation();

        Job job2 = new Job();
        job2._jobTitle = "Web Engineer";
        job2._company = "APPLE";
        job2._startYear = 2024;
        job2._endYear = 2026;

        //job2.DisplayJobInformation();

        Resume myResume = new Resume();
        myResume._name = "Raí Flores";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.DisplayResume();

    }
}