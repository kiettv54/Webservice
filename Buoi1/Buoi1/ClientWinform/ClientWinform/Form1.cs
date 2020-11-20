using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientWinform
{
    public partial class Form1 : Form
    {
        Xuly.ServiceSoapClient ws = new Xuly.ServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            int d = int.Parse(txtD.Text);
            int ee = int.Parse(txtE.Text);
            var result = ws.CauA(a, b, c, d, ee);
            txtketqua.Text = "Max:" + result[0] + ", Min:" + result[1] + ", Sum:" + result[2] + ", Average:" + result[3];

        }

        private void btnB_Click(object sender, EventArgs e)
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
            txtketqua.Text = "Các số chẵn:" + arraychan + "\n Tổng chẵn:" + tongchan + "\n Các số lẻ:" + arrayle + "\n Tổng lẻ: " + tongle;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            int d = int.Parse(txtD.Text);
            int ee = int.Parse(txtE.Text);
            List<int> snt = ws.SNT(a, b, c, d, ee);
            if(snt.Count == 0)
            {
                txtketqua.Text = "Không tồn tại số nguyên tố";
            }
            else
            {
                string k = "";
                foreach(int i in snt)
                {
                    k += i + "  ";
                }
                txtketqua.Text = "Các số nguyên tố là:" + k;
            }
        }
    }
}
