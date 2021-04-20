using System;

namespace Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
    }
}