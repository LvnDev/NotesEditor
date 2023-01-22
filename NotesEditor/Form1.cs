using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesEditor
{
    public partial class NotesEditor : Form
    {
        DataTable table;
        public NotesEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource= table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 478;
        }

        private void Main(object sender, EventArgs e)
        {
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            if(createTxtbox.Text==string.Empty)
            {
                createTxtbox.Text = "error";
            }
            else
            {
                txtEditor.Clear();
                createTxtbox.Clear();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete(); 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(createTxtbox.Text, txtEditor.Text);
            txtEditor.Clear();
            createTxtbox.Clear();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index > -1)
            {
                createTxtbox.Text = table.Rows[index].ItemArray[0].ToString();
                txtEditor.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void gitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/LvnDev/NotesEditor");
            Process.Start(sInfo);
        }
    }
}
