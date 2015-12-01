using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogRepo.Models.BaseModels
{
    public class Billede
    {
        public int ID { get; set; }
        public int postID { get; set; }
        public string Filnavn { get; set; }
    }
}
