using ClassLibPassword;

namespace PasswordCheckerTests
{
    public class PasswordCheckerTests
    {
        [Fact]
        public void Check_CSymbols_ReturnsTrue()
        {
            // Arrange
            string password = "ASDqw123$";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_4Symbols_ReturnsFalse()
        {
            string password = "Aq1$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ManySymbols_ReturnsFalse()
        {
            string password = "ASDqw123$ASDqwe123$ASDqwe123$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_WithDigits_ReturnsTrue()
        {
            string password = "ASDqwe1$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePasswordDigits(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_WithoutDigits_ReturnsFalse()
        {
            string password = "ASDqweASD$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePasswordDigits(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_WithSpecialSymbols_ReturnsTrue()
        {
            string password = "Aqwe123$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePasswordSpecial (password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_WithoutSpecialSymbols_ReturnsFalse()
        {
            string password = "ASDqwe123";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePasswordSpecial(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_PassWithUpperSymbols_ReturnsTrue()
        {
            string password = "Aqwe123$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePasswordLower(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_PassWithoutUpperSymbols_ReturnsFalse()
        {
            string password = "asdqwe123$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePasswordLower(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_PassWithLowerSymbols_ReturnsTrue() 
        {
            string password = "ASDq121$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePasswordUpper(password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_PassWithoutLowerSymbols_ReturnsFalse()
        {
            string password = "ASDQWE121$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePasswordUpper(password);

            Assert.Equal(expected, actual);
        }



    }
}