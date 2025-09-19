using Bán_Giày.Views;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_Giày
{
    public partial class frmTrangChinh : Form
    {
        private IconButton currentBtn;
        private Panel BtnChuyenTrang;
        private Form FormCon;
        public frmTrangChinh()
        {
            InitializeComponent();
            BtnChuyenTrang = new Panel();
            BtnChuyenTrang.Size = new Size(7, 60);
            panelMenu.Controls.Add(BtnChuyenTrang);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBcolors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(146, 185, 227);
        }

        private void ActiveButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                BtnChuyenTrang.BackColor = color;
                BtnChuyenTrang.Location = new Point(0, currentBtn.Location.Y);
                BtnChuyenTrang.Visible = true;
                BtnChuyenTrang.BringToFront();          
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }



        private void Moformcon(Form childForm)
        {
            if (FormCon != null)
            {
                FormCon.Close();
            }
            FormCon = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            if (FormCon != null)
            {
                FormCon.Close();
                lbTieuDe.Text = "Trang chủ";
            }
        }

        private void btnDSGiay_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            Moformcon(new frmDSGiay());
            iconTieuDe.IconChar = btnDSGiay.IconChar;
            lbTieuDe.Text = "Danh Sách Giày";
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            Moformcon(new frmDSKhachHang());
            iconTieuDe.IconChar = btnDSKH.IconChar;
            lbTieuDe.Text = "Danh Sách Khách Hàng";
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            Moformcon(new frmDSHoaDon());
            lbTieuDe.Text = "Danh Sách Hoá Đơn";
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            Moformcon(new frmThongKe());
            iconTieuDe.IconChar = btnThongKe.IconChar;
            lbTieuDe.Text = "Thống Kê";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            DialogResult KetQua = MessageBox.Show("Xác Nhận Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KetQua == DialogResult.Yes)
                this.Close();
        }

        private void picBLogo_Click(object sender, EventArgs e)
        {
            if (FormCon != null)
            {
                FormCon.Close();
                iconTieuDe.IconChar = btnTrangChu.IconChar;
                lbTieuDe.Text = "Trang chủ";
            }
        }
       
        private void btnThuNho_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPhongTo_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void frmTrangChinh_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
