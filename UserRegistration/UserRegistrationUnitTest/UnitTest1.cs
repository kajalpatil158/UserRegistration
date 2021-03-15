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


    }
}

