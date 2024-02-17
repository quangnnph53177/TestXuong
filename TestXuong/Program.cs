using System;
using System.ComponentModel.Design;
using System.Text;
using TestXuong;

namespace Thitutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();

        }
        static void Menu()
        {
            int chon;
            QLSinhVien service = new QLSinhVien();
            do
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1.Nhập sinh viên");
                Console.WriteLine("2.Xuất đối tượng");
                Console.WriteLine("3,Xuất danh sách sinh viên >=8");
                Console.WriteLine("4.Xóa danh sách sinh viên k có vé dự happy bee ");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("-----------");
                Console.WriteLine("Mời bạn chọn chương trình");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            Console.WriteLine("bạn đã chọn chức năng 1 ");
                            service.Nhap();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Bạn đã chọn chức năng 2 ");
                            service.Xuat();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Bạn đã chọn chức năng 3");
                            service.XuatDSSinhVienVip();
                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("Bạn đã chọn chức năng 4");
                            service.XoaDSSinhVienKCoVeHappyBee();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("bạn đã chọn chức năng 5 ");
                            service.KeThua();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Bạn chọn thoát");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Bạn chọn sai nhập lại");
                        break;


                }
            } while (chon != 0);


        }
    }
}
