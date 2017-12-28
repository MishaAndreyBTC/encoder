using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string KeyToEncode;
        

        public string Encode(string TxtIn, string Key)
        {
            return "Test text";
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            KeyToEncode = textBox1.Text;                            // берем ключ из текстбокса 1
            string Textin = textBox2.Text;                          // а текст для зашифровки из текстбокса 2
            if (KeyToEncode == "") {                                // если ключ пустой, то выдать ошибку
                label5.Text = "Error: Key should not be empty"; 
                return;                                             // и выйти из процедуры
                }
            if (Textin == "")
            {                                                       // если строка для шифрования пустая, то выдать ошибку
                label5.Text = "Error: Text to encode should not be empty";
                return;                                             // и выйти из процедуры
            }
            label5.Text = "";                                       // стираем ошибки
            textBox3.Text = Encode(Textin, KeyToEncode);            // вызываем конвертер
        }
    }
}
