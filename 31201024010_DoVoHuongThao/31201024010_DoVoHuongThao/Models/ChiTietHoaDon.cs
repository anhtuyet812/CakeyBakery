﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _31201024010_DoVoHuongThao.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        public int MaChiTietHoaDon { get; set; }
        [ForeignKey("HoaDonObj")]
        public int MaHoaDon { get; set; }
        public virtual HoaDon HoaDonObj { get; set; }
        [ForeignKey("MovieObj")]
        public int MaMovie { get; set; }
        public virtual Movie MovieObj { get; set; }
        public int SoLuong { get; set; }
    }
}