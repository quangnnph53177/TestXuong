using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXuong
{
    internal class SinhVienUD : SinhVien
    {
        private int kiHoc;
        public SinhVienUD()
        {

        }

        public SinhVienUD(string ma, string ten, int namSinh, double diem, int kiHoc)
        {
            this.KiHoc = kiHoc;
        }

        public int KiHoc { get => kiHoc; set => kiHoc = value; }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"{kiHoc}");
        }




    }
}
