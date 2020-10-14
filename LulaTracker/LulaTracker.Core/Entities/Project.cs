using System.Collections.Generic;

namespace LulaTracker.Core.Entities
{
    public class Project
    {

        public Project()
        {
            AssignedUsers = new List<User>();
            Tickets = new List<Ticket>();
        }

        public int Id { get; set; }
        public User CreatedBy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> AssignedUsers { get; private set; }
        public List<Ticket> Tickets { get; private set; }
        
    }
}