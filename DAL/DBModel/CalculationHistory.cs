using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModel
{
    public class CalculationHistory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Operand1 { get; set; } // מספרים או מחרוזות
        [MaxLength(50)]
        public string Operand2 { get; set; }
        [MaxLength(50)]
        public string Operation { get; set; } // סוג פעולה (+, -, *, /)
        [MaxLength(2000)]
        public string Result { get; set; } // התוצאה
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<CalculationHistory> calculationHistories { get; set; }
    }
}
