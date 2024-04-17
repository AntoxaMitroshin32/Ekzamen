using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компания_ЖизньФарм
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void вернутьсяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void add_click_Click(object sender, EventArgs e)
        {

        }

        private void delete_click_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эти записи?", "Удаление записей", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void redactor_click_Click(object sender, EventArgs e)
        {

        }
    }
}
