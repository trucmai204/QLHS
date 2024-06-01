using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HocSinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHS { get; set; }

        public string TenHS { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        public int MaLop { get; set; }

        [ForeignKey("MaLop")]
        public LopHoc LopHoc { get; set; }
    }
}
