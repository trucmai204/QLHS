using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BangDiem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaBangDiem { get; set; }

        public int MaHS { get; set; }

        public int MaMonHoc { get; set; }

        public float DiemGiuaKyI { get; set; }

        public float DiemCuoiKyI { get; set; }

        public float DiemTrungBinhI { get; set; }

        public float DiemGiuaKyII { get; set; }

        public float DiemCuoiKyII { get; set; }

        public float DiemTrungBinhHKII { get; set; }

        public float DiemTongKet { get; set; }

        public string Loai { get; set; }

        [ForeignKey("MaHS")]
        public HocSinh HocSinh { get; set; }

        [ForeignKey("MaMonHoc")]
        public MonHoc MonHoc { get; set; }
    }
}
