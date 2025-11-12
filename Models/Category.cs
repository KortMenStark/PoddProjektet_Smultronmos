using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<string> PodcastIds { get; set; } = new List<string>(); // Lista med poddar i denna kategori 
    }
}
