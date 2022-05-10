
namespace Aspdotnetmcvcrud.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}