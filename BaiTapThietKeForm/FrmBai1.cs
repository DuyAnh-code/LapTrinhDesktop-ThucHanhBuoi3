using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "300000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "400000";
        }

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "450000";
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
            int soTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lbSoTien.Text=soTien.ToString();

		}
	}
}
