using System.ComponentModel.DataAnnotations;

namespace RazorCourseDemo.Model
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public Course Course { get; set; }

        //public ICollection<Course> Courses { get; set; }
    }
}
