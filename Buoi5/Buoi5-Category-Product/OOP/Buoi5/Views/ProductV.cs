using Buoi5.Models;
using Buoi5.Services;
using Buoi51.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.Views
{
    public partial class ProductV : Form
    {
        ClassT<Product> proA = new ClassT<Product>();
        Product currentPro = null;
        int idx = -1;
        readonly FileFactory<Product> fileFactory = new FileFactory<Product>();
        public ProductV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Ma = int.Parse(txtMa.Text);
            pro.Ten = txtTen.Text;
            pro.Gia = double.Parse(txtGia.Text);
            pro.Handung = dtpHanDung.Value;
            pro.Danhmuc = cmbDanhMuc.Text;
            proA.Add(pro);
            dgvSanPham.DataSource = proA.A.ToList();
            resetForm();
        }
        private void resetForm()
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGia.Text = string.Empty;

        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            CategoryV categoryV = new CategoryV();
            if (categoryV.ShowDialog() == DialogResult.OK)
            {
                danhmuc();
            }
        }
        private void danhmuc()
        {
            cmbDanhMuc.Items.Clear();
            foreach (Category item in Product.cates.A)
            {
                try
                {
                    cmbDanhMuc.Items.Add(item);
                }
                catch
                {
                    MessageBox.Show("Chua nhap danh muc");
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idx = (int)e.RowIndex;
                currentPro = (Product)dgvSanPham.Rows[e.RowIndex].DataBoundItem;
                txtMa.Text = currentPro.Ma.ToString();
                txtTen.Text = currentPro.Ten.ToString();
                txtGia.Text = currentPro.Gia.ToString();
                dtpHanDung.Text = currentPro.Handung.ToString();
                cmbDanhMuc.Text = currentPro.Danhmuc.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            currentPro.Ma = int.Parse(txtMa.Text);
            currentPro.Ten = txtTen.Text;
            currentPro.Gia = double.Parse(txtGia.Text);
            currentPro.Handung = dtpHanDung.Value;
            currentPro.Danhmuc = cmbDanhMuc.Text;
            dgvSanPham.DataSource = proA.A.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            proA.RemoveAt(idx);
            dgvSanPham.DataSource = proA.A.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool Ghi(ClassT<Product> products, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (Product p in products.A)
                {
                    string line = p.Ma + ";" + p.Ten + ";" + p.Gia + ";" + p.Handung + ";" + p.Danhmuc;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\product.txt";
            bool result = Ghi(proA, path);
            if (result)
            {
                MessageBox.Show("Luu thanh cong");
            }
        }
        private ClassT<Product> Doc(string path)
        {
            ClassT<Product> dsp = new ClassT<Product>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null) break;
                    string[] arr = line.Split(';');
                    if (arr.Length == 5)
                    {
                        Product p = new Product();
                        p.Ma = int.Parse(arr[0]);
                        p.Ten = arr[1];
                        p.Gia = double.Parse(arr[2]);
                        p.Handung = DateTime.Parse(arr[3]);
                        p.Danhmuc = arr[4];
                        dsp.Add(p);
                    }
                }
                sr.Close();
            }
            catch (Exception ex) { throw ex; }
            return dsp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\product.txt";
            if (System.IO.File.Exists(path))
            {
                proA = Doc(path);
                dgvSanPham.DataSource = proA.A.ToList();
            }
            else
            {
                MessageBox.Show("Khong doc duoc file");
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proA.RemoveAt(idx);
            dgvSanPham.DataSource = proA.A.ToList();
            resetForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
