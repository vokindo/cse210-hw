using System;

public class Job
{
    // Public member variables (allowing direct access)
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display job information
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}