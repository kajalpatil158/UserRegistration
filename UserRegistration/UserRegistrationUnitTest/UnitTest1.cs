using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserRegistrationUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        RegistrationForms form = new RegistrationForms();
        [TestMethod]
            public void FirstName()
            {
                bool FirstName= form.ValidFirstName("Kartik");
                Assert.IsTrue(FirstName);
            }

            [TestMethod]
            public void LastName()
            {
                bool LastName = form.ValidLastName("Patil");
                Assert.IsTrue(LastName);
            }

        [TestMethod]
        public void Email()
        {
            bool Email = form.ValidEmail("Kajalpatil158@gmail.com");
            Assert.IsTrue(Email);
        }

        [TestMethod]
        public void Mobile()
        {
            bool MobileNumber = form.ValidMobileNumber("91 8600208238");
            Assert.IsTrue(MobileNumber);
        }


    }
}