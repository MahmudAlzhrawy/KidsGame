using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoMo.Data
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public String Question_Text { get; set; }
        public String Q_Answer { get; set; }
        public String option_2 { get; set; }
        public String option_3 { get; set; }
        public String option_4 { get; set; }

        public ICollection<Result>Results { get; set; }
    }
}
