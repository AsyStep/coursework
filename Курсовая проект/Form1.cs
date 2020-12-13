using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.bib;
using Курсовая.forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        #region user_var

        public Form activeForm = null;
        public bool load_preferences;

        #endregion

        #region user_function


        //отрытие дочерней формы в основной панели
        public void open_child_form(Form childForm)
        {
            hide_sub();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //

        // скрыть суб меню
        private void hide_sub()
        {
            if (panelSubWorkshop.Visible == true)
                panelSubWorkshop.Visible = false;
        }

        // открыть суб меню 
        private void show_sub(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hide_sub();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }

        // перемещение формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public async Task load_cb()
        {
            if (load_preferences)
            {
                db.load_combo_box(selected_auditory_cb);
            }
        }

        #endregion

        #region form_function

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            hide_sub();
            load_preferences = await db.load_db_preferences(this);
            await load_cb();
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            open_child_form(new search());
        }

        private void iconButtonWorkshop_Click(object sender, EventArgs e)
        {
            show_sub(panelSubWorkshop);

        }

        private void iconButtonAdmin_Click(object sender, EventArgs e)
        {
            open_child_form(new authorization());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hide_sub();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            open_child_form(new workshop(selected_auditory_cb.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
