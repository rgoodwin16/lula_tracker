using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class Issue : BaseEntity
    {
        public string Summary { get; set; }
        public int ProjectId { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public int ReporterId { get; set; }
        public int? AssignedResourceId { get; set; }

        public Issue()
        {
            Comments = Enumerable.Empty<Comment>();
        }

    }
}