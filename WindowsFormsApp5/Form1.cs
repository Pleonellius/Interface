using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
       
        interface mizp
        {
            void delete_zapis();
            void prosmotr_Zapisi();
        }
        interface regist
        {
            void zapiss(string ima, string data, string vrema, string nomer, string imavrah, string nomervrah);
            void izmZapis();
            void pechatKart(string ima, string data, string vrema, string nomer, string imavrah, string nomervrah);

        }
        class zapis : regist
        {
            public void pechatKart(string ima, string data, string vrema, string nomer, string imavrah, string nomervrah)
            {
                MessageBox.Show($"Вы {ima} {nomer}, записались на {data} {vrema} к {imavrah} {nomervrah}");
            }
            public void izmZapis()
            {

            }
            public void zapiss(string ima, string data, string vrema, string nomer, string imavrah,string nomervrah)
            {
               
                MessageBox.Show($"Вы {ima} {nomer}, записались на {data} {vrema} к {imavrah} {nomervrah}");
            }
        }
        class moizapisi : mizp
        {
            public void prosmotr_Zapisi()
            {

            }
            public void delete_zapis()
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = textBox6.Text;
            if (comboBox1.SelectedItem == "Иван Владимирович")
            {
                name= "86664636346";
            }
        }
    }
}
