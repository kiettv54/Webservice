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
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public ArrayList CauA(int a,int b,int c,int d,int e)
    {
        List<int> list = new List<int> { a, b, c, d, e };
        ArrayList array = new ArrayList();
        array.Add(list.Max());
        array.Add(list.Min());
        array.Add(list.Sum());
        array.Add(list.Average());
        return array;
    }
    [WebMethod]
    public string CauBSoChan(int a,int b,int c,int d,int e)
    {
        int[] array = new int[] { a, b, c, d, e };
        string chans = "";
        foreach(int i in array)
        {
            if(i%2==0)
             chans += i + " ";
        }
        return chans;
    }
    [WebMethod]
    public string CauBSoLe(int a, int b, int c, int d, int e)
    {
        int[] array = new int[] { a, b, c, d, e };
        string les = "";
        foreach (int i in array)
        {
            if(i %2!=0)
            les += i + " ";
        }
        return les;
    }
    [WebMethod]
    public List<int> SNT(int a, int b, int c, int d, int e)
    {
        int[] array = new int[] { a, b, c, d, e };
    List<int> snt = new List<int>();
        foreach (int i in array)
        {
            if (Kiemtra(i) == true)
            {
                snt.Add(i);
            }
        }
        return snt;
    }
    bool Kiemtra(int k)
    {
        if (k < 2) return false;
        else
        {
            for(int i=2;i<=Math.Sqrt(k);i++)
            {
                if (k % i == 0) return false;
            }
        }
        return true;
    }

}