using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MonHoc
    {
        [Key]
        public int MaMonHoc { get; set; }

        public string TenMonHoc { get; set; }

        public float TyLeDiemGK { get; set; }

        public float TyLeDiemCK { get; set; }

        public short HocKy { get; set; }
    }
}
