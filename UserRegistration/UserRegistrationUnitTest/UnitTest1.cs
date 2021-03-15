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
                bool Actual= form.ValidFirstName("Kartik");
                Assert.IsTrue(Actual);
            }

        
    }
}

