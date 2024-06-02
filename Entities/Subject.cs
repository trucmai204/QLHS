using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float MidtermWeight { get; set; }
        public float FinalWeight { get; set; }
        public short Semester { get; set; }
    }
}
