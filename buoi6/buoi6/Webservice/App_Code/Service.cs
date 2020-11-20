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
    public List<SinhVien> SinhVienInfo()
    {
        var result = from sv in db.SinhViens select sv;
        return result.ToList<SinhVien>();

    }
    [WebMethod]
    public List<Lop> LopInfo()
    {
        var result = from l in db.Lops select l;
        return result.ToList<Lop>();
    }
    [WebMethod]
    public List<SinhVien> SinhVienTinh(string diachi)
    {
        var result = from sv in db.SinhViens where sv.Diachi == diachi select sv;
        return result.ToList<SinhVien>();
    }
    [WebMethod]
    public List<SinhVien> SinhVienGTvaTinh(string gioitinh, string diachi)
    {
        var result = from sv in db.SinhViens
                     where sv.Diachi == diachi && sv.GioiTinh == gioitinh
                     select sv;
        return result.ToList<SinhVien>();
    }
    [WebMethod]
    public List<Lops> HienThiLopSiso(int siso)
    {
        var result = from l in db.Lops
                     where l.Siso > siso
                     select new Lops
                     {
                         TenLop = l.TenLop,
                         Siso = l.Siso
                     };
        return result.ToList<Lops>();
    }

}