using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, tongchan = 0, tongle = 0,chon;
            Xuly.ServiceSoapClient ws = new Xuly.ServiceSoapClient();
            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap d:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap e:");
            e = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("***************MAIN MENU**********");
                Console.WriteLine("*******BAI TAP BUOI 1********");
                Console.WriteLine("0.   THOAT");
                Console.WriteLine("1.   CAU A");
                Console.WriteLine("2.   CAU B");
                Console.WriteLine("3.   CAU C");
                Console.WriteLine("4.   Nhap lai du lieu");

                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        var result = ws.CauA(a, b, c, d, e);
                        Console.WriteLine("Max:" + result[0] + ", Min:" + result[1] + ", Sum:" + result[2] + ", Average:" + result[3]);
                        break;
                    case 2:
                        var arraychan = ws.CauBSoChan(a, b, c, d, e);
                        var chans = ws.CauBSoChan(a, b, c, d, e).Trim().Split();
                        var les = ws.CauBSoLe(a, b, c, d, e).Trim().Split();
                        var arrayle = ws.CauBSoLe(a, b, c, d, e);
                       
                        foreach (var i in chans)
                        {
                            tongchan += Convert.ToInt32(i);
                        }
                        foreach (var i in les)
                        {
                            tongle += Convert.ToInt32(i);

                        }
                        Console.WriteLine("Cac so chan:" + arraychan + "\n Tong chan:" + tongchan + "\n Cac so le:" + arrayle + "\n Tong le: " + tongle);
                        break;
                    case 3:
                        List<int> snt = ws.SNT(a, b, c, d, e);
                        if (snt.Count == 0)
                        {
                            Console.WriteLine("Khong ton tai so nguyen to");
                        }
                        else
                        {
                            string k = "";
                            foreach (int i in snt)
                            {
                                k += i + "  ";
                            }
                            Console.WriteLine("Cac so nguyen to la:" + k);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap a:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap b:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap c:");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap d:");
                        d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap e:");
                        e = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("khong co lua chon nay.Vui long nhap lai!");
                        break;   
                }
            } while (chon != 0);

            Console.ReadLine();
        }
    }
}
