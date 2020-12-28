using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harf_Kombinasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 4 Harfli com
        private void button1_Click(object sender, EventArgs e)
        {
            string[] harfler = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z" };
            

            StreamWriter yazici = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "domains.txt"));

            if (txt_Uzanti.Text != "")
            {
                for (int a = 0; a <= harfler.Length - 1; a++)
                {
                    for (int b = 0; b <= harfler.Length - 1; b++)
                    {
                        for (int c = 0; c <= harfler.Length - 1; c++)
                        {
                            for (int d = 0; d <= harfler.Length - 1; d++)
                            {
                                yazici.WriteLine(harfler[a] + harfler[b] + harfler[c] + harfler[d] + txt_Uzanti.Text);
                            }
                        }
                    }
                }
            }
            else
            {
                for (int a = 0; a <= harfler.Length - 1; a++)
                {
                    for (int b = 0; b <= harfler.Length - 1; b++)
                    {
                        for (int c = 0; c <= harfler.Length - 1; c++)
                        {
                            for (int d = 0; d <= harfler.Length - 1; d++)
                            {
                                yazici.WriteLine(harfler[a] + harfler[b] + harfler[c] + harfler[d]);
                            }
                        }
                    }
                }
            }
            yazici.Close();
            MessageBox.Show("Dosya Masaüstüne Başarıyla Kayıt Edildi.");
        }

        //5 Harfli COM
        private void button3_Click(object sender, EventArgs e)
        {
            string[] harfler = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z" };

            StreamWriter yazici = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "domains.txt"));

            if (txt_Uzanti.Text != "")
            {
                for (int a = 0; a <= harfler.Length - 1; a++)
                {
                    for (int b = 0; b <= harfler.Length - 1; b++)
                    {
                        for (int c = 0; c <= harfler.Length - 1; c++)
                        {
                            for (int d = 0; d <= harfler.Length - 1; d++)
                            {
                                for (int f = 0; f <= harfler.Length - 1; f++)
                                {
                                    yazici.WriteLine(harfler[a] + harfler[b] + harfler[c] + harfler[d] + harfler[f] + txt_Uzanti.Text);
                                }
                            }
                        }
                    }

                }
            }
            else {
                for (int a = 0; a <= harfler.Length - 1; a++)
                {
                    for (int b = 0; b <= harfler.Length - 1; b++)
                    {
                        for (int c = 0; c <= harfler.Length - 1; c++)
                        {
                            for (int d = 0; d <= harfler.Length - 1; d++)
                            {
                                for (int f = 0; f <= harfler.Length - 1; f++)
                                {
                                    yazici.WriteLine(harfler[a] + harfler[b] + harfler[c] + harfler[d] + harfler[f]);
                                }
                            }
                        }
                    }

                }
            }
            yazici.Close();
            MessageBox.Show("Dosya Masaüstüne Başarıyla Kayıt Edildi.");
        }

        // 3 Harfli COM
        private void button5_Click(object sender, EventArgs e)
        {
            string[] harfler = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z" };

            StreamWriter yazici = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "domains.txt"));

            if (txt_Uzanti.Text != "")
            {
                for (int a = 0; a <= harfler.Length - 1; a++)
                {
                    for (int b = 0; b <= harfler.Length - 1; b++)
                    {
                        for (int c = 0; c <= harfler.Length - 1; c++)
                        {
                            yazici.WriteLine(harfler[a] + harfler[b] + harfler[c] + txt_Uzanti.Text);
                        }
                    }

                }
            }
            else
            {
                for (int a = 0; a <= harfler.Length - 1; a++)
                {
                    for (int b = 0; b <= harfler.Length - 1; b++)
                    {
                        for (int c = 0; c <= harfler.Length - 1; c++)
                        {
                            yazici.WriteLine(harfler[a] + harfler[b] + harfler[c]);
                        }
                    }

                }
            }
            yazici.Close();
            MessageBox.Show("Dosya Masaüstüne Başarıyla Kayıt Edildi.");
        }
    }
}
