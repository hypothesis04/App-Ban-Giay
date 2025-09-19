using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_Giày.Views
{
    [Serializable]
    public partial class frmDSGiay : Form
    {
        private CXuLyGiay xulyGiay;
        private int viTri = -1;
        private IconButton currentBtn;
        private Panel BtnChuyenTrai;
        public frmDSGiay()
        {
            InitializeComponent();
            xulyGiay = new CXuLyGiay();
            BtnChuyenTrai = new Panel();
            BtnChuyenTrai.Size = new Size(7, 60);
            panelButtonGiay.Controls.Add(BtnChuyenTrai);
        }
        private void DisableButtonGiay()
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
        private struct RGBcolors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(146, 185, 227);
        }

        private void ActiveButtonGiay(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonGiay();
                currentBtn = (IconButton)senderBtn;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                BtnChuyenTrai.Location = new Point(0, currentBtn.Location.Y);
                BtnChuyenTrai.Visible = true;
                BtnChuyenTrai.BringToFront();

            }
        }
        private void frmDSGiay_Load(object sender, EventArgs e)
        {
           
            HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
            if (CTruyCapDuLieu.DocFileGiay("giay.json"))
            {
                xulyGiay = new CXuLyGiay();
                HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
            }
            txtMaGiay.Focus();
        }
        private bool CheckTextBox(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                toolTip1.Show(message, textBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(textBox);
                return false;
            }
        }
        private bool CheckComboBox(ComboBox comboBox, string message)
        {
            if (comboBox.SelectedIndex == -1)
            {
                toolTip1.Show(message, comboBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(comboBox);
                return false;
            }
        }
        private bool CheckTextBoxint(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                toolTip1.Show(message, textBox, 0, -20, 2000);
                return true;
            }
            else if (!int.TryParse(textBox.Text, out int quantity) || quantity <= 0)
            {
                toolTip1.Show("Hãy Nhập số nguyên và lớn hơn 0!", textBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(textBox);
                return false;
            }
        }
        private void HienThiDanhSachGiay(DataGridView dgv, List<Giay> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }
        private void resetNhap()
        {
            txtMaGiay.Text = "";
            txtSoLuong.Text = "";
            txtTenGiay.Text = "";
            cmbMau.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            cmbThuongHieu.SelectedIndex = -1;
        }
        private void btnDocFileGiay_Click(object sender, EventArgs e)
        {
            if (xulyGiay.getDanhSachGiay().Count > 0)
            {
                DialogResult result = MessageBox.Show("Danh sách đang có nội dung, đọc file sẽ ghi đè nội dung lên. Bạn có muốn đọc file!!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    if (CTruyCapDuLieu.DocFileGiay("giay.json"))
                    {
                        xulyGiay = new CXuLyGiay();
                        HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
                        MessageBox.Show("Đọc file thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                    }
                    ActiveButtonGiay(sender, RGBcolors.color1);
                }
                else { return; }
            }
            else
            {
                if (CTruyCapDuLieu.DocFileGiay("giay.json"))
                {
                    xulyGiay = new CXuLyGiay();
                    HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
                    MessageBox.Show("Đọc file thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                }
                ActiveButtonGiay(sender, RGBcolors.color1);
            }

        }
        private void luudulieu()
        {
            string filePathGiay = "giay.json";
            if (CTruyCapDuLieu.GhiFileGiay(filePathGiay))
            {
            }
        }
        private void btnGhiFileGiay_Click(object sender, EventArgs e)
        {
            string filePathGiay = "giay.json";

            if (File.Exists(filePathGiay))
            {
                DialogResult KetQua = MessageBox.Show("Dữ liệu hiện tại sẽ bị mất. Bạn có muốn ghi đè hàm đó không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (KetQua == DialogResult.No)
                    return;
            }
            if (CTruyCapDuLieu.GhiFileGiay(filePathGiay))
            {
                MessageBox.Show("Ghi file thành công.");
            }
            else
            {
                MessageBox.Show("Ghi file thất bại.");
            }
            ActiveButtonGiay(sender, RGBcolors.color1);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaGiay, "Bạn chưa nhập mã giày!")) return;
            if (CheckTextBox(txtTenGiay, "Bạn chưa nhập tên giày!")) return;
            if (CheckComboBox(cmbThuongHieu, "Bạn chưa chọn thương hiệu giày!")) return;
            if (CheckComboBox(cmbMau, "Bạn chưa chọn màu giày!")) return;
            if (CheckComboBox(cmbSize, "Bạn chưa chọn size giày!")) return;
            if (CheckTextBoxint(txtSoLuong, "Bạn chưa nhập số lượng giày!")) return;
            Giay giaymoi = new Giay(txtMaGiay.Text, txtTenGiay.Text, cmbThuongHieu.Text, cmbMau.Text, int.Parse(cmbSize.Text), int.Parse(txtSoLuong.Text), 0);
            if (xulyGiay.timGiay(giaymoi.MaGiay) == null)
            {
                xulyGiay.ThemGiay(giaymoi);
                HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
                ActiveButtonGiay(sender, RGBcolors.color1);
                luudulieu();
                resetNhap();
            }
            else
            {
                MessageBox.Show("Mã giày " + giaymoi.MaGiay + " đã tồn tại. Ko thêm được.");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaGiay, "Bạn chưa nhập mã giày!")) return;
            if (CheckTextBox(txtTenGiay, "Bạn chưa nhập tên giày!")) return;
            if (CheckComboBox(cmbThuongHieu, "Bạn chưa nhập thương hiệu giày!")) return;
            if (CheckComboBox(cmbMau, "Bạn chưa nhập màu giày!")) return;
            if (CheckComboBox(cmbSize, "Bạn chưa nhập size giày!")) return;
            if (CheckTextBoxint(txtSoLuong, "Bạn chưa nhập số lượng giày!")) return;
            Giay giay = new Giay(txtMaGiay.Text, txtTenGiay.Text, cmbThuongHieu.Text, cmbMau.Text, int.Parse(cmbSize.Text), int.Parse(txtSoLuong.Text), 0);
            if (xulyGiay.timGiay(txtMaGiay.Text) != null)
            {
                xulyGiay.SuaGiay(giay);
                HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
                ActiveButtonGiay(sender, RGBcolors.color1);
                luudulieu();
            }
            else
            {
                MessageBox.Show("Mã giày " + giay.MaGiay + " đã tồn tại. Ko thêm được.");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaGiay, "Hãy nhập mã giày!!!!")) return;
            string maGiay = txtMaGiay.Text;
            if (xulyGiay.timGiay(maGiay) != null)
            {
                xulyGiay.XoaGiay(maGiay);
                HienThiDanhSachGiay(dgvDanhsachGiay, xulyGiay.getDanhSachGiay());
                resetNhap();
                luudulieu();
                ActiveButtonGiay(sender, RGBcolors.color1);
            }
            else
            {
                MessageBox.Show("Không tồn tại mã giày " + maGiay + "  !!!", "Thông báo");
            }
        }
        private void dgvDanhsachGiay_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string maGiay = dgvDanhsachGiay.Rows[e.RowIndex].Cells[0].Value.ToString();
            Giay ketQuatim = xulyGiay.timGiay(maGiay);
            txtMaGiay.Text = ketQuatim.MaGiay;
            txtSoLuong.Text = ketQuatim.SoLuong.ToString();
            txtTenGiay.Text = ketQuatim.Ten;
            cmbMau.Text = ketQuatim.MauSac;
            cmbSize.Text = ketQuatim.Size.ToString();
            cmbThuongHieu.Text = ketQuatim.ThuongHieu;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
