using System.Collections.Generic;

namespace ThiTracNghiem.COMMON
{
    public class KeyConst
    {
        public const int THOIGIANTHITOITHIEU = 15;
        public const int THOIGIANTHITOIDA = 150;

        public static string[] LUACHON = new string[26]
        {
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };

        public static int[] TIETBD = new int[7]
        {
          1,2,3,4,5,6,7
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
            public const string KiemTraQuyenTaoCauHoi = "SP_QUYENTAOCAUHOI";
            public const string GetCauHoiByMaCH = "SELECT * FROM CAUHOI WHERE MACH = {0}";
            public const string CountBoDe = "SELECT COUNT(MABODE) FROM BODE";
            public const string CountSV = "SELECT COUNT(MASV) FROM SINHVIEN WHERE MALOP = '{0}'";
            public const string GetKhoaByMaKhoa = "SELECT * FROM KHOA WHERE MAKH = '{0}'";
            public const string GetTDByMaTD = "SELECT * FROM TRINHDO WHERE MATD ='{0}'";
            public const string CountCauHoiByMonHoc = "SELECT COUNT(MACH) FROM CAUHOI WHERE MAMH='{0}' AND TRINHDO = '{1}'";
            public const string LayCauHoiTaoBD = "SP_TAOBODE '{0}','{1}','{2}',{3}";
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

        public static class EmailTag
        {
            public const string Student = "@student.ptithcm.edu.vn";
            public const string Teacher = "@ptithcm.edu.vn";
        }   
    }
}