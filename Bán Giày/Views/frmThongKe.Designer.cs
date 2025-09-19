namespace Bán_Giày.Views
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartHangBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHangYeuThichNhat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoLuongConLai = new System.Windows.Forms.Label();
            this.lblNguonCung = new System.Windows.Forms.Label();
            this.lblSoLuongBanRa = new System.Windows.Forms.Label();
            this.lblSoLuongMatHang = new System.Windows.Forms.Label();
            this.chartTongDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblSoLuongDonHang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblSoLuongKhachHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHangBanChay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartHangBanChay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(978, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 907);
            this.panel1.TabIndex = 11;
            // 
            // chartHangBanChay
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.chartHangBanChay.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartHangBanChay.Legends.Add(legend1);
            this.chartHangBanChay.Location = new System.Drawing.Point(8, 158);
            this.chartHangBanChay.Name = "chartHangBanChay";
            this.chartHangBanChay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartHangBanChay.Series.Add(series1);
            this.chartHangBanChay.Size = new System.Drawing.Size(475, 737);
            this.chartHangBanChay.TabIndex = 17;
            this.chartHangBanChay.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Hãng Bán Chạy Nhất";
            this.chartHangBanChay.Titles.Add(title1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "ShoeShi Sneakers";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.iconPictureBox3);
            this.groupBox3.Controls.Add(this.lblTongDoanhThu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng Doanh Thu";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CircleDollarToSlot;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 65;
            this.iconPictureBox3.Location = new System.Drawing.Point(18, 29);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(68, 65);
            this.iconPictureBox3.TabIndex = 6;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(92, 43);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(78, 25);
            this.lblTongDoanhThu.TabIndex = 4;
            this.lblTongDoanhThu.Text = "111111";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.chartTongDoanhThu);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 907);
            this.panel2.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblHangYeuThichNhat);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblSoLuongConLai);
            this.groupBox4.Controls.Add(this.lblNguonCung);
            this.groupBox4.Controls.Add(this.lblSoLuongBanRa);
            this.groupBox4.Controls.Add(this.lblSoLuongMatHang);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 663);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(960, 241);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng Cộng";
            // 
            // lblHangYeuThichNhat
            // 
            this.lblHangYeuThichNhat.AutoSize = true;
            this.lblHangYeuThichNhat.Location = new System.Drawing.Point(17, 162);
            this.lblHangYeuThichNhat.Name = "lblHangYeuThichNhat";
            this.lblHangYeuThichNhat.Size = new System.Drawing.Size(78, 25);
            this.lblHangYeuThichNhat.TabIndex = 5;
            this.lblHangYeuThichNhat.Text = "111111";
            this.lblHangYeuThichNhat.Click += new System.EventHandler(this.lblHangYeuThichNhat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hãng Yêu Thích Nhất";
            // 
            // lblSoLuongConLai
            // 
            this.lblSoLuongConLai.AutoSize = true;
            this.lblSoLuongConLai.Location = new System.Drawing.Point(17, 112);
            this.lblSoLuongConLai.Name = "lblSoLuongConLai";
            this.lblSoLuongConLai.Size = new System.Drawing.Size(78, 25);
            this.lblSoLuongConLai.TabIndex = 3;
            this.lblSoLuongConLai.Text = "111111";
            // 
            // lblNguonCung
            // 
            this.lblNguonCung.AutoSize = true;
            this.lblNguonCung.Location = new System.Drawing.Point(17, 87);
            this.lblNguonCung.Name = "lblNguonCung";
            this.lblNguonCung.Size = new System.Drawing.Size(151, 25);
            this.lblNguonCung.TabIndex = 2;
            this.lblNguonCung.Text = "Số lượng còn lại";
            // 
            // lblSoLuongBanRa
            // 
            this.lblSoLuongBanRa.AutoSize = true;
            this.lblSoLuongBanRa.Location = new System.Drawing.Point(17, 51);
            this.lblSoLuongBanRa.Name = "lblSoLuongBanRa";
            this.lblSoLuongBanRa.Size = new System.Drawing.Size(78, 25);
            this.lblSoLuongBanRa.TabIndex = 1;
            this.lblSoLuongBanRa.Text = "111111";
            // 
            // lblSoLuongMatHang
            // 
            this.lblSoLuongMatHang.AutoSize = true;
            this.lblSoLuongMatHang.Location = new System.Drawing.Point(17, 26);
            this.lblSoLuongMatHang.Name = "lblSoLuongMatHang";
            this.lblSoLuongMatHang.Size = new System.Drawing.Size(191, 25);
            this.lblSoLuongMatHang.TabIndex = 0;
            this.lblSoLuongMatHang.Text = "Số lượng giày bán ra";
            // 
            // chartTongDoanhThu
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.Size = 3F;
            chartArea2.AxisY.LabelStyle.Format = "{0,0,0} VNĐ";
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.BorderWidth = 8;
            chartArea2.Name = "ChartArea1";
            this.chartTongDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTongDoanhThu.Legends.Add(legend2);
            this.chartTongDoanhThu.Location = new System.Drawing.Point(18, 182);
            this.chartTongDoanhThu.Name = "chartTongDoanhThu";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.LabelBackColor = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.MarkerSize = 9;
            series2.Name = "Theo VND";
            this.chartTongDoanhThu.Series.Add(series2);
            this.chartTongDoanhThu.Size = new System.Drawing.Size(960, 455);
            this.chartTongDoanhThu.TabIndex = 16;
            this.chartTongDoanhThu.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Tổng Doanh Thu";
            this.chartTongDoanhThu.Titles.Add(title2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.iconPictureBox2);
            this.groupBox1.Controls.Add(this.lblSoLuongDonHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số Lượng Đơn Hàng";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 65;
            this.iconPictureBox2.Location = new System.Drawing.Point(16, 29);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(68, 65);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblSoLuongDonHang
            // 
            this.lblSoLuongDonHang.AutoSize = true;
            this.lblSoLuongDonHang.Location = new System.Drawing.Point(90, 43);
            this.lblSoLuongDonHang.Name = "lblSoLuongDonHang";
            this.lblSoLuongDonHang.Size = new System.Drawing.Size(78, 25);
            this.lblSoLuongDonHang.TabIndex = 2;
            this.lblSoLuongDonHang.Text = "111111";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.iconPictureBox1);
            this.groupBox2.Controls.Add(this.lblSoLuongKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 118);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số Lượng Khách Hàng";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 65;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(68, 65);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblSoLuongKhachHang
            // 
            this.lblSoLuongKhachHang.AutoSize = true;
            this.lblSoLuongKhachHang.Location = new System.Drawing.Point(90, 43);
            this.lblSoLuongKhachHang.Name = "lblSoLuongKhachHang";
            this.lblSoLuongKhachHang.Size = new System.Drawing.Size(78, 25);
            this.lblSoLuongKhachHang.TabIndex = 3;
            this.lblSoLuongKhachHang.Text = "111111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bảng Thống Kê";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(847, 416);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(8, 8);
            this.iconButton4.TabIndex = 15;
            this.iconButton4.Text = "iconButton4";
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1567, 907);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1240, 540);
            this.Name = "frmThongKe";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHangBanChay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHangBanChay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblHangYeuThichNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoLuongConLai;
        private System.Windows.Forms.Label lblNguonCung;
        private System.Windows.Forms.Label lblSoLuongBanRa;
        private System.Windows.Forms.Label lblSoLuongMatHang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTongDoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblSoLuongDonHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblSoLuongKhachHang;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}