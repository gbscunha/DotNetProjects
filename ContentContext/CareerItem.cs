using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class CareerItem : Base
    {

        public CareerItem(
            int order, 
            string title, 
            string description, 
            Course course
            )
        {
            if(course == null)
            AddNotification(new Notification("Course", "Curso inválido"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}