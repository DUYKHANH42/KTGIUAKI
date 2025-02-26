using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLGIANGVIEN GV = new QLGIANGVIEN();
            GV.DuLieuSan();
            int chon;
            do
            {
                Console.WriteLine("------------Danh Sách Giảng Viên------------");
                Console.WriteLine("1.Nhập Giảng Viên.");
                Console.WriteLine("2.Xóa Giảng Viên.");
                Console.WriteLine("3.Xuất Giảng Viên.");
                Console.WriteLine("4.Xuất Tổng Tiền Nhà Trường Trả Cho Giảng Viên.");
                Console.WriteLine("5.Thoát");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        GV.NhapDS();
                        break;
                    case 2:
                        GV.XoaGV();
                        break;
                    case 3:
                        GV.XuatDs();
                        break;
                        case 4:
                        GV.TinhTongLuong(); 
                        break;
                        case 5:
                        Console.WriteLine("Thoát.");
                        break;
                }
            }
            while (chon != 5);
            Console.ReadLine();
        }
    }
}
