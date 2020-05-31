using System.Collections.Generic;

namespace LulaTracker.Core.Entities
{
    public class Project
    {

        public Project()
        {
            this.AssignedUsers = new List<User>();
            this.Tickets = new List<Ticket>();
        }

        public int Id { get; set; }
        public User CreatedBy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> AssignedUsers { get; set; }
        public List<Ticket> Tickets { get; set; }
        
    }
}