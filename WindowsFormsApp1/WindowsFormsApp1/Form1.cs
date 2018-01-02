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
        private string enc = "";
        string asci = "ABCDEFGHIJKLMNOPQRSTUVWXYZ АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ.,abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+|`1234567890-=/абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string Decode1(string TxtIn, string Key)
        {
            string outtext = "";
            for(int i=0; ;i++)
            {

            }
            return outtext;
        }
        public string Encode1(string TxtIn, string Key)
        {
            string outtext = "";
            int j = 0,k = 0;
            for(j=0; j<Key.Length;j++)              //Заполнение массива
            {
                if (enc.IndexOf(Key[j]) == -1)
                {
                    enc += Key[j];
                }
            }

            while (k < asci.Length)
            {
                if (enc.IndexOf(asci[k]) == -1)
                {
                    enc += asci[k];
                }
                k++;
            }
            richTextBox1.AppendText(enc);
            for(int i=0;i<TxtIn.Length; i++)
            {
               int x = Convert.ToByte(TxtIn[i]);
                outtext += enc[x];

            }
            richTextBox1.AppendText(" ");
            return outtext;
            /*
             Самый простой конвертер на основе ASCII кодов.Каждому символу соотв.ascii код -функция преобразования Char To Byte. То есть символ можно перевести в число
             1.Сформировать таблицу для перекодирования
             Это массив, который надо заполнить.
             Можно сначала заполнить элементами ключа - по одному символу, а потом оставшимися символами.При этом надо каждый раз смотреть, чтобы не было повторов
             самое главное, чтобы символы в таблице перекодировки были все разные, иначе обратно дешифровать не получится
             2.Сохранить куда - нить этот массив для расшифровки
             3.Берем по одному символу из Входящей строки(например английское "а") преобразуем его в число = ascii код(будет 65)
             4.Берем соответствующий элемент из таблицы перекодировки(65 элемент массива) и записываем его в выходную строчку
             5.так делаем с каждым символом из txtin
             */
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------//
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            KeyToEncode = textBox1.Text;                            // берем ключ из текстбокса 1
            string Textin = textBox2.Text;                          // а текст для зашифровки из текстбокса 2
            if (KeyToEncode == "")
            {                                // если ключ пустой, то выдать ошибку
                label5.Text = "Error: Key should not be empty";
                return;                                             // и выйти из процедуры
            }
            if (Textin == "")
            {                                                       // если строка для шифрования пустая, то выдать ошибку
                label5.Text = "Error: Text to encode should not be empty";
                return;                                             // и выйти из процедуры
            }
            label5.Text = "";                                       // стираем ошибки
            textBox3.Text = Encode1(Textin, KeyToEncode);            // вызываем конвертер
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
