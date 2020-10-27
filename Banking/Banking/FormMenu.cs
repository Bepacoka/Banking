using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Banking
{
    public partial class FormMenu : Form
    {
        public string bank;
        public string balance_sber, balance_vtb, balance_vabank;
        protected override void WndProc(ref Message m)                                                                      //перенос окна border-style: none
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }

            base.WndProc(ref m);
        }
        string[] lines = new string[3];

        private string generateBankAccount()                                                                                //создаёт рандомный 12-значный номер (не используется)
        {
            Random rnd = new Random();
            string account = "";
            for (int i = 0; i < 12; i++)
            {
                account += Convert.ToString(rnd.Next(10));
            }
            return account;
        }
        
        public FormMenu()                                                                                                   //конструктор
        {
            InitializeComponent();
            File.AppendText("C://Users//11//Documents//data.txt").Close();
            string[] lines = new string[3];
            comboBox1.SelectedIndex = 0;                                                                                    //выбираем по умолчанию "Сбербанк"
            
            try
            {
                lines = File.ReadAllLines("C://Users//11//Documents//data.txt");                                             //загружаем информацию из файлов
                balance_sber = lines[0].Split(' ')[2];
                balance_vtb = lines[1].Split(' ')[2];
                balance_vabank = lines[2].Split(' ')[2];
            }
            catch
            {
                string[] l = new string[3];
                l[0] = generateBankAccount() + " " + "tempUserName" + " 0";
                l[1] = generateBankAccount() + " " + "tempUserName" + " 0";
                l[2] = generateBankAccount() + " " + "tempUserName" + " 0";
                File.WriteAllLines("C://Users//11//Documents//data.txt", l);
            }
            #region Sberbank Account Info                                                                                  
            string[] sber_info = lines[0].Split(' ');
            label_nickname_sberbank.Text = sber_info[1];
            label_balance_sberbank.Text = sber_info[2];
            label_bankAccount_sberbank.Text = sber_info[0];
            #endregion
            #region VTB Account Info
            string[] vtb_info = lines[1].Split(' ');
            label_nickname_vtb.Text = vtb_info[1];
            label_balance_vtb.Text = vtb_info[2];
            label_bankAccount_vtb.Text = vtb_info[0];
            #endregion
            #region Va-Bank Account Info
            string[] vabank_info = lines[2].Split(' ');
            label_nickname_vabank.Text = vabank_info[1];
            label_balance_vabank.Text = vabank_info[2];
            label_bankAccount_vabank.Text = vabank_info[0];
            #endregion
                                                                                                                            //получаем информацию о банковских аккаунтах из текстового файла
        }                                                                                                

        private void button_settings_Click(object sender, EventArgs e)                                                      //нажатие на кнопку "Настройки" (не работает от слова совсем)
        {
            FormSetting settings = new FormSetting();                                                                       //создаём форму настроек
            settings.Show();                                                                                                //показываем эту форму
            this.Hide();                                                                                                    //прячем старую
        }

        private void Exit(object sender, EventArgs e)                                                                       //выход из приложения
        {
            Application.Exit();
        }                                                             

        private void bankAccountSelected(object sender, EventArgs e)                                                        //когда поменялся текст комбобокса => меняем аккаунт банка
        {
            switch (comboBox1.Text)
            {
                case "Сбербанк":
                    bank = "Сбербанк";
                    balance_sber = label_balance_sberbank.Text;
                    label_balance_sberbank.Visible = true;
                    label_balance_vtb.Visible = false;
                    label_balance_vabank.Visible = false;

                    label_nickname_sberbank.Visible = true;
                    label_nickname_vtb.Visible = false;
                    label_nickname_vabank.Visible = false;

                    label_bankAccount_sberbank.Visible = true;
                    label_bankAccount_vtb.Visible = false;
                    label_bankAccount_vabank.Visible = false;
                    break;
                case "ВТБ":
                    bank = "ВТБ";
                    balance_vtb = label_balance_vtb.Text;
                    label_balance_sberbank.Visible = false;
                    label_balance_vtb.Visible = true;
                    label_balance_vabank.Visible = false;

                    label_nickname_sberbank.Visible = false;
                    label_nickname_vtb.Visible = true;
                    label_nickname_vabank.Visible = false;

                    label_bankAccount_sberbank.Visible = false;
                    label_bankAccount_vtb.Visible = true;
                    label_bankAccount_vabank.Visible = false;
                    break;
                case "Ва-банк":
                    bank = "Ва-банк";
                    balance_vabank = label_balance_vabank.Text;
                    label_balance_sberbank.Visible = false;
                    label_balance_vtb.Visible = false;
                    label_balance_vabank.Visible = true;

                    label_nickname_sberbank.Visible = false;
                    label_nickname_vtb.Visible = false;
                    label_nickname_vabank.Visible = true;

                    label_bankAccount_sberbank.Visible = false;
                    label_bankAccount_vtb.Visible = false;
                    label_bankAccount_vabank.Visible = true;
                    break;
            }
           // MessageBox.Show(bank);
        }

        private void button_history_Click(object sender, EventArgs e)                                                       //нажатие на кнопку "История"
        {
            FormHistory history = new FormHistory();
            history.Show();
        }

        private void button_topupbalance_Click(object sender, EventArgs e)                                                  //нажатие на кнопку "Пополнить баланс"
        {
            FormToptobalance balance = new FormToptobalance();
            balance.Show();
        }

        private void button_transfer_Click(object sender, EventArgs e)                                                      //нажатие на кнопку "Перевести на другой счёт"
        {
            FormTransfer transfer = new FormTransfer();
            transfer.Show();
        }
    }
}
