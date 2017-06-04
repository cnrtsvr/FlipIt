using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FlipIt
{
    public partial class Form1 : Form
    {
        int hamle = 0;
        bool bitti = false;
        int rekor;
        string filename = "Save.txt";

        public Form1()
        {
            InitializeComponent();
            FileStream filestream = new FileStream("../../" + filename, FileMode.OpenOrCreate, FileAccess.Write);
            filestream.Close();
            getRekor();
            textBox2.Text = rekor.ToString();
            textBox1.Text = hamle.ToString();
        }

        private void getRekor()
        {
            TextReader textread = new StreamReader(filename);

            String readText = textread.ReadLine();
            rekor = Convert.ToInt32(readText);
            textread.Close();
            textBox2.Text = rekor.ToString();
        }

        private void setRekor()
        {
            TextWriter textwrite = new StreamWriter(filename);

            textwrite.WriteLine(rekor);
            textwrite.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button1.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button1.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button2.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button2.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button2.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button5.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button5.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button5.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button1.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button1.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button2.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button2.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button2.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button3.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button3.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button3.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button6.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button6.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button6.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button2.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button2.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button3.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button3.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button3.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button4.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button4.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button4.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button7.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button7.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button7.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button3.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button3.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button4.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button4.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button4.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button8.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button8.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button8.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button1.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button1.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button5.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button5.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button5.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button6.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button6.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button6.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button9.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button9.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button9.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button2.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button2.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button5.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button5.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button5.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button6.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button6.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button6.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button7.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button7.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button7.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button10.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button10.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button10.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button3.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button3.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button6.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button6.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button6.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button7.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button7.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button7.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button8.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button8.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button8.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button11.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button11.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button11.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button4.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button4.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button7.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button7.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button7.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button8.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button8.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button8.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button12.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button12.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button12.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button5.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button5.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button9.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button9.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button9.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button10.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button10.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button10.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button13.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button13.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button13.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button6.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button6.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button9.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button9.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button9.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button10.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button10.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button10.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button11.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button11.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button11.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button14.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button14.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button14.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button7.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button7.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button10.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button10.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button10.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button11.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button11.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button11.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button12.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button12.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button12.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button15.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button15.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button15.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button8.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button8.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button11.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button11.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button11.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button12.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button12.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button12.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button16.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button16.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button16.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button9.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button9.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button13.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button13.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button13.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button14.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button14.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button14.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button10.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button10.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button13.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button13.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button13.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button14.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button14.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button14.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button15.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button15.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button15.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button11.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button11.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button14.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button14.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button14.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button15.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button15.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button15.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button16.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button16.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button16.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button12.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button12.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button15.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button15.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button15.BackColor = System.Drawing.SystemColors.InfoText;
            }
            if (button16.BackColor == System.Drawing.SystemColors.InfoText)
            {
                button16.BackColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                button16.BackColor = System.Drawing.SystemColors.InfoText;
            }
            hamle++;
            textBox1.Text = hamle.ToString();
            hesapla();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bastığınız buton, kendisinin ve komşularının rengini değiştirir.\nOyunun amacı, bütün butonları en az hamlede beyaz yapmaktır.", "Oyun Yardımı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hesapla()
        {
            if(button1.BackColor == System.Drawing.SystemColors.Info && button2.BackColor == System.Drawing.SystemColors.Info && button3.BackColor == System.Drawing.SystemColors.Info && button4.BackColor == System.Drawing.SystemColors.Info)
            {
                if (button5.BackColor == System.Drawing.SystemColors.Info && button6.BackColor == System.Drawing.SystemColors.Info && button7.BackColor == System.Drawing.SystemColors.Info && button8.BackColor == System.Drawing.SystemColors.Info)
                {
                    if (button9.BackColor == System.Drawing.SystemColors.Info && button10.BackColor == System.Drawing.SystemColors.Info && button11.BackColor == System.Drawing.SystemColors.Info && button12.BackColor == System.Drawing.SystemColors.Info)
                    {
                        if (button13.BackColor == System.Drawing.SystemColors.Info && button14.BackColor == System.Drawing.SystemColors.Info && button15.BackColor == System.Drawing.SystemColors.Info && button16.BackColor == System.Drawing.SystemColors.Info)
                        {
                            bitti = true;
                            if(hamle < rekor || rekor == 0)
                            {
                                rekor = hamle;
                                setRekor();
                            }
                        }
                    }
                }
            }
            else
            {
                bitti = false;
            }
            if (bitti)
            {
                DialogResult secim = MessageBox.Show("Tebrikler ! Kazandınız !\n\nYeni oyuna başlamak ister misiniz ?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(secim == DialogResult.Yes)
                {
                    yeniOyun();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            yeniOyun();
        }

        private void yeniOyun()
        {
            button1.BackColor = System.Drawing.SystemColors.Info;
            button2.BackColor = System.Drawing.SystemColors.InfoText;
            button3.BackColor = System.Drawing.SystemColors.InfoText;
            button4.BackColor = System.Drawing.SystemColors.Info;
            button5.BackColor = System.Drawing.SystemColors.InfoText;
            button6.BackColor = System.Drawing.SystemColors.InfoText;
            button7.BackColor = System.Drawing.SystemColors.InfoText;
            button8.BackColor = System.Drawing.SystemColors.InfoText;
            button9.BackColor = System.Drawing.SystemColors.InfoText;
            button10.BackColor = System.Drawing.SystemColors.InfoText;
            button11.BackColor = System.Drawing.SystemColors.InfoText;
            button12.BackColor = System.Drawing.SystemColors.InfoText;
            button13.BackColor = System.Drawing.SystemColors.Info;
            button14.BackColor = System.Drawing.SystemColors.InfoText;
            button15.BackColor = System.Drawing.SystemColors.InfoText;
            button16.BackColor = System.Drawing.SystemColors.Info;
            hamle = 0;
            textBox1.Text = hamle.ToString();
            bitti = false;
            getRekor();
            textBox2.Text = rekor.ToString();
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utku Caner ATASEVER tarafından hazırlanmıştır.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cikis == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
