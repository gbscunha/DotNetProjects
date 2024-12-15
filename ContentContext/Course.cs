using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Course : Content 
    {
        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
        public String Tag { get; set; } = null!;
        public IList<Module> Modules{ get; set; } // Inicialização da lista
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
    
}