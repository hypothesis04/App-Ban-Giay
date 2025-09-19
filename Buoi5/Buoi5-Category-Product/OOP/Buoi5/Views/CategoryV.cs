using Buoi5.Models;
using Buoi5.Services;

namespace Buoi5
{
    public partial class CategoryV : Form
    {
        ClassT<Category> cateA = new ClassT<Category>();
        public CategoryV()
        {
            InitializeComponent();
        }

        private void CategoryV_Load(object sender, EventArgs e)
        {
            txtMa.Focus();
            foreach (Category item in Product.cates.A)
            {
                if (item != null)
                {
                    lstDanhMuc.Items.Add(item);
                }
            }
        }

        private void resetForm()
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtMa.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.Ma = int.Parse(txtMa.Text);
            cate.Ten = txtTen.Text;
            cate.Ngay = dtpNgayTao.Value;
            cateA.Add(cate);
            Product.cates.Add(cate);
            lstDanhMuc.Items.Add(cate);
            resetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int idx = lstDanhMuc.SelectedIndex;
            cateA.RemoveAt(idx);
            lstDanhMuc.Items.RemoveAt(idx);
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                Category category = lstDanhMuc.SelectedItem as Category;
                txtMa.Text = category.Ma.ToString();
                txtTen.Text = category.Ten.ToString();
                dtpNgayTao.Text = category.Ngay.ToString();
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                Category cate = new Category();
                cate.Ma = int.Parse(txtMa.Text);
                cate.Ten = txtTen.Text;
                cate.Ngay = dtpNgayTao.Value;
                lstDanhMuc.Items[lstDanhMuc.SelectedIndex] = cate;
                Product.cates.A[lstDanhMuc.SelectedIndex] = cate;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
