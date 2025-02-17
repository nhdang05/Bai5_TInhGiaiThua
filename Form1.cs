using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_TInhGiaiThua

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtso.Text);
            int gt = 1;
            for (int i = 1; i <= so; i++)
            {
                gt *= i;
            }
            lblKQ.Text = "Kết quả:" + gt.ToString();
        }
        private void txtso_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(lblso.Text);
            int gt = 1;
            for (int i = 1; i <= so; i++)
            {
                gt *= i;
            }
            lblKQ.Text = "kết quả:" + gt.ToString();
        }
        private void trbTinhTB_Scroll(object sender, EventArgs e)
        {
            txtso.Text = trbTinhGT.Value.ToString();
            int so = Convert.ToInt32(txtso.Text);
            int gt = 1;
            for (int i = 1; i <= so; i++)
            {
                gt *= i;
            }
            lblKQ.Text = "kết quả:" + gt.ToString();
        }
        private void txtso_TextChanged(object sender, EventArgs e)
        {
        }
        private void lblKQ_Click(object sender, EventArgs e)
        {
        }
    }
}