using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class GIANGVIEN
    {
        private string MaSo;
        private string HoTen;
        private int NamSinh;
        public GIANGVIEN(string MaSo, string HoTen, int NamSinh)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
        }
        public GIANGVIEN()
        {
            MaSo = "";
            HoTen = "";
            NamSinh =0;
        }
        public string Maso
        {
            get { return MaSo; }
            set { MaSo = value; }
        }
        public string Hoten
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public int Namsinh
        {
            get { return NamSinh; }
            set { NamSinh = value; }
        }
        abstract public int TinhLuong();
        abstract public void Nhap();
        
    }
}
