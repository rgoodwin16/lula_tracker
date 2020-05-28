namespace LulaTracker.Core
{
    public class Project
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object[] AssignedUsers { get; set; }
        
    }
}