using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3._4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stuGrid.DataSource = Data.Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete??", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Students.RemoveAt(stuGrid.CurrentRow.Index);
                stuGrid.DataSource = null;
                stuGrid.DataSource = Data.Students;


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();


        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            stuGrid.DataSource = null;
            stuGrid.DataSource = Data.Students;
        }

        private void stuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}