using System;


public class Resume
{   
    // Member variable for the person's name
    public string _personName;

    // Member variable for the list of jobs
    public List<Job> _jobs = new List<Job>();
    
    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Job History:");

        // Loop through each job in the list and display job details
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}