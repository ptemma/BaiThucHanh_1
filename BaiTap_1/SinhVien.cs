using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1
{
    internal class SinhVien
    {
        private string mssv;
        private string ho;
        private string ten;
        private DateTime ngaysinh;
        private string malop;

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string ho, string ten, DateTime ngaysinh, string malop)
        {
            this.mssv = mssv;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.malop = malop;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
