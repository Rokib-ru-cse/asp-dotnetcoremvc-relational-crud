namespace Aspdotnetmcvcrud.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}