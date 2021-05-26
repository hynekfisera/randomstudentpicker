using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPicker
{
    public partial class Form1 : Form
    {
        List<Student> _students = new List<Student>();
        BindingSource _bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_bs.DataSource = _students;
            //listBox1.DataSource = _bs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAdd = new Form()
            {
                Width = 250,
                Height = 260,
            };
            Label labName = new Label()
            {
                Text = "Name"
            };
            Label labAge = new Label()
            {
                Text = "Age",
                Top = 50
            };
            Label labBirthDate = new Label()
            {
                Text = "BirthDate",
                Top = 100
            };
            TextBox tbName = new TextBox()
            {
                Name = "tbName",
                Left = 80
            };
            TextBox tbAge = new TextBox()
            {
                Name = "tbAge",
                Top = 50,
                Left = 80
            };
            TextBox tbBirthDate = new TextBox()
            {
                Name = "tbBirthDate",
                Top = 100,
                Left = 80
            };
            Button btnAddStudent = new Button()
            {
                Name = "btnAddStudent",
                Top = 150,
                Text = "Add",
            };
            btnAddStudent.Click += (object senderAlt, EventArgs eAlt) =>
            {
                _students.Add(new Student(tbName.Text, Convert.ToInt32(tbAge.Text), Convert.ToDateTime(tbBirthDate.Text)));
                listBox1.Items.Add(new Student(tbName.Text, Convert.ToInt32(tbAge.Text), Convert.ToDateTime(tbBirthDate.Text)));
                frmAdd.Close();
            };
            frmAdd.Controls.Add(tbName);
            frmAdd.Controls.Add(tbAge);
            frmAdd.Controls.Add(tbBirthDate);
            frmAdd.Controls.Add(labName);
            frmAdd.Controls.Add(labAge);
            frmAdd.Controls.Add(labBirthDate);
            frmAdd.Controls.Add(btnAddStudent);
            frmAdd.ShowDialog();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_students.Pick().ToString());
        }
    }
}
