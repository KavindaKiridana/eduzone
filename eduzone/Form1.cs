using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eduzone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_addcourse_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            this.Hide();
            courseForm.Show();
        }

        private void btn_btnaddstd_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void btn_managestd_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            this.Hide();
            manageStudent.Show();
        }

        private void btn_managecourse_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourseForm = new ManageCourseForm();
            this.Hide();
            manageCourseForm.Show();
        }

        private void btn_addteacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            this.Hide();
            teacherForm.Show();
        }

        private void btn_manageteacher_Click(object sender, EventArgs e)
        {
            ManageTeacher manageTeacher = new ManageTeacher();
            this.Hide();
            manageTeacher.Show();
        }
    }
}
