using System;
using System.Windows.Forms;

namespace ExerciseSiter6
{
    public partial class Form1 : Form
    {
        ServiceReferencePelangi.Service1Client srPelangi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNorut.Text))
            {
                MessageBox.Show("Peringatan", "Mohon untuk Nomor Urut diisi angka");
            }

            var warna = srPelangi.GetPelangi(int.Parse(tbNorut.Text));
            tbWarna.Text = warna.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srPelangi = new ServiceReferencePelangi.Service1Client();
        }

        private void tbNorut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
