using TestWebApp.Domain.Core;

namespace TestWebApp.Domain.Model
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}