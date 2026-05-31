using Microsoft.VisualStudio.TestTools.UnitTesting;
using Myfirstapplication;
namespace MyFirstTestProject

{
    [TestClass]
    public sealed class Lesson10Test
    {
        [TestMethod]
        public void FirstName_LastName_ZipCode_Verify()
        {
            // arranged
            string firstName = "George";
            string lastName = "Washington";
            int zipCode = 64119;
            Lesson10 myLesson10 = new Lesson10(firstName, lastName, zipCode);

            // act - nothing for this one

            // assert
            Assert.AreEqual(firstName, myLesson10._FirstName);
            Assert.AreEqual(lastName, myLesson10.LastName);
            Assert.AreEqual(zipCode, myLesson10.Zipcode);
        }
    }

       

namespace MyTests
    {
        public class Lesson10
        {
            public int Id { get; set; }
        }

        [TestClass]
        public class Lesson10Tests
        {
            [TestMethod]
            public void IdVerify()
            { 
                int id = 256;
                Lesson10 myLesson10 = new Lesson10();

                myLesson10.Id = id;

                Assert.AreEqual(id, myLesson10.Id, "The Id property did not return the expected value.");
            }
        }
    }

}

