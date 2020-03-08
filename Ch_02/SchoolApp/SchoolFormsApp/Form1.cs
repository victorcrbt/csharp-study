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

    private void button1_Click(object sender, EventArgs e)
    {
      fieldName.Text = "";
      fieldAddress.Text = "";
      fieldCity.Text = "";
      fieldState.Text = "";
      fieldZip.Text = "";
      fieldPhone.Text = "";
      fieldTwitter.Text = "";
    }
  }
}
