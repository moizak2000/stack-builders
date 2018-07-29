
using Moq;
using Sample.Entity;
using Sample.Repo.DataContracts;
using Sample.Service;
using Sample.Service.Contracts;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Sample.Tests
{
    public class UserTests
    {
        [Fact]
        public async void InsertData()
        {

            var mockUser = new Mock<IUserRepository>();

            var user = new User { UserId = 1, FirstName = "Moiz", LastName = "Akhter", Email = "moizak2000@yahoo.com", CreatationDate = DateTime.UtcNow };
            mockUser.Setup(x => x.AddAsyn(It.IsAny<User>())).Returns(Task.FromResult(user));
           
            var service = new UserService(mockUser.Object);
            var a = await service.AddAsyn(user);

            Assert.Equal(user.Email, a.Email);
        }
    }
}
