using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeMVC.Models
{
    public class AnketViewModel
    {
        public int Id { get; set; }
        public string SoruTipi { get; set; }
        public string PersonelYorumu { get; set; }
        public bool IsAnonymous { get; set; }
    }
}
