using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXuong
{
    internal class QLSinhVien
    {
        List<SinhVien> lstSinhVien;
        string input;
        public QLSinhVien()
        {
            lstSinhVien = new List<SinhVien>();
            SinhVien sv1 = new SinhVien("1", "Nguyễn Văn Anh", 2000, 8);
            SinhVien sv2 = new SinhVien("2", "Nguyễn Văn Bình", 2005, 8);
            lstSinhVien.Add(sv1);
            lstSinhVien.Add(sv2);
        }
        public void Nhap()
        {
            do
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine("Xin mời nhập mã");
                sinhVien.Ma = Console.ReadLine();
                Console.WriteLine("Xin mời nhập tên");
                sinhVien.Ten = Console.ReadLine();
                Console.WriteLine("Xin mời nhập năm sinh");
                sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Xin mời nhập điểm");
                sinhVien.Diem = Convert.ToDouble(Console.ReadLine());
                lstSinhVien.Add(sinhVien);
                Console.WriteLine("Bạn có muốn nhập tiếp hay k (Y/N)?");
                input = Console.ReadLine();

            } while (input == "Y" || input == "y");
        }
        private bool CheckCount()
        {
            if (lstSinhVien.Count == 0)
            {
                return true;
            }

            return false;
        }
        public void Xuat()
        {
            if (CheckCount())
            {
                Console.WriteLine();
                return;
            }
            foreach (var item in lstSinhVien)
            {
                item.InThongTin();
            }
        }
        public void XuatDSSinhVienVip()
        {
            if (CheckCount())
            {
                Console.WriteLine();
                return;
            }

            bool isExist = false;

            foreach (var sv in lstSinhVien)
            {
                if (sv.Diem >= 8 && sv.NamSinh > DateTime.Now.Year - 25)
                {
                    sv.InThongTin();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                Console.WriteLine("Không có sinh viên VIP.");
            }
            else
            {
                Console.WriteLine("Đây là kết quả");
            }
        }

        public void XoaDSSinhVienKCoVeHappyBee()
        {
            List<SinhVien> sinhVienCanXoa = new List<SinhVien>();

            foreach (var sv in lstSinhVien)
            {
                if (sv.Diem < 8 || sv.NamSinh < DateTime.Now.Year - 25)
                {
                    sinhVienCanXoa.Add(sv);
                }
            }

            foreach (var sv in sinhVienCanXoa)
            {
                lstSinhVien.Remove(sv);
                Console.WriteLine("Đã xóa thành công sinh viên:");
                sv.InThongTin();
            }
        }
        public void KeThua()
        {
            List<SinhVienUD> sinhVienUDs = new List<SinhVienUD>()
        {
            new SinhVienUD("3","Nguyễn Văn A",2000,8,2),
             new SinhVienUD("4","Nguyễn Văn B",2000,9,3),
        };
            foreach (var sv in lstSinhVien)
            {
                sv.InThongTin();
            }


        }
    }
}
