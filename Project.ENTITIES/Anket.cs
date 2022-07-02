using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES
{
  public class Anket
    {
        public int Id { get; set; }
        public string SoruTipi { get; set; }
        public string PersonelYorumu { get; set; }
        public bool IsAnonymous { get; set; }
    }
}
