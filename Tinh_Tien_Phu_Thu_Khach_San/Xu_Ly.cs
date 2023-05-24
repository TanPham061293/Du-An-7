using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Tien_Phu_Thu_Khach_San
{
    internal class Xu_Ly
    {
        private string str;
        public string Getter()
        {
            return str;
        }
        public void Setter(string a)
        {
            str = a;
        }
        public void ThemDauPhancach()
        {
            int leng = str.Length;
            for (int i = leng - 1; i >= 0; i--) // xét từ lớn về nhỏ
            {

                if ((leng - i) % 3 == 0 && i != 0)
                {
                    str = str.Insert(i, ".");
                }
            }
        }
        private string DocSo(char str1)
        {
            if (str1 == '1')
            {
                return "Một";
            }
            if (str1 == '2')
            {
                return "Hai";
            }
            if (str1 == '3')
            {
                return "Ba";
            }
            if (str1 == '4')
            {
                return "Bốn";
            }
            if (str1 == '5')
            {
                return "Năm";
            }
            if (str1 == '6')
            {
                return "Sáu";
            }
            if (str1 == '7')
            {
                return "Bảy";
            }
            if (str1 == '8')
            {
                return "Tám";
            }
            if (str1 == '9')
            {
                return "Chín";
            }
            return "Không";
        }
        List<string> DocHangdonvi = new List<string>();
        private void AddList()
        {
            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    DocHangdonvi.Add(" Đồng ");
                }
                else if (i == 1 || i == 4 || i == 7 || i == 10)
                {
                    DocHangdonvi.Add(" Mươi ");
                }
                else if (i == 2 || i == 5 || i == 8)
                {
                    DocHangdonvi.Add(" Trăm ");
                }
                else if (i == 3)
                {
                    DocHangdonvi.Add(" Ngàn ");
                }
                else if (i == 6)
                {
                    DocHangdonvi.Add(" Triệu ");
                }
                else if (i == 9)
                {
                    DocHangdonvi.Add(" Tỷ ");
                }
            }
        }
        public void XuLy_SoIntoChuoi()
        {
            if (str[0] == '-')
            {
                str = "Âm Tiền (Khách đưa chưa đủ Tổng Tiền).";
            }
            else
            {
                do
                {
                    if (str.Contains("."))
                    {
                        str = str.Remove(str.IndexOf('.'), 1);
                    }
                } while (str.Contains("."));
                AddList();
                int leng = str.Length;
                string str1 = "";
                for (int i = 0; i < leng; i++)
                {
                    if (str[i] == '1')
                    {   
                        if ((leng -i) % 3 == 1 && i != 0 )
                        {
                            if (str[i -1] != '0' && str[i - 1] != '1')
                            {
                                str1 += "Mốt";
                                str1 += DocHangdonvi[leng - i - 1].ToString();
                            }
                            else
                            {
                                str1 += DocSo(str[i]);
                                str1 += DocHangdonvi[leng - i - 1].ToString();
                            }
                        }
                        else if ((leng - i) % 3 == 2)
                        {
                            str1 += " Mười ";
                        }
                        else
                        {
                            str1 += (string)DocSo(str[i]);
                            str1 += DocHangdonvi[leng - i - 1].ToString();
                        }
                    }
                    else if (str[i] == '0')
                    {
                        if ((leng - i) % 3 == 1 && i != 0)
                        {
                            str1 += "";
                            str1 += DocHangdonvi[leng - i - 1].ToString();
                        }
                        else if ((leng- i) % 3 == 2 && i != 0)
                        {
                            if (str[i + 1] != '0')
                            {
                                str1 += "Lẻ";
                            }
                            else
                            {
                                str1 += "";
                            }
                        }
                        else if ((leng - i) % 3 == 0 && i != 0)
                        {
                            if (str[i + 1] == '0' && str[i + 2] == '0')
                            {
                                str1 += "";
                            }
                            else
                            {
                                str1 += DocSo(str[i]);
                                str1 += DocHangdonvi[leng - 1 - i].ToString();
                            }
                        }
                        else
                        {
                            str1 += DocSo(str[i]);
                            str1 += DocHangdonvi[leng - 1 - i].ToString();
                        }
                    }
                    else if (str[i] == '5')
                    {
                        if ((leng - i - 1) % 3 == 0 && i != 0)
                        {
                            if (str[i - 1] != '0')
                            {

                                str1 += "Lăm";
                            }
                            else
                            {
                                str1 += "Năm";

                            }
                        }
                        else
                        {
                            str1 += DocSo(str[i]);
                        }
                        str1 += DocHangdonvi[leng - i - 1].ToString();
                    }
                    else
                    {
                        str1 += (string)DocSo(str[i]);
                        str1 += DocHangdonvi[leng - i - 1].ToString();
                    }
                }
                str = str1 + ".";
            }
        }
    }
}
