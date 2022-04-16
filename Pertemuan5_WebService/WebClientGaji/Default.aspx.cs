using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHitung_Click(object sender, EventArgs e)
    {
        SRGaji.Service1Client obj = new SRGaji.Service1Client();
        double total = obj.Gaji(
            Convert.ToInt32(txtGapok.Text),
            Convert.ToInt32(txtTunjangan.Text),
            Convert.ToInt32(txtPotongan.Text),
            Convert.ToDouble(txtPph.Text));
        lblTotal.Text = "Rp. " + total.ToString();
    }
}