using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookMeCinema_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Encryption()
        {
            //Arrange
            string input = "qwe";
            int key = 4;
            string actual = "uai";

            //Act
            string result = BookMeCinema.SignIn.Encryption(input, key);

            //Assert
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void Test_Descryption()
        {
            //Arrange
            string input = "uai";
            int key = 4;
            string actual = "qwe";

            //Act
            string result = BookMeCinema.SignIn.Decryption(input, key);

            //Assert
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void Test_Cipher()
        {
            //Arrange
            char letter = 'E';
            char ch = 'A';
            int key = 4;

            //Act
            char result = BookMeCinema.SignIn.cipher(ch, key);

            //Assert
            Assert.AreEqual(letter, result);
        }

        [TestMethod]
        public void ValidDate()
        {
            //Arrange
            string date = "2021-11-01 21:00:00";
            //string date2 = "01.11.2021 21:00:00";

            //Act
            bool isValid = BookMeCinema.AddMovie.isValidDate(date);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void ValidTime()
        {
            //Arrange
            string time = "02:30";

            //Act
            bool isValid = BookMeCinema.AddMovie.isValidTime(time);

            //Assert
            Assert.IsTrue(isValid);
        }

    }
}
