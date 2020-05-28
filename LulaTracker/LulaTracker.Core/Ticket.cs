using System;
using System.Collections.Generic;
namespace LulaTracker.Core
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Reporter { get; set; }
        public List<Array> Comments { get; set; }

    }
}