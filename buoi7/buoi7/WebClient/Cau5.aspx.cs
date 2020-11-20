using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau5 : System.Web.UI.Page
{
    QLSVService.ServiceSoapClient ws = new QLSVService.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var data = ws.GetSinhVienBySisoOrGT(30,"Nam");
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}