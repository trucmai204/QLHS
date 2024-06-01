using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LopHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLop { get; set; }

        public string TenLop { get; set; }

        public int MaKhoi { get; set; }

        [ForeignKey("MaKhoi")]
        public KhoiLop KhoiLop { get; set; }
    }
}
