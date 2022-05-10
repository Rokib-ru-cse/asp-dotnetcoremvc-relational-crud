namespace Aspdotnetmcvcrud.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string course { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}