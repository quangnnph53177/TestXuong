using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXuong
{
    internal class SinhVien
    {
        private string ma;
        private string ten;
        private int namSinh;
        private double diem;


        public SinhVien()
        {

        }

        public SinhVien(string ma, string ten, int namSinh, double diem)
        {
            this.ma = ma;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public virtual void InThongTin()
        {
            Console.WriteLine($"{ma}|{ten}|{namSinh}|{diem}");
        }
    }
}
