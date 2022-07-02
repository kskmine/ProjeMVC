using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES
{
   public class Sirket
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Sektor { get; set; }
        public string Departman { get; set; }
        public int AnketId { get; set; }

        [ForeignKey("AnketId")]
        public virtual Anket Ankets { get; set; }

        public virtual List<Personel> Personels { get; set; }
    }
}
