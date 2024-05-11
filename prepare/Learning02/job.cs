using System;

public class Job
{
    public string _jobCompany;
    public string _jobTitle;
    public int _jobStart;
    public int _jobEnd; 

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_jobStart}-{_jobEnd}");
    }
}