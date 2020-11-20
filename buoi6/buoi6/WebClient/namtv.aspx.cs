using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class namtv : System.Web.UI.Page
{
    QLSV.ServiceSoapClient ws = new QLSV.ServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var data = ws.SinhVienGTvaTinh("Nam", "Trà Vinh");
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}