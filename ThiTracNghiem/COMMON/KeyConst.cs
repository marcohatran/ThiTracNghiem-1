namespace ThiTracNghiem.COMMON
{
    public static class KeyConst
    {
        public static class Lenh
        {
            public const string GetSVByMaSV = "SELECT * FROM SINHVIEN WHERE MASV = '{0}'";
            public const string CountLopByMaKhoa = "SELECT COUNT(MALOP) FROM LOP WHERE MAKH = '{0}'";
            public const string GetAllTrinhDo = "SELECT * FROM TRINHDO";
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

        public static class MenuStripItemName
        {
            public const string THEM = "Thêm mới";
            public const string XOA = "Xóa";  
            public const string LUU = "Lưu";
        }
    }
}