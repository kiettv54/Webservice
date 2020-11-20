using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    Xuly.ServiceSoapClient ws = new Xuly.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnA_Click(object sender, EventArgs e)
    {
        int a = int.Parse(txtA.Text);
        int b = int.Parse(txtB.Text);
        int c = int.Parse(txtC.Text);
        int d = int.Parse(txtD.Text);
        int ee = int.Parse(txtE.Text);
        var result = ws.CauA(a, b, c, d, ee);
        txtketqua.Text = "Max:" + result[0] + ", Min:" + result[1] + ", Sum:" + result[2] + ", Average:" + result[3];

    }

    protected void btnB_Click(object sender, EventArgs e)
    {
        int a = int.Parse(txtA.Text);
        int b = int.Parse(txtB.Text);
        int c = int.Parse(txtC.Text);
        int d = int.Parse(txtD.Text);
        int ee = int.Parse(txtE.Text);
        var arraychan = ws.CauBSoChan(a, b, c, d, ee);
        var chans = ws.CauBSoChan(a, b, c, d, ee).Trim().Split();
        var les = ws.CauBSoLe(a, b, c, d, ee).Trim().Split();
        var arrayle = ws.CauBSoLe(a, b, c, d, ee);
        int tongchan = 0;
        int tongle = 0;
        foreach (var i in chans)
        {
            tongchan += Convert.ToInt32(i);
        }
        foreach (var i in les)
        {
            tongle += Convert.ToInt32(i);

        }
        txtketqua.Text = "<br> Các số chẵn:" + arraychan + "<br> Tổng chẵn:" + tongchan + "<br> Các số lẻ:" + arrayle + "<br> Tổng lẻ: " + tongle;
    }

    protected void btnC_Click(object sender, EventArgs e)
    {
        int a = int.Parse(txtA.Text);
        int b = int.Parse(txtB.Text);
        int c = int.Parse(txtC.Text);
        int d = int.Parse(txtD.Text);
        int ee = int.Parse(txtE.Text);
        List<int> snt = ws.SNT(a, b, c, d, ee);
        if (snt.Count == 0)
        {
            txtketqua.Text = "Không tồn tại số nguyên tố";
        }
        else
        {
            string k = "";
            foreach (int i in snt)
            {
                k += i + "  ";
            }
            txtketqua.Text = "Các số nguyên tố là:" + k;
        }
    }
}