using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBT.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public string idKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        [MaxLength(11)]
        public string SodienThoai { get; set; }
        public string Address { get; set; }

    }
}