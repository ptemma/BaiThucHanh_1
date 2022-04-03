using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1
{
    internal class ListSinhVien
    {
        private int max;
        private SinhVien[] lstSV;

        public ListSinhVien()
        {
        }

        public ListSinhVien(int max, SinhVien[] lstsv)
        {
            this.max = max;
            this.lstSV = lstsv;
        }

        public int Max { get => max; set => max = value; }
        internal SinhVien[] LstSV { get => lstSV; set => lstSV = value; }

        public void readList()
        {
            lstSV = new SinhVien[max];
            for (int i = 0; i < max; i++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine("Nhap MSSV cua sinh vien thu " + (i+1));
                sv.Mssv = Console.ReadLine();
                Console.WriteLine("Nhap Ho cua sinh vien thu " + (i + 1));
                sv.Ho = Console.ReadLine();
                Console.WriteLine("Nhap Ten cua sinh vien thu " + (i + 1));
                sv.Ten = Console.ReadLine();
                Console.WriteLine("Nhap Ngay Sinh cua sinh vien thu " + (i + 1));
                sv.Ngaysinh = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Ma Lop cua sinh vien thu " + (i + 1));
                sv.Malop = Console.ReadLine();
                lstSV[i] = sv;
            }
        }

        public void sort()
        {
            SinhVien temp;
            for (int i = 0; i < max; i++)
            {
                for(int j = i + 1; j < max; j++)
                {
                    if (lstSV[i].Ngaysinh > lstSV[j].Ngaysinh)
                    {
                        temp = lstSV[i];
                        lstSV[i] = lstSV[j];
                        lstSV[j] = temp;
                    }
                }
            }
        }

        public void printList()
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " +lstSV[i].Mssv + " - " +
                    lstSV[i].Ho + " " + lstSV[i].Ten + " - " +
                    lstSV[i].Ngaysinh.ToString("dd/MM/yyyy") + " - " + lstSV[i].Malop);
            }
        }
    }
}
