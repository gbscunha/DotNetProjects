using System.Collections.Generic;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public String Title { get; set; } = null!;
        public IList<Lecture> Lectures{ get; set; }

    }
}