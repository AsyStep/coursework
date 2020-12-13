using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.bib;

namespace Курсовая.forms
{
    public partial class admin : Form
    {
        private Form1 mainform;

        #region form_function
        public admin(Form1 form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            db.load_combo_box(delete_auditory);
            db.load_combo_box_users(selected_user);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            bool result = await db.add_user(login.Text, password.Text, selected_user);
            if (result)
            {
                login.Clear();
                password.Clear();
            }
        }

        private async void add_aditory_Click(object sender, EventArgs e)
        {
            await db.add_auditory(add_auditory, delete_auditory);
            await mainform.load_cb();
        }

        private async void delete_user_Click(object sender, EventArgs e)
        {
            await db.delete_user(selected_user.Text, selected_user);
        }

        private async void delete_auditory_btn_Click(object sender, EventArgs e)
        {
            await db.delete_auditory(delete_auditory.Text, delete_auditory);
            await mainform.load_cb();
        }


        #endregion


    }
}
