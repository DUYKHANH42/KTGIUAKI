using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GIANGVIENCH : GIANGVIEN
    {
        private float HeSoLuong;
        public GIANGVIENCH(float heSoLuong):base( )
        {
            this.HeSoLuong = heSoLuong;
        }
        public GIANGVIENCH(): base( )
        {
            HeSoLuong = 0;
        }
        public float Hesoluong
        {
            get { return HeSoLuong; }
            set {HeSoLuong=value; }
        }
        public override int TinhLuong()
        {

            int TinhLuong =(int) HeSoLuong * 2340000;
            return TinhLuong;
        }
        public override void Nhap()
        {
            Console.WriteLine($"Mã Số Giảng Viên: {Maso}"+
                              $"\nHọ Tên Giảng Viên: {Hoten}"+
                              $"\nNăm Sinh: {Namsinh}"+
                              $"\nHệ Số Lương: {HeSoLuong}"+
                              $"\nTính Lương: {TinhLuong()}");
                 
        }
    }
}
