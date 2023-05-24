namespace Tinh_Tien_Phu_Thu_Khach_San
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lb_Ds_SanPham = new Label();
            Cb_Dauphancach = new CheckBox();
            cb_So_into_Chu = new CheckBox();
            cb_Goiy_tienthoi = new CheckBox();
            cb_Goiy_Hinhanh = new CheckBox();
            gb_chuanhoa = new GroupBox();
            gb_Sanpham = new GroupBox();
            vScrollBar1 = new VScrollBar();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bt_Inhoadon = new Button();
            lb_Tongtien = new Label();
            tb_tienkhachdua = new TextBox();
            lb_tienthoi = new Label();
            bindingSource1 = new BindingSource(components);
            tb_chutongtien = new TextBox();
            tb_chukhachdua = new TextBox();
            tb_chutienthoi = new TextBox();
            label7 = new Label();
            tb_goiytienthoila = new TextBox();
            label8 = new Label();
            gb_chuanhoa.SuspendLayout();
            gb_Sanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lb_Ds_SanPham
            // 
            lb_Ds_SanPham.AutoSize = true;
            lb_Ds_SanPham.Location = new Point(6, 19);
            lb_Ds_SanPham.Name = "lb_Ds_SanPham";
            lb_Ds_SanPham.Size = new Size(83, 15);
            lb_Ds_SanPham.TabIndex = 0;
            lb_Ds_SanPham.Text = "Tên sản phẩm:";
            // 
            // Cb_Dauphancach
            // 
            Cb_Dauphancach.AutoSize = true;
            Cb_Dauphancach.Location = new Point(20, 22);
            Cb_Dauphancach.Name = "Cb_Dauphancach";
            Cb_Dauphancach.Size = new Size(140, 19);
            Cb_Dauphancach.TabIndex = 0;
            Cb_Dauphancach.Text = "Thêm dấu phân cách.";
            Cb_Dauphancach.UseVisualStyleBackColor = true;
            Cb_Dauphancach.CheckedChanged += Cb_Dauphancach_CheckedChanged;
            // 
            // cb_So_into_Chu
            // 
            cb_So_into_Chu.AutoSize = true;
            cb_So_into_Chu.Location = new Point(20, 56);
            cb_So_into_Chu.Name = "cb_So_into_Chu";
            cb_So_into_Chu.Size = new Size(122, 19);
            cb_So_into_Chu.TabIndex = 1;
            cb_So_into_Chu.Text = "Đọc số thành chữ.";
            cb_So_into_Chu.UseVisualStyleBackColor = true;
            cb_So_into_Chu.CheckedChanged += cb_So_into_Chu_CheckedChanged;
            // 
            // cb_Goiy_tienthoi
            // 
            cb_Goiy_tienthoi.AutoSize = true;
            cb_Goiy_tienthoi.Location = new Point(20, 94);
            cb_Goiy_tienthoi.Name = "cb_Goiy_tienthoi";
            cb_Goiy_tienthoi.Size = new Size(103, 19);
            cb_Goiy_tienthoi.TabIndex = 2;
            cb_Goiy_tienthoi.Text = "Gợi ý tiền thối.";
            cb_Goiy_tienthoi.UseVisualStyleBackColor = true;
            cb_Goiy_tienthoi.CheckedChanged += cb_Goiy_tienthoi_CheckedChanged;
            // 
            // cb_Goiy_Hinhanh
            // 
            cb_Goiy_Hinhanh.AutoSize = true;
            cb_Goiy_Hinhanh.Location = new Point(20, 131);
            cb_Goiy_Hinhanh.Name = "cb_Goiy_Hinhanh";
            cb_Goiy_Hinhanh.Size = new Size(191, 19);
            cb_Goiy_Hinhanh.TabIndex = 3;
            cb_Goiy_Hinhanh.Text = "Gợi ý tiền thối (Bằng hình ảnh).";
            cb_Goiy_Hinhanh.UseVisualStyleBackColor = true;
            cb_Goiy_Hinhanh.CheckedChanged += cb_Goiy_Hinhanh_CheckedChanged;
            // 
            // gb_chuanhoa
            // 
            gb_chuanhoa.AutoSize = true;
            gb_chuanhoa.Controls.Add(cb_So_into_Chu);
            gb_chuanhoa.Controls.Add(cb_Goiy_Hinhanh);
            gb_chuanhoa.Controls.Add(Cb_Dauphancach);
            gb_chuanhoa.Controls.Add(cb_Goiy_tienthoi);
            gb_chuanhoa.Location = new Point(541, 27);
            gb_chuanhoa.Name = "gb_chuanhoa";
            gb_chuanhoa.Size = new Size(223, 172);
            gb_chuanhoa.TabIndex = 2;
            gb_chuanhoa.TabStop = false;
            gb_chuanhoa.Text = "Chuẩn hóa Chức năng.";
            // 
            // gb_Sanpham
            // 
            gb_Sanpham.Controls.Add(vScrollBar1);
            gb_Sanpham.Controls.Add(label3);
            gb_Sanpham.Controls.Add(label2);
            gb_Sanpham.Controls.Add(label1);
            gb_Sanpham.Controls.Add(lb_Ds_SanPham);
            gb_Sanpham.Location = new Point(12, 27);
            gb_Sanpham.Name = "gb_Sanpham";
            gb_Sanpham.Size = new Size(523, 172);
            gb_Sanpham.TabIndex = 3;
            gb_Sanpham.TabStop = false;
            gb_Sanpham.Text = "Danh Sách Sản phẩm.";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(503, 11);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 158);
            vScrollBar1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 19);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Thành tiền.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 19);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Số lượng.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 217);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            label5.Location = new Point(188, 252);
            label5.Name = "label5";
            label5.Size = new Size(105, 27);
            label5.TabIndex = 5;
            label5.Text = "Tiền khách đưa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 291);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 6;
            label6.Text = "Tiền thối:";
            // 
            // bt_Inhoadon
            // 
            bt_Inhoadon.Location = new Point(48, 213);
            bt_Inhoadon.Name = "bt_Inhoadon";
            bt_Inhoadon.Size = new Size(89, 45);
            bt_Inhoadon.TabIndex = 7;
            bt_Inhoadon.Text = "In Hóa Đơn.";
            bt_Inhoadon.UseVisualStyleBackColor = true;
            // 
            // lb_Tongtien
            // 
            lb_Tongtien.Location = new Point(282, 209);
            lb_Tongtien.Name = "lb_Tongtien";
            lb_Tongtien.Size = new Size(114, 23);
            lb_Tongtien.TabIndex = 8;
            lb_Tongtien.Text = "0";
            // 
            // tb_tienkhachdua
            // 
            tb_tienkhachdua.Location = new Point(282, 249);
            tb_tienkhachdua.Name = "tb_tienkhachdua";
            tb_tienkhachdua.Size = new Size(114, 23);
            tb_tienkhachdua.TabIndex = 9;
            tb_tienkhachdua.Text = "0";
            tb_tienkhachdua.Click += tb_tienkhachdua_Click;
            tb_tienkhachdua.KeyPress += tb_tienkhachdua_KeyPress;
            // 
            // lb_tienthoi
            // 
            lb_tienthoi.Location = new Point(282, 288);
            lb_tienthoi.Name = "lb_tienthoi";
            lb_tienthoi.Size = new Size(112, 23);
            lb_tienthoi.TabIndex = 10;
            lb_tienthoi.Text = "0";
            // 
            // tb_chutongtien
            // 
            tb_chutongtien.Enabled = false;
            tb_chutongtien.Location = new Point(413, 206);
            tb_chutongtien.Multiline = true;
            tb_chutongtien.Name = "tb_chutongtien";
            tb_chutongtien.Size = new Size(351, 23);
            tb_chutongtien.TabIndex = 11;
            tb_chutongtien.Visible = false;
            // 
            // tb_chukhachdua
            // 
            tb_chukhachdua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_chukhachdua.Location = new Point(413, 249);
            tb_chukhachdua.Multiline = true;
            tb_chukhachdua.Name = "tb_chukhachdua";
            tb_chukhachdua.Size = new Size(351, 23);
            tb_chukhachdua.TabIndex = 11;
            tb_chukhachdua.Visible = false;
            // 
            // tb_chutienthoi
            // 
            tb_chutienthoi.Enabled = false;
            tb_chutienthoi.Location = new Point(413, 288);
            tb_chutienthoi.Multiline = true;
            tb_chutienthoi.Name = "tb_chutienthoi";
            tb_chutienthoi.Size = new Size(349, 23);
            tb_chutienthoi.TabIndex = 11;
            tb_chutienthoi.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 326);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 12;
            label7.Text = "Gợi ý tiền thối:";
            // 
            // tb_goiytienthoila
            // 
            tb_goiytienthoila.Location = new Point(278, 326);
            tb_goiytienthoila.Multiline = true;
            tb_goiytienthoila.Name = "tb_goiytienthoila";
            tb_goiytienthoila.Size = new Size(118, 99);
            tb_goiytienthoila.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 326);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 14;
            label8.Text = "Gợi ý hình ảnh:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(tb_goiytienthoila);
            Controls.Add(label7);
            Controls.Add(tb_chutienthoi);
            Controls.Add(tb_chukhachdua);
            Controls.Add(tb_chutongtien);
            Controls.Add(lb_tienthoi);
            Controls.Add(tb_tienkhachdua);
            Controls.Add(lb_Tongtien);
            Controls.Add(bt_Inhoadon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(gb_Sanpham);
            Controls.Add(gb_chuanhoa);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_chuanhoa.ResumeLayout(false);
            gb_chuanhoa.PerformLayout();
            gb_Sanpham.ResumeLayout(false);
            gb_Sanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Ds_SanPham;
        private CheckBox Cb_Dauphancach;
        private CheckBox cb_So_into_Chu;
        private CheckBox cb_Goiy_tienthoi;
        private CheckBox cb_Goiy_Hinhanh;
        private GroupBox gb_chuanhoa;
        private GroupBox gb_Sanpham;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button bt_Inhoadon;
        private Label lb_Tongtien;
        private TextBox tb_tienkhachdua;
        private Label lb_tienthoi;
        private BindingSource bindingSource1;
        private TextBox tb_chutongtien;
        private TextBox tb_chukhachdua;
        private TextBox tb_chutienthoi;
        private Label label7;
        private TextBox tb_goiytienthoila;
        private Label label8;
        private VScrollBar vScrollBar1;
    }
}