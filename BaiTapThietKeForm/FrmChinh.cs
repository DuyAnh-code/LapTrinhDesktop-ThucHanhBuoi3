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
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

		private void tsmiBai1_Click(object sender, EventArgs e)
		{
            var form=new FrmBai1();
			form.ShowDialog();

        }

		private void tsmiBai2_Click(object sender, EventArgs e)
		{
			var form = new FrmBai2();
			form.ShowDialog();
		}
	}
}
