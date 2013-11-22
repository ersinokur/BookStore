using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Domain.Entities
{
   public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; } //****** columns birdate
        public DateTime DeathDate { get; set; }
    }
}
