using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string team { get; set; }
        public string city { get; set; }
        public string coach { get; set; }
        public string winslosses { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public List<String> fivestartplayers { get; set; }
    }
}
