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
            //Arrange
            string firstname = "Kartik";
            //Act
            bool FirstName = form.ValidFirstName(firstname);
            //Assert
            Assert.IsTrue(FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            //Arrange
            string lastname = "patil";
            //Act
            bool LastName = form.ValidLastName(lastname);
            //Assert
            Assert.IsTrue(LastName);
        }

        [TestMethod]
        public void Email()
        {
            //Arrange
            string email = "kajal.patil95455@yahoo.com";
            //Act
            bool Email = form.ValidEmail(email);
            //Assert
            Assert.IsTrue(Email);
        }

        [TestMethod]
        public void Mobile()
        {
            //Arrange
            string number = "91 8600208237";
            //Act
            bool MobileNumber = form.ValidMobileNumber(number);
            //Assert
            Assert.IsTrue(MobileNumber);
        }

        [TestMethod]
        public void PassWord()
        {
            //Arrange
            string pass = "Kartik@2018";
            //Act
            bool Password = form.ValidPassord(pass);
            //Assert
            Assert.IsTrue(Password);
        }


    }
}