using Project.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeMVC.Models
{
    public class PersonelViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public int AnketId { get; set; }

        public List<AnketViewModel> Ankets { get; set; }
    }
}
