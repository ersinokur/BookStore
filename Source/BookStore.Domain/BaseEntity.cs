using System;

namespace BookStore.Domain
{
    public class BaseEntity //<PrimaryKeyType>
    {
        // public virtual PrimaryKeyType Id { get; set; }

        public bool IsActive { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime ModifiedDate { get; set; }

        public virtual string CreateUser { get; set; }

        public virtual string ModifiedUser { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}