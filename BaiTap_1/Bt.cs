using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1
{
    class Bt
    {
        public static void Bt_a()
        {
            DateTime date = DateTime.Parse(Console.ReadLine()); ;
            //DateTime date = new DateTime(2024, 4, 20, 10, 30, 0); ;
            string strThu = "";
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    strThu = "thu hai";
                    break;
                case DayOfWeek.Tuesday:
                    strThu = "thu ba";
                    break;
                case DayOfWeek.Wednesday:
                    strThu = "thu tu";
                    break;
                case DayOfWeek.Thursday:
                    strThu = "thu nam";
                    break;
                case DayOfWeek.Friday:
                    strThu = "thu sau";
                    break;
                case DayOfWeek.Saturday:
                    strThu = "thu bay";
                    break;
                case DayOfWeek.Sunday:
                    strThu = "chu nhat";
                    break;
            }

            string strThang = "";
            switch (date.Month)
            {
                case 1:
                    strThang = "thang mot";
                    break;
                case 2:
                    strThang = "thang hai";
                    break;
                case 3:
                    strThang = "thang ba";
                    break;
                case 4:
                    strThang = "thang tu";
                    break;
                case 5:
                    strThang = "thang nam";
                    break;
                case 6:
                    strThang = "thang sau";
                    break;
                case 7:
                    strThang = "thang bay";
                    break;
                case 8:
                    strThang = "thang tam";
                    break;
                case 9:
                    strThang = "thang chin";
                    break;
                case 10:
                    strThang = "thang muoi";
                    break;
                case 11:
                    strThang = "thang muoi mot";
                    break;
                case 12:
                    strThang = "thang muoi hai";
                    break;
            }

            Console.WriteLine(strThu + ", " + date.Day + ", " + strThang + ", " + date.Year);
        }

        public static void Bt_b()
        {
            Console.WriteLine("Nhap dong ma tran 1:");
            int dong1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cot ma tran 1:");
            int cot1 = int.Parse(Console.ReadLine());
            int[,] mt1 = new int[dong1, cot1];

            for (int i = 0; i < dong1; i++)
            {
                for (int j = 0; j < cot1; j++)
                {
                    Console.WriteLine("Nhap phan tu [" + (i + 1) + "," + (j + 1) + "]:");
                    mt1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Nhap dong ma tran 2:");
            int dong2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cot ma tran 2:");
            int cot2 = int.Parse(Console.ReadLine());
            int[,] mt2 = new int[dong2, cot2];

            for (int i = 0; i < dong2; i++)
            {
                for (int j = 0; j < cot2; j++)
                {
                    Console.WriteLine("Nhap phan tu [" + (i+1)  + "," + (j+1) + "]:");
                    mt2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ma Tran thu nhat");
            for (int i = 0; i < dong1; i++)
            {
                for (int j = 0; j < cot1; j++)
                {
                    Console.Write(mt1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ma Tran thu hai");
            for (int i = 0; i < dong2; i++)
            {
                for (int j = 0; j < cot2; j++)
                {
                    Console.Write(mt2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ket qua nhan ma tran");

            if(cot1 == dong2)
            {
                int[,] mtkq = new int[dong2, cot1];
                int sum = 0;

                for (int i = 0; i < dong1; i++)
                    for (int j = 0; j < cot2; j++)
                        mtkq[i, j] = 0;

                for (int i = 0; i < dong1; i++)
                {
                    for (int j = 0; j < cot2; j++)
                    {
                        sum = 0;
                        for(int k = 0; k < cot1; k++)
                            sum = sum + mt1[i, k] * mt2[k, j];
                        mtkq[i, j] = sum;
                    }    
                }

                for (int i = 0; i < dong1; i++)
                {
                    for (int j = 0; j < cot2; j++)
                    {
                        Console.Write(mtkq[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Khong the nhan");
            }

        }

        public static void Bt_c()
        {
            ListSinhVien listSV = new ListSinhVien();
            Console.WriteLine("Nhap so luong SV:");
            listSV.Max = Int32.Parse(Console.ReadLine());
            listSV.readList();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Truoc khi sap xep");
            listSV.printList();
            listSV.sort();
            Console.WriteLine("Sau khi sap xep");
            listSV.printList();
        }
        static void Main(string[] args)
        {
            //Bt_a();
            //Bt_b();
            Bt_c();
        }
    }
}