using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void submitBtn_Click(object sender, EventArgs e)
    {
      School testSchool = new School();
      testSchool.Name = fieldName.Text;
      testSchool.Address = fieldAddress.Text;
      testSchool.City = fieldCity.Text;
      testSchool.State = fieldState.Text;
      testSchool.Zip = fieldZip.Text;
      testSchool.PhoneNumber = fieldPhone.Text;

      try {
        testSchool.TwitterAddress = fieldTwitter.Text;

        MessageBox.Show(testSchool.ToString(), "School successfuly registered");
      }
      catch (Exception error) {
        MessageBox.Show(error.Message, "Validation Failed!");
      }

    }

    private void resetBtn_Click(object sender, EventArgs e)
    {
      fieldName.Text = "";
      fieldAddress.Text = "";
      fieldCity.Text = "";
      fieldState.Text = "";
      fieldZip.Text = "";
      fieldPhone.Text = "";
      fieldTwitter.Text = "";
    }

    private void btnTestTeacher_Click(object sender, EventArgs e)
    {
      Teacher teacher = new Teacher();
      float gp = teacher.ComputeGradeAverage();

      string gradeAverage = string.Format("The grade average is {0}", gp);

      MessageBox.Show(gradeAverage, "Teacher Grade");
    }

    private void btnTestStudent_Click(object sender, EventArgs e)
    {
      Student student = new Student();
      float gp = student.ComputeGradeAverage();

      string gradeAverage = string.Format("The grade average is {0}", gp);

      MessageBox.Show(gradeAverage, "Student Grade");
    }
  }
}
