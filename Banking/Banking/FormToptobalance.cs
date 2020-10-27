using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class FormToptobalance : Form
    {
        public FormToptobalance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = new string[3];
            lines = File.ReadAllLines("C://Users//11//Documents//data.txt");
            string balance_sber = lines[0].Split(' ')[2];
            string balance_vtb = lines[1].Split(' ')[2];
            string balance_vabank = lines[2].Split(' ')[2];
            var menu = Application.OpenForms.OfType<FormMenu>().Single();
            // MessageBox.Show(balance_sber + " " + balance_vtb + " " + balance_vabank + " " + menu.bank + " " + menu.balance_sber + " " + menu.balance_vtb + " " + menu.balance_vabank, "Debug");
            switch (menu.bank)
            {
                case "Сбербанк":
                    menu.balance_sber = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(menu.balance_sber));
                    balance_sber = menu.balance_sber;
                    lines[0] = lines[0].Split(' ')[0] + " " + lines[0].Split(' ')[1] + " " + balance_sber;
                    break;
                case "ВТБ":
                    menu.balance_vtb = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(menu.balance_vtb));
                    balance_vtb = menu.balance_vtb;
                    lines[1] = lines[1].Split(' ')[0] + " " + lines[1].Split(' ')[1] + " " + balance_vtb;
                    break;
                case "Ва-банк":
                    menu.balance_vabank = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(menu.balance_vabank));
                    balance_vabank = menu.balance_vabank;
                    lines[2] = lines[2].Split(' ')[0] + " " + lines[2].Split(' ')[1] + " " + balance_vabank;
                    break;
            }
            File.WriteAllLines("C://Users//11//Documents//data.txt", lines);
            this.Close();
        }
    }
}
