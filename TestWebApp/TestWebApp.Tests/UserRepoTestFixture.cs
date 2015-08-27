using NUnit.Framework;
using TestWebApp.Domain;
using TestWebApp.Domain.Model;
using TestWebApp.Persistence;

namespace TestWebApp.Tests
{
    [TestFixture]
    public class UserRepoTestFixture
    {
        private OnurContext context;
        private IUserRepository repository;
        [TestFixtureSetUp]
        public void SetUp()
        {
            context = new OnurContext();
            repository = new UserRepository(context);
        }

        [Test]
        public void Create_User()
        {
            var usr = new User
            {
                Name = "Onur",
                Surname = "Yasar"
            };
            repository.Add(usr);
            repository.Save();
        }
    }
}
