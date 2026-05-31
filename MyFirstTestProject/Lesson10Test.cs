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
}
