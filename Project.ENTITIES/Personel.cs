using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES
{
   public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public int AnketId { get; set; }

        [ForeignKey("AnketId")]
        public virtual Anket Ankets { get; set; }


    }
}
