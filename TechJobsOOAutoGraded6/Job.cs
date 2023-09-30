using System;
using System.Xml.Linq;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        

        public int Id { get; set; }
        private static int nextId = 1;
        private Employer employer;
        private Location location;
        private PositionType positionType;
        private CoreCompetency coreCompetency;

             public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.\\

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        
        public Job(string name, Employer employername, Location employerlocation, PositionType jobtype, CoreCompetency jobcorecompetency): this()
        {
            Name = name;
            EmployerName = employername;
            EmployerLocation = employerlocation;
            JobType = jobtype;
            JobCoreCompetency = jobcorecompetency;
        }


        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }


        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            var DiffString = "\n" + Name + "\n";
            if (props == null)
            {
                Console.WriteLine("Data not available");
            }
            
        }
    }
}

Console.WriteLine(Name);
