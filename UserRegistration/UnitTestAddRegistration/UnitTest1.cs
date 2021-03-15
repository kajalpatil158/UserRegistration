using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UnitTestAddRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RegistrationForms program = new RegistrationForms();
            int FirstName = program.("Kajal");
            program.Firstname("Kajal", FirstName);
            Assert.AreEqual("Kajal", FirstName);
        }

       
    }
}
