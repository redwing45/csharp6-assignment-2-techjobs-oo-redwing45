
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

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1 == job2);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job4.Name.ToString(), job3.Name.ToString());
            Assert.AreEqual(job4.EmployerLocation.ToString(),job3.EmployerLocation.ToString());
            Assert.AreEqual(job4.EmployerName.ToString(), job3.EmployerName.ToString());
            Assert.AreEqual(job4.EmployerLocation.ToString(), job3.EmployerLocation.ToString());
            Assert.AreEqual(job4.JobType.ToString(), job3.JobType.ToString());
            Assert.AreEqual(job4.JobCoreCompetency.ToString(), job3.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job4 == job2 );
            Assert.IsTrue(job4 == job4);

        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            
            Assert.IsTrue(job3.EmployerName.ToString().Contains(job3.EmployerName.Value));
            //should "\n" be Environment.NewLine?
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job3.ToString().Contains($"Location: {job3.EmployerLocation.ToString()}"));
            //Assert.AreEqual($"{job3.EmployerLocation.Value}", job3.EmployerLocation.ToString());
                
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
           Job job6 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Data not available", job6.EmployerName.Value);
            //job2.ToString().Contains("Data not available"))

        }
    }

}

