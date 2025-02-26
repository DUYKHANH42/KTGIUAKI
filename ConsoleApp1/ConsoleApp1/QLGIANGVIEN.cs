using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class QLGIANGVIEN
    {
        public List <GIANGVIEN> GIANGVIENList;
        public QLGIANGVIEN()
        {
            GIANGVIENList= new List<GIANGVIEN>();
        }
        public void DuLieuSan()
        {
            GIANGVIENList.Add(new GIANGVIENTG {Maso="123",Hoten= "Nguyễn Văn A",Namsinh=1980,Sotietday=10 });
            GIANGVIENList.Add(new GIANGVIENTG {Maso="133",Hoten= "Nguyễn Văn B",Namsinh=1980,Sotietday=20 });
            GIANGVIENList.Add(new GIANGVIENCH { Maso = "173", Hoten = "Nguyễn Văn Tèo", Namsinh = 1984, Hesoluong = 3 });
            GIANGVIENList.Add(new GIANGVIENCH { Maso = "183", Hoten = "Nguyễn Văn Hai", Namsinh = 1989, Hesoluong = 2 });
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void NhapDS()
        {
            Clear();
            GIANGVIEN gv = null;
            Console.WriteLine("Nhập Mã Số Của Giảng Viên: ");
            string maso=Console.ReadLine();
            foreach (GIANGVIEN Gv in GIANGVIENList)
            {
                if (Gv.Maso==maso)
                {
                    Console.WriteLine("Mã Số Giảng Viên Đã Tồn Tại");
                    return;
                }
            }
            Console.WriteLine("Nhập Họ Tên Giảng Viên: ");
            string hoten=Console.ReadLine();
            Console.WriteLine("Nhập Năm Sinh: ");
            int namsinh=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Giảng Viên Thuộc Loại Nào (1: Giảng Viên Cơ Hữu / 2: Giảng Viên Thỉnh Giảng) :");
            int loaigiangvien=int.Parse(Console.ReadLine());
                if (loaigiangvien == 1)
            {
                gv= new GIANGVIENCH();
                Console.WriteLine("Nhập Hệ Số Lương: ");
                float hesoluong=float.Parse(Console.ReadLine());
                Console.WriteLine("Thêm Giảng Viên Thành Công");
            }
            else if(loaigiangvien == 2)
            {
                gv= new GIANGVIENTG();
                Console.WriteLine("Nhập Số Tiết Đã Dạy:");
                int sotietday=int.Parse(Console.ReadLine());
                Console.WriteLine("Thêm Giảng Viên Thành Công");
            }
            else
            {
                Console.WriteLine("Nhập Sai Loại Giảng Viên");
                return;
            }
        }
            public void XuatDs()
        {
            Clear() ;
            foreach(GIANGVIEN gv in GIANGVIENList) 
            {
                gv.Nhap();
            }    
        }
        public int TinhTongLuong()
        {
            Clear();
            int TinhTongLuong = 0;
       foreach (var GiangVien in GIANGVIENList)
            {
                TinhTongLuong +=GiangVien.TinhLuong();
            }
            Console.WriteLine($"Tổng Số Tiền Mà Nhà Trường Phải Trả Cho Giảng Viên:{TinhTongLuong}");
            return TinhTongLuong;
        }
        public void XoaGV()
        {
            Clear();
            Console.WriteLine("Nhập Mã Số Giảng Viên:");
            string maso = Console.ReadLine();
            foreach (GIANGVIEN GV in GIANGVIENList)
            {
                if (GV.Maso == maso)
                {
                    Console.WriteLine("Xóa Giảng Viên Thành Công");
                    GIANGVIENList.Remove(GV);
                    break;
                }
                else
                {
                    Console.WriteLine("Không Tìm Thấy Mã Số Giảng Viên");
                    return;
                }
            }
        }
    }
}
