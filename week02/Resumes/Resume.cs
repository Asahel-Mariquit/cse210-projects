public class Resume
{
    public string _name;
        // Initialize list
    public List<Job> _jobs = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        // Iterate through the list
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}