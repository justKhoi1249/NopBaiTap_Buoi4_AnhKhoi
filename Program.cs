using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopBaiTap_Buoi4_AnhKhoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------BAI TAP BUOI 4---------------------------------------*/
            //-----------------------------------------BÀI 13---------------------------------------
            //VIẾT HÀM ĐỂ TÌM GIÁ TRỊ LỚN NHẤT TRONG MỘT MẢNG
            //SỬ DỤNG THAM CHIẾU.HÀM SẼ TRẢ VỀ THAM CHIẾU TỚI PHẦN TỬ LỚN NHẤT.
            /*
            static void Main(string[] args)
            {
                int[] arrNum = { 13, 14, 21, 34, 5, 25 };
                Console.WriteLine("arrNum truoc khi goi ham tham chieu");
                HienThi(arrNum);
                ThamChieuMaxMang(ref arrNum);
                Console.ReadLine();
            }


            static void ThamChieuMaxMang(ref int[] arrNum)
            {
                arrNum.Max();
                Console.WriteLine("Max trong mang tham chieu ref la: {0} \n", arrNum.Max());

            }


            private static void HienThi(int[] arrNum)
            {
                foreach (var item in arrNum)
                {
                    Console.WriteLine(item + " ");
                }
                Console.WriteLine();
            }
            */


            //---------------------------------------BÀI 14--------------------------------------------
            //VIẾT MỘT HÀM SỬ DỤNG THAM CHIẾU KÉP ĐỂ HOÁN ĐỔI GIÁ TRỊ CỦA HAI BIẾN NGUYÊN.
            //CHƯƠNG TRÌNH CHÍNH SẼ GỌI HÀM NÀY VÀ IN KẾT QUẢ RA MÀN HÌNH.
            /*
            static void Main(string[] args)
            {
                int a = 2;
                int b = 4;
                Console.WriteLine("Truoc khi hoan doi gia tri thi a = {0} va b = {1} \n", a, b);
                HoanDoiGiaTri(ref a, b);
                Console.ReadLine();
            }

            static void HoanDoiGiaTri(ref int a, int b)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("Sau khi hoan doi gia tri thi a = {0} va b = {1}", a, b);
            }
            */

            //-----------------------------------------BÀI 15--------------------------------------
            //VIẾT MỘT CHƯƠNG TRÌNH SỬ DỤNG THAM CHIẾU KÉP
            //ĐỂ THAY ĐỔI GIÁ TRỊ CỦA MỘT PHẦN TỬ TRONG MẢNG THÔNG QUA MỘT HÀM.
            /*
            static void Main(string[] args)
            {
                int[] arrNum = { 13, 14, 21, 34, 5, 25 };
                Console.WriteLine("arrNum truoc khi goi ham tham chieu");
                HienThi(arrNum);
                ThayDoiGiaTriTrongMang(ref arrNum);
                Console.ReadLine();
            }


            static void ThayDoiGiaTriTrongMang(ref int[] arrNum)
            {   
                arrNum[2] = 100;
                Console.WriteLine("arrNum sau khi goi ham tham chieu ref la: {0} \n");
                HienThi(arrNum);

            }


            private static void HienThi(int[] arrNum)
            {
                foreach (var item in arrNum)
                {
                    Console.WriteLine(item + " ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}
