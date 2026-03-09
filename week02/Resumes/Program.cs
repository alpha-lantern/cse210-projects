using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // JOBS
        Job job0 = new Job();
        job0._jobTitle = "Language Teacher";
        job0._company = "Private";
        job0._startYear = 2025;
        job0._endYear = 2025;
        job0.Display();

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2027;
        job1._endYear = 2029;
        job1.Display();
        // Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Google";
        job2._startYear = 2029;
        job2._endYear = 2032;
        job2.Display();

        // RESUME
        Resume myResume = new Resume();
        myResume._name = "Alvin Timana";
        myResume._jobs.Add(job0);
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
        // Console.WriteLine(myResume._jobs[0]._jobTitle);
        // Console.WriteLine(myResume._jobs[1]._jobTitle);
    }
}