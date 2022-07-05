using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeMVC.Models
{
    public class StatuViewModel
    {
        public int Id { get; set; }
        public string StatuTipi { get; set; }
        public int AnketId { get; set; }

        public List<AnketViewModel> Ankets { get; set; }
        public List<PersonelViewModel> Personels { get; set; }
    }
}
