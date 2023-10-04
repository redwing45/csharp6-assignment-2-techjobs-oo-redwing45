using System;
using System.Reflection;
using System.Text;
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
          StringBuilder builder = new StringBuilder();     //adding newLine
            builder.AppendLine($"ID: {Id}");
            builder.AppendLine($"Name: {Name}");
            builder.AppendLine($"Employer: {EmployerName}");
            builder.AppendLine($"Location: {EmployerLocation}");
            builder.AppendLine($"Position Type: {JobType}");
            builder.AppendLine($"Core Competency: {JobCoreCompetency}");

            if (builder == null)
            {
                Console.WriteLine("Data not available");
            }
            //saying data not availabe            

            return builder.ToString();
        }
        
    }
}
/*
 public static string PropertyList(this object obj)
{
    var props = obj.GetType().GetProperties();
    var sb = new StringBuilder();
    foreach (var p in props)
    {
        sb.AppendLine(p.Name + ": " + p.GetValue(obj, null));
    }
    return sb.ToString();
}
  var DiffString = Environment.NewLine + Name + Environment.NewLine; 
                
*/
