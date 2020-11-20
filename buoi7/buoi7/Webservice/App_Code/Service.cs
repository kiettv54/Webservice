using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    private QLSVDataContext db = new QLSVDataContext();
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public List<SinhVienLop> GetSinhVienInfo()
    {
        var result = from sv in db.SinhViens
                     from l in db.Lops
                     where sv.MaLop == l.MaLop
                     select new SinhVienLop
                     {
                         HoTen = sv.HoTen,
                         TenLop = l.TenLop,
                     };
        return result.ToList<SinhVienLop>();
    }
  
  
    [WebMethod]
    public List<SinhVienByGT> GetSinhVienByGT(string gioitinh)
    {
        var result = from sv in db.SinhViens
                     from l in db.Lops
                     where sv.MaLop == l.MaLop && sv.GioiTinh == gioitinh
                     select new  SinhVienByGT
                     {
                         Hoten = sv.HoTen,
                         TenLop = l.TenLop,
                         Siso =(int) l.Siso,
                         DiaChi = sv.Diachi
                     };
        return result.ToList<SinhVienByGT>();
    }
    [WebMethod]
    public List<SinhvienSortedBySiso> GetSinhVienBySiso(int siso)
    {
        var result = from sv in db.SinhViens
                     from l in db.Lops
                     where sv.MaLop == l.MaLop && l.Siso > siso
                     select new SinhvienSortedBySiso
                     {
                         MaSV = sv.MaSV,
                         HoTen = sv.HoTen,
                         GioiTinh = sv.GioiTinh
                     };
        return result.ToList<SinhvienSortedBySiso>();
    }
    [WebMethod]
    public List<SinhVienLop2> GetSinhVienBySisoAndTinh(int siso,string tinh)
    {
        var result = from sv in db.SinhViens
                     from l in db.Lops
                     where sv.MaLop == l.MaLop && l.Siso < siso && sv.Diachi == tinh
                     select new SinhVienLop2
                     {
                         MaSV = sv.MaSV,
                         Hoten = sv.HoTen,
                         MaLop = l.MaLop,
                         TenLop = l.TenLop

                     };
        return result.ToList<SinhVienLop2>();
    }
    [WebMethod]
    public List<SinhVienLop2> GetSinhVienBySisoOrGT(int siso, string gioitinh)
    {
        var result = from sv in db.SinhViens
                     from l in db.Lops
                     where sv.MaLop == l.MaLop && (l.Siso < siso  || sv.GioiTinh == gioitinh)
                     
                     select new SinhVienLop2
                     {
                         MaSV = sv.MaSV,
                         Hoten = sv.HoTen,
                         MaLop = l.MaLop,
                         TenLop = l.TenLop

                     };
        var data = result.Distinct();
        return data.ToList<SinhVienLop2>();
    }
    [WebMethod]
    public List<Lop> SortedLopBySiso()
    {
        var result = from l in db.Lops
                     orderby l.Siso ascending
                     select  l;
        return result.ToList<Lop>();
    }
    [WebMethod]
    public List<SinhVien> SortedSinhVienByNameAndGT()
    {
        var result = from sv in db.SinhViens
                     where sv.GioiTinh == "Nam"
                     orderby sv.HoTen ascending
                     select sv;
        return result.ToList<SinhVien>();
    }


}