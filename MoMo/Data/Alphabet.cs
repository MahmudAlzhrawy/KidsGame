using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoMo.Data
{
    [Table("Alphabets")]
    internal class Alphabet
    {
        [Key]
        public int Alph_ID { get; set; }
        public char Alph { get; set; }
        public byte[] Image { get; set; }
        public byte[] Audio{ get; set; }

    }
}
