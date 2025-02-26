using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GIANGVIENTG :GIANGVIEN
    {
        private int SoTietDay;
        public GIANGVIENTG(int soTietDay): base() 
        {
            this.SoTietDay = soTietDay;
        }
        public GIANGVIENTG() : base()
        {
            SoTietDay = 0;
        }
        public int Sotietday
        {
            get{  return this.SoTietDay; }
            set {SoTietDay=value  ;}
        }
        public override int TinhLuong()
        {
            int TinhLuong=SoTietDay+120000;
            return TinhLuong;   
        }
        public override void Nhap()
        {
            Console.WriteLine($"Mã Số Giảng Viên: {Maso}" +
                             $"\nHọ Tên Giảng Viên: {Hoten}" +
                             $"\nNăm Sinh: {Namsinh}" +
                             $"\nSố Tiết Dạy: {SoTietDay}" +
                             $"\nTính Lương: {TinhLuong()}");

        }
    }
}
