
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects

        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        public void TestSettingJobId()
        {
            Assert.IsFalse(job1 == job2);
        }
        
        public void TestJobConstructorSetsAllFields()
        {
            Job job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.Equals(job5, job3);
        }

        public void TestJobsForEquality()
        {
            Assert.IsTrue(job4 == job3 );
        }

        public void TestToStringStartsAndEndsWithNewLine()
        {
            
            Assert.Equals("\n" + job3.EmployerName + "\n", job3.EmployerName);
        }

        public void TestToStringContainsCorrectLabelsAndData()
        {

            Assert.Equals($"Location: {job3.EmployerLocation}", job3.ToString());
                //should "\n" be Environment.NewLine?
        }

        public void TestToStringHandlesEmptyField()
        {
            
        }
    }
}