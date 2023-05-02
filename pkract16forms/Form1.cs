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

namespace pkract16forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string slovo = textBox1.Text.ToLower();
            int count = 0;
            using (StreamReader rd = new StreamReader("massiv.txt"))
            {            
                string line;
                while ((line = rd.ReadLine()) != null) 
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words) 
                    {
                        if (word.ToLower() == slovo)
                        {
                            count++;
                        }                       
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Слово не найдено", "Ошибка");
                    }
                        label5.Text = line;
                }
                rd.Close();
                label1.Text = $"Было найдены {count} вхождения (ий) поискового запроса \"{textBox1.Text}\"";
                label1.Visible = true;
                
            }
        }
    }
}
