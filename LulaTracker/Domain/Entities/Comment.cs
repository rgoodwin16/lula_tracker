using System;

namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int IssueId { get; set; }
        
    }
}