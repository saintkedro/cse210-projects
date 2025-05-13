// Resume.cs

public class Resume
{
    //member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //method to display the resume details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // display the person's name and then iterate through each 
        // Job instance in the list of jobs and display them.

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails(); // This calls the Display method on each job
        }
    }

}




