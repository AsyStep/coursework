namespace Курсовая.forms
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCreateWorkShop = new System.Windows.Forms.Panel();
            this.panelAddWorkshop = new System.Windows.Forms.Panel();
            this.panelDeleteWorkshop = new System.Windows.Forms.Panel();
            this.panelChangeWorkshop = new System.Windows.Forms.Panel();
            this.delete_auditory = new System.Windows.Forms.ComboBox();
            this.delete_auditory_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.add_auditory_btn = new System.Windows.Forms.Button();
            this.add_auditory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_user = new System.Windows.Forms.Button();
            this.selected_user = new System.Windows.Forms.ComboBox();
            this.panelDeleteUser = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.panelCreateWorkShop.SuspendLayout();
            this.panelDeleteWorkshop.SuspendLayout();
            this.panelChangeWorkshop.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDeleteUser.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateWorkShop
            // 
            this.panelCreateWorkShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panelCreateWorkShop.Controls.Add(this.panelAddWorkshop);
            this.panelCreateWorkShop.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCreateWorkShop.Location = new System.Drawing.Point(0, 0);
            this.panelCreateWorkShop.Name = "panelCreateWorkShop";
            this.panelCreateWorkShop.Size = new System.Drawing.Size(450, 815);
            this.panelCreateWorkShop.TabIndex = 0;
            // 
            // panelAddWorkshop
            // 
            this.panelAddWorkshop.BackColor = System.Drawing.Color.White;
            this.panelAddWorkshop.Location = new System.Drawing.Point(75, 96);
            this.panelAddWorkshop.Name = "panelAddWorkshop";
            this.panelAddWorkshop.Size = new System.Drawing.Size(300, 660);
            this.panelAddWorkshop.TabIndex = 2;
            // 
            // panelDeleteWorkshop
            // 
            this.panelDeleteWorkshop.Controls.Add(this.panelChangeWorkshop);
            this.panelDeleteWorkshop.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDeleteWorkshop.Location = new System.Drawing.Point(450, 0);
            this.panelDeleteWorkshop.Name = "panelDeleteWorkshop";
            this.panelDeleteWorkshop.Size = new System.Drawing.Size(450, 815);
            this.panelDeleteWorkshop.TabIndex = 1;
            // 
            // panelChangeWorkshop
            // 
            this.panelChangeWorkshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panelChangeWorkshop.Controls.Add(this.delete_auditory);
            this.panelChangeWorkshop.Controls.Add(this.delete_auditory_btn);
            this.panelChangeWorkshop.Controls.Add(this.label6);
            this.panelChangeWorkshop.Controls.Add(this.add_auditory_btn);
            this.panelChangeWorkshop.Controls.Add(this.add_auditory);
            this.panelChangeWorkshop.Controls.Add(this.label5);
            this.panelChangeWorkshop.Location = new System.Drawing.Point(76, 96);
            this.panelChangeWorkshop.Name = "panelChangeWorkshop";
            this.panelChangeWorkshop.Size = new System.Drawing.Size(300, 660);
            this.panelChangeWorkshop.TabIndex = 3;
            // 
            // delete_auditory
            // 
            this.delete_auditory.BackColor = System.Drawing.Color.White;
            this.delete_auditory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delete_auditory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_auditory.FormattingEnabled = true;
            this.delete_auditory.Location = new System.Drawing.Point(36, 478);
            this.delete_auditory.Margin = new System.Windows.Forms.Padding(0);
            this.delete_auditory.Name = "delete_auditory";
            this.delete_auditory.Size = new System.Drawing.Size(231, 24);
            this.delete_auditory.TabIndex = 13;
            // 
            // delete_auditory_btn
            // 
            this.delete_auditory_btn.Location = new System.Drawing.Point(36, 539);
            this.delete_auditory_btn.Name = "delete_auditory_btn";
            this.delete_auditory_btn.Size = new System.Drawing.Size(231, 32);
            this.delete_auditory_btn.TabIndex = 12;
            this.delete_auditory_btn.Text = "Удалить";
            this.delete_auditory_btn.UseVisualStyleBackColor = true;
            this.delete_auditory_btn.Click += new System.EventHandler(this.delete_auditory_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(50, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Удалить аудиторию";
            // 
            // add_auditory_btn
            // 
            this.add_auditory_btn.Location = new System.Drawing.Point(36, 137);
            this.add_auditory_btn.Name = "add_auditory_btn";
            this.add_auditory_btn.Size = new System.Drawing.Size(231, 32);
            this.add_auditory_btn.TabIndex = 9;
            this.add_auditory_btn.Text = "Добавить ";
            this.add_auditory_btn.UseVisualStyleBackColor = true;
            this.add_auditory_btn.Click += new System.EventHandler(this.add_aditory_Click);
            // 
            // add_auditory
            // 
            this.add_auditory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_auditory.Location = new System.Drawing.Point(36, 81);
            this.add_auditory.Name = "add_auditory";
            this.add_auditory.Size = new System.Drawing.Size(231, 25);
            this.add_auditory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Добавить аудиторию";
            // 
            // panelAddUser
            // 
            this.panelAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panelAddUser.Controls.Add(this.panel3);
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddUser.Location = new System.Drawing.Point(900, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(475, 407);
            this.panelAddUser.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.delete_user);
            this.panel3.Controls.Add(this.selected_user);
            this.panel3.Location = new System.Drawing.Point(92, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 200);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Удалить пользователя";
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(36, 137);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(231, 32);
            this.delete_user.TabIndex = 2;
            this.delete_user.Text = "Удалить";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // selected_user
            // 
            this.selected_user.BackColor = System.Drawing.Color.White;
            this.selected_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selected_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selected_user.FormattingEnabled = true;
            this.selected_user.Location = new System.Drawing.Point(36, 84);
            this.selected_user.Margin = new System.Windows.Forms.Padding(0);
            this.selected_user.Name = "selected_user";
            this.selected_user.Size = new System.Drawing.Size(231, 24);
            this.selected_user.TabIndex = 1;
            // 
            // panelDeleteUser
            // 
            this.panelDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panelDeleteUser.Controls.Add(this.panel4);
            this.panelDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeleteUser.Location = new System.Drawing.Point(900, 407);
            this.panelDeleteUser.Name = "panelDeleteUser";
            this.panelDeleteUser.Size = new System.Drawing.Size(475, 408);
            this.panelDeleteUser.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.login);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.add_user);
            this.panel4.Location = new System.Drawing.Point(92, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 263);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин:";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(36, 159);
            this.password.MaxLength = 15;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(231, 25);
            this.password.TabIndex = 8;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(36, 102);
            this.login.MaxLength = 15;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(231, 25);
            this.login.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавить пользователя";
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(36, 211);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(231, 32);
            this.add_user.TabIndex = 5;
            this.add_user.Text = "Добавить";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 815);
            this.Controls.Add(this.panelDeleteUser);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.panelDeleteWorkshop);
            this.Controls.Add(this.panelCreateWorkShop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panelCreateWorkShop.ResumeLayout(false);
            this.panelDeleteWorkshop.ResumeLayout(false);
            this.panelChangeWorkshop.ResumeLayout(false);
            this.panelChangeWorkshop.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDeleteUser.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateWorkShop;
        private System.Windows.Forms.Panel panelDeleteWorkshop;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Panel panelDeleteUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.ComboBox selected_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Panel panelAddWorkshop;
        private System.Windows.Forms.Panel panelChangeWorkshop;
        private System.Windows.Forms.Button add_auditory_btn;
        private System.Windows.Forms.TextBox add_auditory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox delete_auditory;
        private System.Windows.Forms.Button delete_auditory_btn;
        private System.Windows.Forms.Label label6;
    }
}