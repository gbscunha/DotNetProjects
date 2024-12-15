namespace Balta.NotificationContext
{
    public sealed class Notification
    {

        public List<Notification> Notifications { get; set; }
        public Notification()
        {
            Notifications = new List<Notification>();
        }

        public Notification(string property, string message)
        {
            
            Property = property;
            Message = message;
        }

        public string? Property { get; set; }
        public string? Message { get; set; }
    }


    
}