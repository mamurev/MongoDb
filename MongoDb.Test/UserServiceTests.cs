using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDb.Core;
using System.Collections.Generic;

namespace MongoDb.Test
{
    [TestClass]
    public class UserServiceTests
    {
        private UserService service;
        public UserServiceTests()
        {
            IMongoDbSettings settings = new MongoDbSettings
            {
                ConnectionString = "mongodb://localhost:27017",
                Database = "test",
                Collection = "user"
            };
            service = new UserService(settings);
        }

        [TestMethod]
        public void GetAll_Should_Return_Users()
        {
            var users = service.GetAll();
            Assert.AreNotEqual(0, users.Count);
        }

        [TestMethod]
        public void GetSingle_Should_Return_A_User_ById()
        {
            var userId = 1;
            User user = service.GetSingle(userId);
            Assert.IsNotNull(user);
            Assert.AreEqual("Bret", user.UserName);
        }

    }
}
