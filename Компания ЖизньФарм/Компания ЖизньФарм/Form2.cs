using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Компания_ЖизньФарм
{
    public partial class Form2 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-NL41FK7;Initial Catalog=BD_apteki;Integrated Security=True";
        string sql = "SELECT * FROM BD_apteki";
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_aptekiDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.bD_aptekiDataSet.Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);

                adapter.InsertCommand = commandBuilder.GetInsertCommand();

                adapter.Update(ds, "TovarTable"); // Замените "TableName" на имя вашей таблицы

                MessageBox.Show("Данные успешно добавлены!");
            }
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Tovar"); // Замените "TableName" на имя вашей таблицы

                MessageBox.Show("Данные успешно отредактированы!");
            }
        }

        private void вернутьсяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
