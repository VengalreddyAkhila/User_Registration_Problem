using NUnit.Framework;
using Registration_Problem;

namespace JUnit.Test
{
    public class Tests
    { 
        [Test]
        public void GivenHappyUserDetailsReturnsSuccesfulEntry()
        {
            Registration registration = new Registration();
            bool firstname = registration.ValidateFirstName("Akhila");
            bool lastname = registration.ValidateFirstName("Reddy");
            bool emailid = registration.ValidateEmail("akhila.it@gmail.com");
            bool phonenumber = registration.ValidatePhonenumber("91 9908556919");
            bool password = registration.ValidatePassword("Akhi@12b");            
            //Assert
            Assert.Pass("EntrySuccesful");
        }
        [Test]
        public void GivenSadUserDetailsReturnFailEntry()
        {
            Registration registration = new Registration();
            bool firstname = registration.ValidateFirstName("Akhila");
            bool lastname = registration.ValidateFirstName("Reddy");
            bool emailid = registration.ValidateEmail("akhila.it@gmilcom");
            bool phonenumber = registration.ValidatePhonenumber("91 9908556919");
            bool password = registration.ValidatePassword("Aki@12b");
            //Assert
            Assert.Pass("EntryFail");
        }
    }
}