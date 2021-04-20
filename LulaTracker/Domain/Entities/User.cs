using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

        public User()
        {
            Issues = Enumerable.Empty<Issue>();
            Comments = Enumerable.Empty<Comment>();
        }

    }
}