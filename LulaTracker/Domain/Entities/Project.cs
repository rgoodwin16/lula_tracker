using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Issue> Issues { get; set; }

        public Project()
        {
            Issues = Enumerable.Empty<Issue>();
        }

    }
}