using Project.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeMVC.Models
{
    public class SirketViewModel
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Sektor { get; set; }
        public string Departman { get; set; }
        public int AnketId { get; set; }

        public List<AnketViewModel> Ankets { get; set; }
        public List<PersonelViewModel> Personels { get; set; }
    }
}
