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
    public partial class workshop : Form
    {
        private string selected_auditory;
        private bool load;

        #region form_function

        public workshop(string auditory)
        {
            InitializeComponent();
            selected_auditory = auditory;
        }

        private void workshop_Load(object sender, EventArgs e)
        {
        }

        private async void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            load = false;
            string category = "";
            if (comboBox1.Text == "Методическое обеспечение")
                category = db.categories[0];
            else if (comboBox1.Text == "Техническое обеспечение")
                category = db.categories[1];
            else if (comboBox1.Text == "Мебель")
                category = db.categories[2];

            load = await db.load_table(category, dataGridView1);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (load)
                await db.save_changed();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (load)
                await db.delete_changed(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
