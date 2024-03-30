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
    }
}