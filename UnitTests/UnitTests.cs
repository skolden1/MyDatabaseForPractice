using LoginPageDBoevning;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void AddUser_CheckIfUserGetsAddedToDB()
        {
            //Arrange
            
            var mockSet = new Mock<DbSet<User>>();  //representerar db tabellen (mock fejkar den)

            var mockContext = new Mock<AppDbContext>(); //gör riktiga DB till en fake DB

            mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            UserManager uM = new UserManager(mockContext.Object);
            //Act
            uM.CreateUserAcc("testName", "testPw");

            //Assert
            mockSet.Verify(m => m.Add(It.IsAny<User>()), Times.Once);

        }
    }
}