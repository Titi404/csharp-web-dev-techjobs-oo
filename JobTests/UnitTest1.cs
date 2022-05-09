using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {


        [TestMethod]
        public void EmptyTest() //test one blank
        {
            Assert.AreEqual(0, 0, .001);
        }
        //do 4 ToString() unit tests here  - using toString method from the supporting classes from over there >>>>>>

        [TestMethod]
        public void NameTest()
        {
            Employer test_employer = new Employer("PokemonCodingSchool");
            Assert.AreEqual("PokemonCodingSchool", test_employer.ToString());

            Location test_location = new Location("PokeVerse");
            Assert.AreEqual("PokeVerse", test_location.ToString());

            PositionType test_PositionType = new PositionType("PokeChef");
            Assert.AreEqual("PokeChef", test_PositionType.ToString());

            CoreCompetency test_CoreCompetency = new CoreCompetency("PokeKnife");
            Assert.AreEqual("PokeKnife", test_CoreCompetency.ToString());
        }
        [TestMethod]
        public void BlankSpacesTest()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = test_job.ToString();
            char firstChar = testString[0];
            char secondChar = testString[testString.Length - 1];
            Assert.IsTrue(firstChar == secondChar);
        }

        [TestMethod]
        public void JobTestID()
        {
            Job test_job = new Job();
            Job test_job2 = new Job();
            Assert.AreEqual(2, test_job.Id);
        }


        [TestMethod]
        public void ValueNullTest()
        {
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.AreEqual("\nID: 4\nName: Ice cream tester\nEmployer: Data not available\nLocation: Home\nPosition Type: UX\nCore Competency: Tasting ability\n", job3.ToString());
        }

        //[TestMethod]
        //public void WDFFF()
        //{
        //    Job testingjob = new Job("ABC", new Employer("ABC"), new Location("Denver"), new PositionType("Spelling Bees Master"), new CoreCompetency("Google and Dictionary"));




        

    }
}

