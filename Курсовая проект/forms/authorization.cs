﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.bib;

namespace Курсовая.forms
{
    public partial class authorization : Form
    {
        #region form function
        public authorization()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await db.authorization(login.Text, password.Text);
        }
        #endregion
    }
}
