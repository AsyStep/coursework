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
    public partial class search : Form
    {
        #region form_function

        public search()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await db.search(comboBox1.Text, textBox1.Text, dataGridView1);
        }

        private void search_Load(object sender, EventArgs e)
        {
            db.load_combo_box(comboBox1);
        }

        #endregion


    }
}
