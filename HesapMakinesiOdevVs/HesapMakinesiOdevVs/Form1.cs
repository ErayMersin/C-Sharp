using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiNew
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2;
        double sonuc;
        bool control = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 0, 1, 2, 3, 4, 5, 6, 7, 8 ve 9 Tuşları
            Button btn = (Button)sender;
            if (label2.Text != "+" && label2.Text != "-" && label2.Text != "*" && label2.Text != "/" && label2.Text != "pow" && label2.Text != "mod" && label2.Text != "ebob" && label2.Text != "ekok" && label2.Text != "√")
            {
                label1.Text += Convert.ToString(btn.Text);
            }
            else
            {
                label3.Text += Convert.ToString(btn.Text);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label5.Visible = false;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // +, -, * ve / Tuşları
            if (label1.Text == "")
            {
                MessageBox.Show("Once sayı giriniz.");
            }
            else
            {
                Button btn2 = (Button)sender;
                label2.Text = Convert.ToString(btn2.Text);
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Once Sayı Gırınız.");
            }
            else
            {  // ± Tuşu
                if (label1.Text != "" && label3.Text == "")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    double eksiSayi1 = sayi1 * -1;
                    label1.Text = Convert.ToString(eksiSayi1);
                }
                else if (label3.Text != "")
                {
                    sayi2 = Convert.ToDouble(label3.Text);
                    double eksiSayi2 = sayi2 * -1;
                    label3.Text = Convert.ToString(eksiSayi2);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // C Tuşu
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // CE Tuşu
            if (label4.Text != " ")
            {
                label4.Text = " ";
            }
            else if (label3.Text != " ")
            {
                label3.Text = " ";
            }
            else if (label2.Text != " ")
            {
                label2.Text = " ";
            }
            else if (label1.Text != " ")
            {
                label1.Text = " ";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Once Sayı Giriniz.");
            }
            else
            {
                // pow, ebob, ekok, mod ve √ Tuşları
                Button btn3 = (Button)sender;
                label2.Text = btn3.Text;
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            // < Tuşu
            if (!string.IsNullOrEmpty(label2.Text))
            {
                control = true;
            }
            else
            {
                control = false;
            }

            if (!string.IsNullOrEmpty(label1.Text) && !control)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
            else if (!string.IsNullOrEmpty(label1.Text) && control && !string.IsNullOrEmpty(label3.Text))
            {
                label3.Text = label3.Text.Remove(label3.Text.Length - 1);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // Geçmiş Tuşu 
            label5.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Virgül İşareti 
            if (label2.Text != "+" && label2.Text != "-" && label2.Text != "*" && label2.Text != "/" && label2.Text != "pow" && label2.Text != "mod" && label2.Text != "ebob" && label2.Text != "ekok" && label2.Text != "√")
            {
                label1.Text += ",";
            }
            if (label2.Text == "+" || label2.Text == "-" || label2.Text == "*" || label2.Text == "/")
            {
                label3.Text += ",";
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            // Kapat Tuşu
            this.Close();
            Application.Exit();
        }
        public string ConvertToRoman(double number)
        {
            if (number < 1 || number > 3999)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Geçerli bir Roma rakamı değil.");
            }
            string[] romanNumerals = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] values = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string result = "";
            for (int i = values.Length - 1; i >= 0; i--)
            {
                while (number >= values[i])
                {
                    result += romanNumerals[i];
                    number -= values[i];
                }
            }
            return result;
        }


        private void button21_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Once Sayı Giriniz.");
            }
            else
            {
                // E Tuşu
                if (label2.Text == "/")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    sonuc = sayi1 / sayi2;
                }
                else if (label2.Text == "+")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    sonuc = sayi1 + sayi2;
                }
                else if (label2.Text == "-")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    sonuc = sayi1 - sayi2;
                }
                else if (label2.Text == "*")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    sonuc = sayi1 * sayi2;
                }
                else if (label2.Text == "pow")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    sonuc = Math.Pow(sayi1, sayi2);
                }
                else if (label2.Text == "√")
                {
                    if (label1.Text != " ")
                    {
                        sayi1 = Convert.ToDouble(label1.Text);
                        sonuc = Math.Sqrt(sayi1);
                    }
                    else
                    {
                        MessageBox.Show("Birinci Sayi Esas Alinacaktir.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (label2.Text == "mod")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    sonuc = sayi1 % sayi2;
                }
                else if (label2.Text == "ebob")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sayi2 = Convert.ToDouble(label3.Text);
                    int ebob = 0;

                    for (int i = 1; i < sayi1; i++)
                    {
                        if (sayi1 % i == 0 && sayi2 % i == 0)
                        {
                            ebob = i;
                        }
                    }
                    sonuc = ebob;
                }
                else if (label2.Text == "ekok")
                {
                    int intSayi1 = Convert.ToInt32(label1.Text);
                    int intSayi2 = Convert.ToInt32(label3.Text);
                    int ekok = 0;
                    int max = intSayi1 * intSayi2;

                    for (int i = max; i > 0; i--)
                    {
                        if (i % intSayi1 == 0 && i % intSayi2 == 0)
                        {
                            ekok = i;
                        }
                    }
                    int doubleSonuc = ekok;
                    sonuc = Convert.ToDouble(doubleSonuc);
                }
                if (label1.Text == " ") //Gerekli uyarılar
                {
                    MessageBox.Show("İki Sayi Girilmeden İşlem Yapılamaz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (label3.Text == " " && label1.Text != " " && label2.Text != "√")
                {
                    MessageBox.Show("İkinci Sayi Girilmeli!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                label4.Text = "= " + sonuc.ToString();


                if (label4.Text != " ") //Geçmiş yazdırmak
                {
                    label5.Text += label1.Text + " " + label2.Text + label3.Text + label4.Text + "\n";
                }
                label6.Text = ConvertToRoman(sonuc);
            }
        }

    }
}
