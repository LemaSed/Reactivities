using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class FoundAdd
    {
        public int Id { get; set; }

        public string HeadLine { get; set; }

        public List<string> AddPictures= new List<string>();
        
        public string Description { get; set; }
    }
}