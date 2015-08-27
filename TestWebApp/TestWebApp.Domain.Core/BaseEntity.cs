using System;

namespace TestWebApp.Domain.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            if (Id < 1)
            {
                CreateDate = DateTime.Now;
            }
            else
            {
                ModifiedDate = DateTime.Now;
            }
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
