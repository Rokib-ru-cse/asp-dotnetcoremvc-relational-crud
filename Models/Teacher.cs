namespace Aspdotnetmcvcrud.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Classroom Classroom { get; set; }
    }
}