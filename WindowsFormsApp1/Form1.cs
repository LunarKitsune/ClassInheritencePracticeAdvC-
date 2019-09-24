using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Person;
using Student;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetAcademicPerform_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDInput.Text);
            string Name = txtNameInput.Text;
            int Age = int.Parse(txtAgeInput.Text);
            double Credits = double.Parse(txtCreditInput.Text);
            double Points = double.Parse(txtPointInput.Text);

            student someStudent = new student(Name, Age, ID, Credits, Points);

            rtbAcademicOutput.Text = someStudent.ToString();
        }
    }
}
