using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClientSuhu
{
    public partial class Form1 : Form
    {
        SRSuhu.Service1Client srSuhu;
        double CtoR, CtoF, CtoK;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srSuhu = new SRSuhu.Service1Client();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            CtoR = srSuhu.CelciusToReamur(int.Parse(tbCelcius.Text));
            CtoF = srSuhu.CelciusToFahrenheit(int.Parse(tbCelcius.Text));
            CtoK = srSuhu.CelciusToKelvin(int.Parse(tbCelcius.Text));

            tbReamur.Text = CtoR.ToString() + " R";
            tbFahrenheit.Text = CtoF.ToString() + " F";
            tbKelvin.Text = CtoK.ToString() + " K";
        }
    }
}
