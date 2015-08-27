using TestWebApp.Domain.Core;
using TestWebApp.Domain.Model;

namespace TestWebApp.Domain
{
    public interface IUserRepository: IRepository<User>
    {
        User[] GetUser();
        User GetUserById(int id);
    }
}