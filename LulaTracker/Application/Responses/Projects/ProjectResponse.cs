using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Application.Responses.Projects
{
    public class ProjectResponse
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
        
        public ProjectResponse()
        {
            Issues = new List<Issue>();
        }
    }
}