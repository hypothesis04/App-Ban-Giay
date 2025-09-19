using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_Giày.Views
{
    public partial class frmInHoaDon : Form
    {
        public string SanPham
        {
            get { return lbSanPham.Text; }
            set { lbSanPham.Text = value; }
        }
        public string SL
        {
            get { return lbSL.Text; }
            set { lbSL.Text = value; }
        }
        public string DonGia
        {
            get { return lbDonGia.Text; }
            set { lbDonGia.Text = value; }
        }
        public string Tong
        {
            get { return lbTong.Text; }
            set { lbTong.Text = value; }
        }  public string TongTien
        {
            get { return lbtongtienTT.Text; }
            set { lbtongtienTT.Text = value; }
        }
        public string SoDienThoai
        {
            get { return lbSDTTT.Text; }
            set { lbSDTTT.Text = value; }
        }
        public string MaHD
        {
            get { return lbMahdTT.Text; }
            set { lbMahdTT.Text = value; }
        }
        public string TenKH
        {
            get { return lbTenkhTT.Text; }
            set { lbTenkhTT.Text = value; }
        }

        public string NgayBan
        {
            get { return lbNgayBanTT.Text; }
            set { lbNgayBanTT.Text = value; }
        }

        public string DiaChi
        {
            get { return lbDiaChiTT.Text; }
            set { lbDiaChiTT.Text = value; }
        }

        public frmInHoaDon()
        {
            InitializeComponent();
        }
        private void printHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FormBorderStyle originalBorderStyle = this.FormBorderStyle;
            FormWindowState originalWindowState = this.WindowState;

            try
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.Refresh();
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                float scale = Math.Min((float)e.MarginBounds.Width / bmp.Width, (float)e.MarginBounds.Height / bmp.Height);
                e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top, bmp.Width * scale, bmp.Height * scale);
                e.HasMorePages = false;
            }
            finally
            {

                this.FormBorderStyle = originalBorderStyle;
                this.WindowState = originalWindowState;
                this.Refresh();
            }
        }

        private void frmInHoaDon_Shown(object sender, EventArgs e)
        {
            PrintDialog InHoaDon = new PrintDialog();
            InHoaDon.Document = printHoaDon;
            {
                InHoaDon.Document = printHoaDon;

                if (InHoaDon.ShowDialog() == DialogResult.OK)
                {
                    printHoaDon.Print();
                    this.Close();
                }
            }
        }
    }
}
