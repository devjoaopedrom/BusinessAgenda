namespace BusinessAgenda.Core.Entities
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }  // ex: "Manager", "Supervisor"
        public ICollection<UserSkill> UserSkills { get; set; }
    }
}