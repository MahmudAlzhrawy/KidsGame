using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoMo.Data
{
    [Table("Numbers")]
    internal class Number
    {
        [Key]
        public int Nums { get; set; }
        public byte[] Image { get; set; }
        public byte[] Audio { get; set; }
    }
}
