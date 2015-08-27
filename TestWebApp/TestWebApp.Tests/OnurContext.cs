using System.Data.Entity;

namespace TestWebApp.Tests
{
    public class OnurContext : DbContext
    {
        public OnurContext()
            : base("name=OnurContext")
        {
        }
    }
}