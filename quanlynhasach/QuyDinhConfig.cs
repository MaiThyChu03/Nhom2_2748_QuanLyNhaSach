using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhasach
{
    public static class QuyDinhConfig
    {
        public static bool ApDungQD1_1 { get; set; } = false;
        public static bool ApDungQD1_2 { get; set; } = false;
        public static bool ApDungQD2_2 { get; set; } = false;

        public static int SoLuongNhapToiThieu { get; set; } = 150;
        public static int SoLuongTonToiDa { get; set; } = 300;
        public static int SoLuongTonToiThieuTruocKhiBan { get; set; } = 20;

    }
}
