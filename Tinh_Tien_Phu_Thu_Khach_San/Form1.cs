namespace Tinh_Tien_Phu_Thu_Khach_San
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string DiaChiFile_ds_SanPham = "Danh_Sach_San_Pham.TXT";
        List<string> danhsachsanpham = new List<string>();
        List<int> dongia = new List<int>();
        List<CheckBox> arr_checkbox = new List<CheckBox>(); // danh sach checkbox sản phẩm đọc từ file
        List<TextBox> arr_textbox = new List<TextBox>(); // danh sách texbox số lượng
        List<Label> arr_label = new List<Label>(); // danh sách label đơn giá từ file
        List<Label> arr_Thanhtien = new List<Label>(); // danh sách các label thành tiền
        List<string> arr_Tien = new List<string>();
        string Dia_Chi_Ds_Tien = "Danh_Sach_Tien.txt";
        List<FileInfo> arr_Anh_Tien = new List<FileInfo>(); // chứa thông tin danh sách ảnh
        static string Dia_Chi_anh = "Anh_Tien"; // địa chỉ thư mục
        DirectoryInfo dr_anh_Tien = new DirectoryInfo(Dia_Chi_anh); // thông tin thư mục
        int leng; // số lượng phần tử của danh sách checkboc -- dùng chung
        Xu_Ly daucach = new Xu_Ly(); // class xử lý
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DiaChiFile_ds_SanPham) || !File.Exists(Dia_Chi_Ds_Tien) || !dr_anh_Tien.Exists) // kiểm tra đường dẫn file
            {
                MessageBox.Show("Địa chỉ File Danh sách Sản Phẩm Không Chính xác.");
            }
            else
            {
                foreach (var item in File.ReadLines(DiaChiFile_ds_SanPham))
                {
                    int Chiso = item.IndexOf(".");
                    // string str = 
                    danhsachsanpham.Add(item.Substring(0, Chiso)); // đưa sản phẩm vài danh sách
                    dongia.Add(int.Parse(item.Substring(Chiso + 1))); // đưa đơn giá váo danh sách
                }
                foreach (var item1 in File.ReadLines(Dia_Chi_Ds_Tien))
                {
                    arr_Tien.Add(item1);
                }
                foreach (var item2 in dr_anh_Tien.GetFiles())
                {
                    arr_Anh_Tien.Add(item2);
                }
            }
            leng = danhsachsanpham.Count;

            for (int i = 0; i < leng; i++) // thêm check box danh sách sản phẩm vào control
            {
                CheckBox cb = new CheckBox();
                cb.Text = danhsachsanpham[i].ToString();
                cb.Name = "cb_Sanpham" + i.ToString();
                cb.TabIndex = i;
                cb.Size = new Size(120, 20);

                if (i == 0)
                {
                    cb.Location = new Point(20, lb_Ds_SanPham.Location.Y + 30);
                }
                else
                {
                    cb.Location = new Point(20, arr_checkbox[arr_checkbox.Count - 1].Location.Y + 30);
                }
                arr_checkbox.Add(cb);

                gb_Sanpham.Controls.Add(arr_checkbox[i]);
                cb.CheckedChanged += Cb_CheckedChanged;
            }

            for (int j = 0; j < leng; j++)
            {
                TextBox tb = new TextBox(); // thêm textbox vào control
                tb.Text = "0";
                tb.Name = "tb_Soluong_" + j.ToString();
                tb.Location = new Point(arr_checkbox[j].Location.X + arr_checkbox[j].Size.Width + 50, arr_checkbox[j].Location.Y);
                tb.Size = new Size(30, 15);

                tb.Enabled = false;
                arr_textbox.Add(tb);
                gb_Sanpham.Controls.Add(tb);
                tb.KeyPress += Tb_KeyPress;
                tb.Leave += Tb_Leave;

                Label lb = new Label(); // thêm label  đơn giá vào control
                lb.Text = dongia[j].ToString();
                lb.Name = "lb_DơnGia" + j.ToString();
                lb.Location = new Point(arr_checkbox[j].Location.X + arr_checkbox[j].Size.Width + 50 + 100, arr_checkbox[j].Location.Y);
                lb.Size = new Size(50, 20);
                arr_label.Add(lb);
                //lb.Visible = false;
                gb_Sanpham.Controls.Add(lb);

                Label lb1 = new Label(); // thêm label thành tiền vào control
                lb1.Text = "0";
                lb1.Name = "lb_Thanhtien" + j.ToString();
                lb1.Location = new Point(arr_checkbox[j].Location.X + arr_checkbox[j].Size.Width + 50 + 50 + 170, arr_checkbox[j].Location.Y);
                lb1.AutoSize = true;
                arr_Thanhtien.Add(lb1);
                gb_Sanpham.Controls.Add(lb1);

            }
            label8.Visible = false;
        }

        private void Tb_Leave(object? sender, EventArgs e)
        {
            thanhtien = 0;
        }
        private string Xuly_Dauphaykhichuyensangchu(string a)
        {
            do
            {
                if (a.Contains("."))
                {
                    a = a.Remove(a.IndexOf('.'), 1);
                }
            } while (a.Contains("."));
            return a;
        }
        int thanhtien = 0;
        string a;
        private void Tb_KeyPress(object? sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back) // kiểm tra không phải số và kí tự back thì không cho nhập
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập kí tự khác số.");
            }
            for (int i = 0; i < leng; i++)
            {
                if (arr_textbox[i].Name == ((TextBox)sender).Name)
                {
                    if ((Keys)e.KeyChar != Keys.Back)
                    {
                        thanhtien = thanhtien * 10;
                        a = Xuly_Dauphaykhichuyensangchu(arr_label[i].Text);

                        thanhtien += int.Parse(e.KeyChar.ToString()) * int.Parse(a.ToString());
                        arr_Thanhtien[i].Text = thanhtien.ToString();
                    }
                    else
                    {
                        a = Xuly_Dauphaykhichuyensangchu(arr_label[i].Text);
                        thanhtien -= int.Parse(arr_textbox[i].Text.Substring(arr_textbox[i].Text.Length - 1)) * int.Parse(a.ToString());
                        thanhtien = thanhtien / 10;
                        arr_Thanhtien[i].Text = thanhtien.ToString();
                    }
                    if (Cb_Dauphancach.Checked == true)
                    {
                        daucach.Setter(arr_Thanhtien[i].Text);
                        daucach.ThemDauPhancach();
                        arr_Thanhtien[i].Text = daucach.Getter();
                    }
                    break;
                }
            }
            int tongien = 0;
            for (int i = 0; i < leng; i++)
            {
                a = Xuly_Dauphaykhichuyensangchu(arr_Thanhtien[i].Text);
                tongien += int.Parse(a);
            }
            lb_Tongtien.Text = tongien.ToString();
            a = Xuly_Dauphaykhichuyensangchu(tb_tienkhachdua.Text);
            lb_tienthoi.Text = (int.Parse(a) - tongien).ToString();
            if (Cb_Dauphancach.Checked == true)
            {
                daucach.Setter(lb_Tongtien.Text);
                daucach.ThemDauPhancach();
                lb_Tongtien.Text = daucach.Getter();

                daucach.Setter(lb_tienthoi.Text);
                daucach.ThemDauPhancach();
                lb_tienthoi.Text = daucach.Getter();
            }
            if (cb_So_into_Chu.Checked == true)
            {
                daucach.Setter(lb_Tongtien.Text);
                daucach.XuLy_SoIntoChuoi();
                tb_chutongtien.Text = daucach.Getter();

                daucach.Setter(lb_tienthoi.Text);
                daucach.XuLy_SoIntoChuoi();
                tb_chutienthoi.Text = daucach.Getter();
            }
        }
        private void Cb_CheckedChanged(object? sender, EventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (arr_checkbox[i].Name == ((CheckBox)sender).Name) // kiểm tra xem sự kiện checked vào phần tử nào
                {
                    if (arr_checkbox[i].Checked == true)
                    {
                        arr_textbox[i].Enabled = true;
                        arr_textbox[i].Focus();
                    }
                    else
                    {
                        arr_textbox[i].Text = "";
                        arr_Thanhtien[i].Text = "0";
                        arr_textbox[i].Enabled = false;
                    }
                    break;
                }
            }
        }

        string tb_khachdua = ""; // chuỗi để đưa vào getter.
        private void tb_tienkhachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // dừng không cho nhận kí tự
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back) // nếu không phải số và kí tự xóa thì không cho nhận
            {
                MessageBox.Show("Kí tự nhập không phù hợp.");
            }
            else // là số và kí tự xóa
            {
                if ((Keys)e.KeyChar == Keys.Back)
                {
                    if (tb_khachdua != "")
                    {
                        tb_khachdua = tb_khachdua.Remove(tb_khachdua.Length - 1);
                        tb_tienkhachdua.Text = tb_khachdua;
                        tb_tienkhachdua.Select(tb_tienkhachdua.Text.Length, 1);

                        if (tb_khachdua.Length >= 1) // tránh lỗi khi xóa hết sẻ bị lỗi format
                        {
                            a = Xuly_Dauphaykhichuyensangchu(lb_Tongtien.Text);
                            lb_tienthoi.Text = (int.Parse(tb_khachdua) - int.Parse(a)).ToString(); // lỗi chỗ này khi xóa hết chuỗi
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để xóa.");
                    }
                }
                else
                {
                    tb_khachdua += e.KeyChar.ToString();
                    a = Xuly_Dauphaykhichuyensangchu(lb_Tongtien.Text);
                    lb_tienthoi.Text = (int.Parse(tb_khachdua) - int.Parse(a)).ToString();

                    //MessageBox.Show(tb_khachdua);
                    if (Cb_Dauphancach.Checked == true && tb_khachdua.Length > 3)
                    {
                        daucach.Setter(tb_khachdua);
                        daucach.ThemDauPhancach();
                        tb_tienkhachdua.Text = daucach.Getter(); // lấy lại chuỗi đã đưa vào xử lý.
                        tb_tienkhachdua.Select(tb_tienkhachdua.Text.Length, 1);
                    }
                    else
                    {
                        tb_tienkhachdua.Text = tb_khachdua;
                        tb_tienkhachdua.Select(tb_tienkhachdua.Text.Length, 1);
                    }
                }
            }
            if (cb_So_into_Chu.Checked == true)
            {
                if (tb_khachdua != "")
                {
                    daucach.Setter(tb_khachdua); // nếu checkbox chức năng chuyển thành chữ là true thì tiển hành chuyển
                    daucach.XuLy_SoIntoChuoi();
                    tb_chukhachdua.Text = daucach.Getter();
                }
                daucach.Setter(lb_tienthoi.Text);
                daucach.XuLy_SoIntoChuoi();
                tb_chutienthoi.Text = daucach.Getter();
            }
            if (Cb_Dauphancach.Checked == true)
            {
                daucach.Setter(lb_tienthoi.Text);
                daucach.ThemDauPhancach();
                lb_tienthoi.Text = daucach.Getter();
            }
        }
        private void Cb_Dauphancach_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Dauphancach.Checked == true)
            {
                for (int i = 0; i < leng; i++)
                {
                    if (!arr_label[i].Text.Contains("."))
                    {
                        daucach.Setter(arr_label[i].Text); // thêm dấu phân cách cho đơn giá
                        daucach.ThemDauPhancach();
                        arr_label[i].Text = daucach.Getter();

                    }
                    if (!arr_Thanhtien[i].Text.Contains("."))
                    {
                        daucach.Setter(arr_Thanhtien[i].Text); // thêm dấu phân cách cho thành tiền
                        daucach.ThemDauPhancach();
                        arr_Thanhtien[i].Text = daucach.Getter();

                    }
                    if (!tb_tienkhachdua.Text.Contains("."))
                    {
                        daucach.Setter(tb_tienkhachdua.Text); // xử lý thêm dấu phân cách khi nhập xong mới bấm sự kiện checked
                        daucach.ThemDauPhancach();
                        tb_tienkhachdua.Text = daucach.Getter();
                    }
                    if (!lb_Tongtien.Text.Contains("."))
                    {
                        daucach.Setter(lb_Tongtien.Text); // xử lý thêm dấu phân cách khi nhập xong mới bấm sự kiện checked
                        daucach.ThemDauPhancach();
                        lb_Tongtien.Text = daucach.Getter();
                    }
                    if (!lb_tienthoi.Text.Contains("."))
                    {
                        daucach.Setter(lb_tienthoi.Text); // xử lý thêm dấu phân cách khi nhập xong mới bấm sự kiện checked
                        daucach.ThemDauPhancach();
                        lb_tienthoi.Text = daucach.Getter();
                    }
                }
            }
            else
            {
                for (int i = 0; i < leng; i++)
                {
                    arr_label[i].Text = Xuly_Dauphaykhichuyensangchu(arr_label[i].Text);
                }
            }
        }
        private void cb_So_into_Chu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_So_into_Chu.Checked == true)
            {
                tb_chukhachdua.Visible = true;
                if (tb_khachdua != "")
                {
                    // tb_chukhachdua.Visible = true; // cho hiện textbox và chuẩn hóa sang chữ
                    daucach.Setter(tb_khachdua);
                    daucach.XuLy_SoIntoChuoi();
                    tb_chukhachdua.Text = daucach.Getter();
                }

                tb_chutienthoi.Visible = true; // cho hiện textbox tiền thối chữ và chuyển sang chữ
                daucach.Setter(lb_tienthoi.Text);
                daucach.XuLy_SoIntoChuoi();
                tb_chutienthoi.Text = daucach.Getter();

                tb_chutongtien.Visible = true;//cho hiện textbox chữ tong tien và chuyển sang chữ
                daucach.Setter(lb_Tongtien.Text);
                daucach.XuLy_SoIntoChuoi();
                tb_chutongtien.Text = daucach.Getter();
            }
            else
            {
                tb_chukhachdua.Visible = false;
                tb_chutienthoi.Visible = false;
                tb_chutongtien.Visible = false;
            }

        }
        List<PictureBox> arr_pt = new List<PictureBox>(); // danh sách picturebox để location
        private void cb_Goiy_tienthoi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Goiy_tienthoi.Checked == true)
            {
                int leng1 = arr_Tien.Count();
                a = Xuly_Dauphaykhichuyensangchu(lb_tienthoi.Text);
                int tienthoilai = int.Parse(a);
                int totienthoilai = 0;
                string dualaikhach = "";
                int dem = 0;
                if (tienthoilai % 100 == 0)
                {
                    for (int i = leng1 - 1; i >= 0; i--)
                    {
                        int tien = int.Parse(arr_Tien[i]);
                        if (tien <= tienthoilai)
                        {
                            totienthoilai = tienthoilai / tien;
                            tienthoilai -= (totienthoilai * tien);
                            string chuyendoi = arr_Tien[i];
                            daucach.Setter(chuyendoi);
                            daucach.ThemDauPhancach();
                            chuyendoi = daucach.Getter();
                            dualaikhach += totienthoilai.ToString() + " tờ " + chuyendoi + "-";

                            if (cb_Goiy_Hinhanh.Checked == true)
                            {

                                foreach (var item in arr_Anh_Tien)
                                {
                                    int chisoIndex = item.Name.IndexOf(".");
                                    if (item.Name.Substring(0, chisoIndex).CompareTo(arr_Tien[i].ToString()) == 0)
                                    {
                                        PictureBox pt = new PictureBox();
                                        pt.Size = new Size(70, 40);
                                        pt.BackgroundImage = Image.FromFile(item.FullName);
                                        pt.BackgroundImageLayout = ImageLayout.Stretch;
                                        pt.Name = arr_Tien[i];
                                        if (dem == 0)
                                        {
                                            pt.Location = new Point(413, 350);
                                        }
                                        else
                                        {
                                            pt.Location = new Point(413 + (dem * arr_pt[arr_pt.Count() - 1].Size.Width), 350);
                                        }

                                        arr_pt.Add(pt);
                                        this.Controls.Add(pt);
                                    }
                                }
                            }
                            dem++;
                            if (tienthoilai == 0)
                            {
                                break;
                            }
                        }
                    }
                    tb_goiytienthoila.Text = dualaikhach;
                }
                else
                {
                    MessageBox.Show("Tiền thối lại không phù hợp.");
                    tb_tienkhachdua.Focus();
                    tb_tienkhachdua.SelectAll();
                }
            }
            else
            {
                tb_goiytienthoila.Text = "";
            }
        }

        private void cb_Goiy_Hinhanh_CheckedChanged(object sender, EventArgs e)
        {
            cb_Goiy_tienthoi.Checked = true;
            label8.Visible = true;
            if (cb_Goiy_Hinhanh.Checked == false)
            {
                cb_Goiy_tienthoi.Checked = false;
                label8.Visible = false;
                foreach (var item in arr_pt)
                {
                    this.Controls.Remove(item);
                }
            }
        }
        private void tb_tienkhachdua_Click(object sender, EventArgs e)
        {
            tb_tienkhachdua.SelectAll();
        }
    }
}
