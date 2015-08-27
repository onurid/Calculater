using System.Data.Entity;
using System.Linq;
using TestWebApp.Domain;
using TestWebApp.Domain.Model;
using TestWebApp.SqlDb;

namespace TestWebApp.Persistence
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public User[] GetUser()
        {
            return this.GetAll().ToArray();
        }

        public User GetUserById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}
