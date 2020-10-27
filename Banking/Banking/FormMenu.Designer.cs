namespace Banking
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button_transfer = new System.Windows.Forms.Button();
            this.button_topupbalance = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_history = new System.Windows.Forms.Button();
            this.picturebox_user = new System.Windows.Forms.PictureBox();
            this.hr = new System.Windows.Forms.Panel();
            this.label_nickname_sberbank = new System.Windows.Forms.Label();
            this.vr = new System.Windows.Forms.Panel();
            this.label_balance_sberbank = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_bankAccount_sberbank = new System.Windows.Forms.Label();
            this.label_nickname_vtb = new System.Windows.Forms.Label();
            this.label_nickname_vabank = new System.Windows.Forms.Label();
            this.label_bankAccount_vtb = new System.Windows.Forms.Label();
            this.label_bankAccount_vabank = new System.Windows.Forms.Label();
            this.label_balance_vtb = new System.Windows.Forms.Label();
            this.label_balance_vabank = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // button_transfer
            // 
            this.button_transfer.BackColor = System.Drawing.Color.Transparent;
            this.button_transfer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_transfer.FlatAppearance.BorderSize = 3;
            this.button_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_transfer.ForeColor = System.Drawing.Color.White;
            this.button_transfer.Location = new System.Drawing.Point(56, 132);
            this.button_transfer.Name = "button_transfer";
            this.button_transfer.Size = new System.Drawing.Size(159, 69);
            this.button_transfer.TabIndex = 0;
            this.button_transfer.Text = "Перевод на другой счёт";
            this.button_transfer.UseVisualStyleBackColor = false;
            this.button_transfer.Click += new System.EventHandler(this.button_transfer_Click);
            // 
            // button_topupbalance
            // 
            this.button_topupbalance.BackColor = System.Drawing.Color.Transparent;
            this.button_topupbalance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_topupbalance.FlatAppearance.BorderSize = 3;
            this.button_topupbalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_topupbalance.ForeColor = System.Drawing.Color.White;
            this.button_topupbalance.Location = new System.Drawing.Point(546, 132);
            this.button_topupbalance.Name = "button_topupbalance";
            this.button_topupbalance.Size = new System.Drawing.Size(159, 69);
            this.button_topupbalance.TabIndex = 0;
            this.button_topupbalance.Text = "Пополнить баланс";
            this.button_topupbalance.UseVisualStyleBackColor = false;
            this.button_topupbalance.Click += new System.EventHandler(this.button_topupbalance_Click);
            // 
            // button_settings
            // 
            this.button_settings.Enabled = false;
            this.button_settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_settings.FlatAppearance.BorderSize = 3;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(546, 285);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(159, 69);
            this.button_settings.TabIndex = 0;
            this.button_settings.Text = "Настройки";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_history
            // 
            this.button_history.BackColor = System.Drawing.Color.Transparent;
            this.button_history.Enabled = false;
            this.button_history.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_history.FlatAppearance.BorderSize = 3;
            this.button_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_history.ForeColor = System.Drawing.Color.White;
            this.button_history.Location = new System.Drawing.Point(56, 285);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(159, 69);
            this.button_history.TabIndex = 0;
            this.button_history.Text = "История переводов";
            this.button_history.UseVisualStyleBackColor = false;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // picturebox_user
            // 
            this.picturebox_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturebox_user.BackgroundImage")));
            this.picturebox_user.Location = new System.Drawing.Point(13, 13);
            this.picturebox_user.Name = "picturebox_user";
            this.picturebox_user.Size = new System.Drawing.Size(30, 30);
            this.picturebox_user.TabIndex = 1;
            this.picturebox_user.TabStop = false;
            // 
            // hr
            // 
            this.hr.BackColor = System.Drawing.Color.White;
            this.hr.ForeColor = System.Drawing.Color.White;
            this.hr.Location = new System.Drawing.Point(0, 69);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(800, 1);
            this.hr.TabIndex = 2;
            // 
            // label_nickname_sberbank
            // 
            this.label_nickname_sberbank.AutoSize = true;
            this.label_nickname_sberbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label_nickname_sberbank.ForeColor = System.Drawing.Color.White;
            this.label_nickname_sberbank.Location = new System.Drawing.Point(51, 14);
            this.label_nickname_sberbank.Name = "label_nickname_sberbank";
            this.label_nickname_sberbank.Size = new System.Drawing.Size(232, 29);
            this.label_nickname_sberbank.TabIndex = 3;
            this.label_nickname_sberbank.Text = "Имя пользователя";
            // 
            // vr
            // 
            this.vr.BackColor = System.Drawing.Color.White;
            this.vr.ForeColor = System.Drawing.Color.White;
            this.vr.Location = new System.Drawing.Point(489, 0);
            this.vr.Name = "vr";
            this.vr.Size = new System.Drawing.Size(1, 70);
            this.vr.TabIndex = 4;
            // 
            // label_balance_sberbank
            // 
            this.label_balance_sberbank.AutoSize = true;
            this.label_balance_sberbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label_balance_sberbank.ForeColor = System.Drawing.Color.White;
            this.label_balance_sberbank.Location = new System.Drawing.Point(578, 14);
            this.label_balance_sberbank.Name = "label_balance_sberbank";
            this.label_balance_sberbank.Size = new System.Drawing.Size(27, 29);
            this.label_balance_sberbank.TabIndex = 5;
            this.label_balance_sberbank.Text = "0";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(13, 429);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(20, 20);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Exit);
            // 
            // label_bankAccount_sberbank
            // 
            this.label_bankAccount_sberbank.AutoSize = true;
            this.label_bankAccount_sberbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bankAccount_sberbank.ForeColor = System.Drawing.Color.White;
            this.label_bankAccount_sberbank.Location = new System.Drawing.Point(52, 43);
            this.label_bankAccount_sberbank.Name = "label_bankAccount_sberbank";
            this.label_bankAccount_sberbank.Size = new System.Drawing.Size(117, 20);
            this.label_bankAccount_sberbank.TabIndex = 7;
            this.label_bankAccount_sberbank.Text = "123456789012";
            // 
            // label_nickname_vtb
            // 
            this.label_nickname_vtb.AutoSize = true;
            this.label_nickname_vtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label_nickname_vtb.ForeColor = System.Drawing.Color.White;
            this.label_nickname_vtb.Location = new System.Drawing.Point(51, 14);
            this.label_nickname_vtb.Name = "label_nickname_vtb";
            this.label_nickname_vtb.Size = new System.Drawing.Size(232, 29);
            this.label_nickname_vtb.TabIndex = 8;
            this.label_nickname_vtb.Text = "Имя пользователя";
            this.label_nickname_vtb.Visible = false;
            // 
            // label_nickname_vabank
            // 
            this.label_nickname_vabank.AutoSize = true;
            this.label_nickname_vabank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label_nickname_vabank.ForeColor = System.Drawing.Color.White;
            this.label_nickname_vabank.Location = new System.Drawing.Point(51, 14);
            this.label_nickname_vabank.Name = "label_nickname_vabank";
            this.label_nickname_vabank.Size = new System.Drawing.Size(232, 29);
            this.label_nickname_vabank.TabIndex = 9;
            this.label_nickname_vabank.Text = "Имя пользователя";
            this.label_nickname_vabank.Visible = false;
            // 
            // label_bankAccount_vtb
            // 
            this.label_bankAccount_vtb.AutoSize = true;
            this.label_bankAccount_vtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bankAccount_vtb.ForeColor = System.Drawing.Color.White;
            this.label_bankAccount_vtb.Location = new System.Drawing.Point(52, 43);
            this.label_bankAccount_vtb.Name = "label_bankAccount_vtb";
            this.label_bankAccount_vtb.Size = new System.Drawing.Size(117, 20);
            this.label_bankAccount_vtb.TabIndex = 10;
            this.label_bankAccount_vtb.Text = "123456789012";
            this.label_bankAccount_vtb.Visible = false;
            // 
            // label_bankAccount_vabank
            // 
            this.label_bankAccount_vabank.AutoSize = true;
            this.label_bankAccount_vabank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bankAccount_vabank.ForeColor = System.Drawing.Color.White;
            this.label_bankAccount_vabank.Location = new System.Drawing.Point(52, 43);
            this.label_bankAccount_vabank.Name = "label_bankAccount_vabank";
            this.label_bankAccount_vabank.Size = new System.Drawing.Size(117, 20);
            this.label_bankAccount_vabank.TabIndex = 11;
            this.label_bankAccount_vabank.Text = "123456789012";
            this.label_bankAccount_vabank.Visible = false;
            // 
            // label_balance_vtb
            // 
            this.label_balance_vtb.AutoSize = true;
            this.label_balance_vtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label_balance_vtb.ForeColor = System.Drawing.Color.White;
            this.label_balance_vtb.Location = new System.Drawing.Point(578, 14);
            this.label_balance_vtb.Name = "label_balance_vtb";
            this.label_balance_vtb.Size = new System.Drawing.Size(27, 29);
            this.label_balance_vtb.TabIndex = 5;
            this.label_balance_vtb.Text = "0";
            this.label_balance_vtb.Visible = false;
            // 
            // label_balance_vabank
            // 
            this.label_balance_vabank.AutoSize = true;
            this.label_balance_vabank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label_balance_vabank.ForeColor = System.Drawing.Color.White;
            this.label_balance_vabank.Location = new System.Drawing.Point(578, 15);
            this.label_balance_vabank.Name = "label_balance_vabank";
            this.label_balance_vabank.Size = new System.Drawing.Size(27, 29);
            this.label_balance_vabank.TabIndex = 5;
            this.label_balance_vabank.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сбербанк",
            "ВТБ",
            "Ва-банк"});
            this.comboBox1.Location = new System.Drawing.Point(651, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.TextChanged += new System.EventHandler(this.bankAccountSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(496, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Счёт:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_balance_vabank);
            this.Controls.Add(this.label_balance_vtb);
            this.Controls.Add(this.label_bankAccount_vabank);
            this.Controls.Add(this.label_bankAccount_vtb);
            this.Controls.Add(this.label_nickname_vabank);
            this.Controls.Add(this.label_nickname_vtb);
            this.Controls.Add(this.label_bankAccount_sberbank);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_balance_sberbank);
            this.Controls.Add(this.vr);
            this.Controls.Add(this.label_nickname_sberbank);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.picturebox_user);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_topupbalance);
            this.Controls.Add(this.button_transfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Huduko";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_transfer;
        private System.Windows.Forms.Button button_topupbalance;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.PictureBox picturebox_user;
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.Label label_nickname_sberbank;
        private System.Windows.Forms.Panel vr;
        private System.Windows.Forms.Label label_balance_sberbank;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_bankAccount_sberbank;
        private System.Windows.Forms.Label label_nickname_vtb;
        private System.Windows.Forms.Label label_nickname_vabank;
        private System.Windows.Forms.Label label_bankAccount_vtb;
        private System.Windows.Forms.Label label_bankAccount_vabank;
        private System.Windows.Forms.Label label_balance_vtb;
        private System.Windows.Forms.Label label_balance_vabank;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

