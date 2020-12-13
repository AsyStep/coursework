namespace Курсовая
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonAdmin = new FontAwesome.Sharp.IconButton();
            this.panelSubWorkshop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.selected_auditory_cb = new System.Windows.Forms.ComboBox();
            this.iconButtonWorkshop = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubWorkshop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.iconButtonAdmin);
            this.panelMenu.Controls.Add(this.panelSubWorkshop);
            this.panelMenu.Controls.Add(this.iconButtonWorkshop);
            this.panelMenu.Controls.Add(this.iconButtonSearch);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 850);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonAdmin
            // 
            this.iconButtonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.iconButtonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdmin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAdmin.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdmin.IconSize = 48;
            this.iconButtonAdmin.Location = new System.Drawing.Point(0, 404);
            this.iconButtonAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdmin.Name = "iconButtonAdmin";
            this.iconButtonAdmin.Rotation = 0D;
            this.iconButtonAdmin.Size = new System.Drawing.Size(225, 40);
            this.iconButtonAdmin.TabIndex = 5;
            this.iconButtonAdmin.Text = "Администратор";
            this.iconButtonAdmin.UseVisualStyleBackColor = false;
            this.iconButtonAdmin.Click += new System.EventHandler(this.iconButtonAdmin_Click);
            // 
            // panelSubWorkshop
            // 
            this.panelSubWorkshop.Controls.Add(this.label1);
            this.panelSubWorkshop.Controls.Add(this.selected_auditory_cb);
            this.panelSubWorkshop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubWorkshop.Location = new System.Drawing.Point(0, 305);
            this.panelSubWorkshop.Name = "panelSubWorkshop";
            this.panelSubWorkshop.Size = new System.Drawing.Size(225, 99);
            this.panelSubWorkshop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите мастерскую:";
            // 
            // selected_auditory_cb
            // 
            this.selected_auditory_cb.BackColor = System.Drawing.Color.White;
            this.selected_auditory_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selected_auditory_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selected_auditory_cb.FormattingEnabled = true;
            this.selected_auditory_cb.Location = new System.Drawing.Point(4, 37);
            this.selected_auditory_cb.Margin = new System.Windows.Forms.Padding(0);
            this.selected_auditory_cb.Name = "selected_auditory_cb";
            this.selected_auditory_cb.Size = new System.Drawing.Size(215, 30);
            this.selected_auditory_cb.TabIndex = 0;
            this.selected_auditory_cb.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // iconButtonWorkshop
            // 
            this.iconButtonWorkshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.iconButtonWorkshop.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonWorkshop.FlatAppearance.BorderSize = 0;
            this.iconButtonWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWorkshop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonWorkshop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonWorkshop.IconColor = System.Drawing.Color.Black;
            this.iconButtonWorkshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWorkshop.IconSize = 48;
            this.iconButtonWorkshop.Location = new System.Drawing.Point(0, 265);
            this.iconButtonWorkshop.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonWorkshop.Name = "iconButtonWorkshop";
            this.iconButtonWorkshop.Rotation = 0D;
            this.iconButtonWorkshop.Size = new System.Drawing.Size(225, 40);
            this.iconButtonWorkshop.TabIndex = 3;
            this.iconButtonWorkshop.Text = "Мастерская";
            this.iconButtonWorkshop.UseVisualStyleBackColor = false;
            this.iconButtonWorkshop.Click += new System.EventHandler(this.iconButtonWorkshop_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.iconButtonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 48;
            this.iconButtonSearch.Location = new System.Drawing.Point(0, 225);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Rotation = 0D;
            this.iconButtonSearch.Size = new System.Drawing.Size(225, 40);
            this.iconButtonSearch.TabIndex = 1;
            this.iconButtonSearch.Text = "Поиск";
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 225);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 225;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(225, 225);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.button2);
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(225, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1375, 35);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1297, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1336, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(225, 35);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1375, 815);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubWorkshop.ResumeLayout(false);
            this.panelSubWorkshop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private FontAwesome.Sharp.IconButton iconButtonAdmin;
        private System.Windows.Forms.Panel panelSubWorkshop;
        private FontAwesome.Sharp.IconButton iconButtonWorkshop;
        public System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox selected_auditory_cb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

