using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new resume instance

        Resume myResume = new Resume();
        myResume._personName = "Okoth Okindo";


        // Create a new job instance named job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Display the company of job1
        //Console.WriteLine(job1._company); // Output: Microsoft
       // job1.DisplayJobDetails();   // Output: Software Engineer (Microsoft) 2019

        // Create a second job instance named job2
        Job job2 = new Job();
        job2._jobTitle = "Product Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // Display the company of job2
       // Console.WriteLine(job2._company); // Output: Apple
      //job2.DisplayJobDetails();

      //Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        // Verify access to the first job title using dot notation
       // Console.WriteLine($"First Job Title: {myResume._jobs[0]._jobTitle}");

        // Display the full resume using the Resume class's Display method
        myResume.Display();
    }
}