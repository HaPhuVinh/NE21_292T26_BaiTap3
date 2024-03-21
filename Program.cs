using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_292T26_BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;

            //Bài 1:
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n % 3 == 0) Console.WriteLine("Số bạn nhập chia hết cho 3.");
            //else Console.WriteLine("Số bạn nhập không chia hết cho 3.");

            //string s = n % 3 == 0 ? "Số bạn nhập chia hết cho 3." : "Số bạn nhập không chia hết cho 3.";
            //Console.Write(s);

            //Bài 2:
            //Console.WriteLine("CHƯƠNG TRÌNH HIỂN THỊ BẢNG CỬU CHƯƠNG TỪ 1 ĐẾN N");
            //Console.Write("Nhập vào số nguyên dương n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int j = 1; j <= 9; j++)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.Write("{0} x {1} = {2}   ",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}

            //Bài 3:
            //Console.Write("nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //int tongGT = 1;
            //for (int i = 1; i <= n ; i++)
            //{
            //    tongGT = tongGT * i;
            //}
            //Console.WriteLine("{0}! = {1}", n, tongGT);

            //Bài 4:
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //string kq = "";
            //for (int i = 0; i < n; i++)
            //{
            //    if (i * i >= n)
            //    {
            //        kq = i * i == n ? "là số chính phương" : "không là số chính phương";
            //        break;
            //    }
            //}
            //Console.WriteLine(n + " " + kq);

            //Bài 5:
            //Console.Write("Nhập vào tháng bạn muốn xem số ngày (MM): ");
            //int MM = int.Parse(Console.ReadLine());
            //Console.Write("Nhập vào năm bạn muốn xem số ngày (yyyy): ");
            //int yyyy = int.Parse(Console.ReadLine());
            //int soNgayTrongThang = DateTime.DaysInMonth(yyyy, MM);
            //Console.WriteLine("Tháng {0} năm {1} có {2} ngày.",MM,yyyy, soNgayTrongThang);

            //Bài 6:
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //double tongS = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    tongS = tongS + Math.Pow(i,i);
            //}
            //Console.WriteLine("Tổng S = " + tongS);

            //Bài 7:
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = int.Parse(Console.ReadLine());
            //double tongSoLe = 0;
            //for (int i = 1; i <= n; i+=2)
            //{
            //    tongSoLe = tongSoLe + i;
            //}
            //Console.WriteLine("Tổng số lẻ từ 1 đến {0} = {1}", n, tongSoLe);

            //Bài 8:
            //Console.Write("Nhập vào số nguyên dương n: ");
            //int n = int.Parse(Console.ReadLine());
            //bool laNguyenTo = true;
            //if (n == 0 || n == 1)
            //{
            //    Console.WriteLine("Không có số nguyên tố:");
            //}
            //else
            //{
            //    Console.WriteLine("Từ 1 đến {0} có những số nguyên tố sau:", n);
            //    for (int i = 2; i <= n; i++)
            //    {
            //        laNguyenTo = true;
            //        for (int j = 2; j <= i / 2; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                laNguyenTo = false;
            //                break;
            //            }
            //        }
            //        if (laNguyenTo)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            //Bài 9
            //Console.Write("Nhập vào số nguyên dương n:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Vẽ tam giác vuông: ");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("Vẽ tam giác cân: ");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 2*i-1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //Bài 10
            Console.Write("Nhập vào số nguyên dương lớn hơn 2:\n");
            int n = int.Parse(Console.ReadLine());
            double soKeTiep;
            double so1=0;
            double so2=1;
            Console.WriteLine("Dãy Fibonacci {0} phần tử:", n);
            Console.Write(so1 + "\t");
            Console.Write(so2 + "\t");
            for (int i = 3; i <= n; i++)
            {
                soKeTiep = so1 + so2;
                Console.Write(soKeTiep + "\t");
                so1 = so2;
                so2 = soKeTiep;
            }

            Console.ReadKey();
        }
    }
}
