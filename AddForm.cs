using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment3._4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            comboClass.DataSource = Enum.GetValues(typeof(Classes));
        }

        private void txtSid_Validating(object sender, CancelEventArgs e)
        {
            if (txtSid.TextLength != 0) // data is entered
            {
                int val;
                if (!int.TryParse(txtSid.Text, out val))
                {
                    MessageBox.Show("Please enter numbers only");
                    e.Cancel = true;// keeps focus on same text box
                    txtSid.Clear();
                }
                else if (int.Parse(txtSid.Text) <= 0)
                {
                    MessageBox.Show("Enter non negative number");
                    e.Cancel = true;
                    txtSid.Clear();
                }


            }
        }

        private void txtTution_Validating(object sender, CancelEventArgs e)
        {
            if (txtTuition.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtTuition.Text, out val))
                {
                    MessageBox.Show("Please enter numbers only!!");
                    e.Cancel = true;
                    txtTuition.Clear();
                }
            }

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtSid.Text != string.Empty && txtName.Text != string.Empty)
            {
                var newEmp = new Student();
                newEmp.StudentID = int.Parse(txtSid.Text);
                newEmp.Name = txtName.Text;
                newEmp.Tuition = double.Parse(txtTuition.Text);
                newEmp.Classes = (Classes)(comboClass.SelectedIndex + 1);
                Data.Students.Add(newEmp);
                MessageBox.Show("Record added!");
            }
        }
    }
}

