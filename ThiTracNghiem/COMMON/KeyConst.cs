using System.Collections.Generic;

namespace ThiTracNghiem.COMMON
{
    public static class KeyConst
    {
        public static string[] LUACHON =  new string[26]
        {
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };
        
        public static class Lenh
        {
            public const string GetSVByMaSV = "SELECT * FROM SINHVIEN WHERE MASV = '{0}'";
            public const string CountLopByMaKhoa = "SELECT COUNT(MALOP) FROM LOP WHERE MAKH = '{0}'";
            public const string GetAllTrinhDo = "SELECT * FROM TRINHDO";
            public const string GetListLopByMaKhoa = "SELECT * FROM LOP WHERE MAKH = '{0}'";
            public const string CountSVByMaLop = "SELECT COUNT(MALOP) FROM SINHVIEN WHERE MALOP = '{0}'";
            public const string GetLopByMaLop = "SELECT * FROM LOP WHERE MALOP = '{0}'";
            public const string CountGV = "SELECT COUNT(MAGV) FROM GIANGVIEN";
            public const string GetLuaChonByMaCH = "SELECT * FROM LUACHON WHERE MACH ={0}";
            public const string GetTenMonHocByMaMH = "SELECT TENMH FROM MONHOC WHERE MAMH ='{0}'";
        }

        public static class Role
        {
            public const string SINHVIEN = "SINHVIEN";
            public const string GIANGVIEN = "GIANGVIEN";
            public const string KHOA = "KHOA";
            public const string PHONGGIAOVU = "PHONGGIAOVU";
        }

        public static class MaCoSo
        {
            public const string HANOI = "CS1";
            public const string HCM = "CS2";
        }
        public static class MenuStripItemValue
        {
            public const string THEM = "them";
            public const string XOA = "xoa";  
            public const string LUU = "luu";
        }

        public static class MenuStripItemNameKhoa
        {
            public const string THEM = "Thêm khoa mới";
            public const string XOA = "Xóa khoa";  
            public const string LUU = "Lưu";
        }
        public static class MenuStripItemNameLop
        {
            public const string THEM = "Thêm lớp mới";
            public const string XOA = "Xóa lớp";
            public const string LUU = "Lưu";
        }
        public static class MenuStripItemNameSinhVien
        {
            public const string THEM = "Thêm sinh viên mới";
            public const string XOA = "Xóa sinh viên";
            public const string LUU = "Lưu";
        }
        public static class MenuStripItemNameCauHoi
        {
            public const string THEM = "Thêm câu hỏi mới";
            public const string XOA = "Xóa câu hỏi";
            public const string LUU = "Lưu";   
        }
    }
}