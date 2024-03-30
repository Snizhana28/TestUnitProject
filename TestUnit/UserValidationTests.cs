using TestUnitProject;

namespace TestUnit
{
    public class UserValidationTests
    {
        //TDD - Test Driven Development

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void UserValidation_IsNicknameValid_InvalidData(string nickname)
        {
            Assert.Throws<ArgumentException>(() => UserValidation.isNicknameValid(nickname));
        }

        [Theory]
        [InlineData("Nickname!@#")]
        [InlineData("4324fds+")]
        public void UserValidation_IsNicknameValid_InvalidNickname(string nickname)
        {
            bool result = UserValidation.isNicknameValid(nickname);
            Assert.False(result);
        }

        [Fact]
        public void UserValidation_IsNicknameValid_ValidNickaname()
        {
            //Triple A (Arrange, Act, Assert)
            //Arrange
            string nickname = "myNickname_";
            //Act
            bool result = UserValidation.isNicknameValid(nickname);
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void UserValidation_IsNameValid_InvalidData(string name)
        {
            Assert.Throws<ArgumentException>(() => UserValidation.isNameValid(name));
        }

        [Theory]
        [InlineData("John123")]
        [InlineData("123John")]
        public void UserValidation_IsNameValid_InvalidName(string name)
        {
            bool result = UserValidation.isNameValid(name);
            Assert.False(result);
        }

        [Fact]
        public void UserValidation_IsNameValid_ValidName()
        {
            //Triple A (Arrange, Act, Assert)
            //Arrange
            string name = "John";
            //Act
            bool result = UserValidation.isNameValid(name);
            //Assert
            Assert.True(result);

            //Assert.Throws<NotImplementedException>(() => UserValidation.isNameValid(name));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void UserValidation_Is_EmailValid_InvalidData(string email)
        {
            Assert.Throws<ArgumentException>(() => UserValidation.isEmailValid(email));
        }



        [Theory]
        [InlineData("admin@com")]
        [InlineData("admin.com")]
        public void UserValidation_Is_EmailValid_InvalidEmail(string email)
        {
            bool result = UserValidation.isEmailValid(email);
            Assert.False(result);
        }

        [Fact]
        public void UserValidation_IsEmailValid_ValidEmail()
        {
            //Triple A (Arrange, Act, Assert)
            //Arrange
            string email = "test_email123@test.com";
            //Act
            bool result = UserValidation.isEmailValid(email);
            //Assert
            Assert.True(result);


        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void UserValidation_Is_PasswordValid_InvalidData(string password)
        {
            Assert.Throws<ArgumentException>(() => UserValidation.isPasswordValid(password));
        }



        [Theory]
        [InlineData("rewiirewrIOrerewhr")]
        [InlineData("4356gfdgfdgtretret")]
        public void UserValidation_Is_PasswordValid_InvalidPassword(string password)
        {
            bool result = UserValidation.isPasswordValid(password);
            Assert.False(result);
        }

        [Fact]
        public void UserValidation_IsPasswordValid_ValidPassword()
        {
            //Triple A (Arrange, Act, Assert)
            //Arrange
            string password = "251208asdfG";
            //Act
            bool result = UserValidation.isPasswordValid(password);
            //Assert
            Assert.True(result);

        }

    }
}