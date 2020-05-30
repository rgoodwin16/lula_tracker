using System.Collections.Generic;

namespace LulaTracker.Core.Entities
{
    public class Ticket
    {
        public Ticket()
        {
            this.Attachments = new List<TicketAttachment>();
            this.Comments = new List<TicketComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public TicketStatus Status { get; set; }
        public TicketType Type { get; set; }

        public User Creator { get; set; }
        public User AssignedDeveloper { get; set; }

        public List<TicketAttachment> Attachments { get; set; }
        public List<TicketComment> Comments { get; set; }
    }
}