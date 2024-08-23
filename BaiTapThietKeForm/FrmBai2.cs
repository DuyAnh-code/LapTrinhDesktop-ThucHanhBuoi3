using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaiTapThietKeForm
{
	public partial class FrmBai2 : Form
	{
		public FrmBai2()
		{
			InitializeComponent();
		}

		private void btnChonHang_Click(object sender, EventArgs e)
		{
			var item = listBox1.SelectedItem;
			listBox2.Items.Add(item);
		}

		private void btnBoHang_Click(object sender, EventArgs e)
		{
			listBox2.Items.Remove(listBox2.SelectedItem);
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int soTien = 0;
			foreach (string hang in listBox2.Items)
			{
				switch (hang)
				{
					case "Chuột":
						soTien += 100000;
						break;
					case "Bàn Phím":
						soTien += 120000;
						break;
					case "Máy in":
						soTien += 1000000;
						break;
					case "USB KingMax":
						soTien += 150000;
						break;
					case "PC":
						soTien += 2000000;
						break;
					case "Laptop":
						soTien += 1800000;
						break;
					case "Màn Hình":
						soTien += 50000;
						break;
					default:
					break;
				}
				lbSoTien.Text = soTien + " đồng";
			}
		}
	}
}
