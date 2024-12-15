using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public String Title { get; set; } = null!;
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}