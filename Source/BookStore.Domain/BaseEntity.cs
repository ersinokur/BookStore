using System;

namespace BookStore.Domain
{
    public class BaseEntity<PrimaryKeyType>
    {
        public virtual PrimaryKeyType Id { get; set; }

        public bool IsActive { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime ModifiedDate { get; set; }
    }
}
