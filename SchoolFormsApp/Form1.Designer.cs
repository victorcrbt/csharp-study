namespace SchoolFormsApp
{
  partial class Form1
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelName = new System.Windows.Forms.Label();
      this.labelAddress = new System.Windows.Forms.Label();
      this.labelCity = new System.Windows.Forms.Label();
      this.labelState = new System.Windows.Forms.Label();
      this.labelZip = new System.Windows.Forms.Label();
      this.labelPhone = new System.Windows.Forms.Label();
      this.labelTwitter = new System.Windows.Forms.Label();
      this.fieldTwitter = new System.Windows.Forms.TextBox();
      this.fieldPhone = new System.Windows.Forms.TextBox();
      this.fieldZip = new System.Windows.Forms.TextBox();
      this.fieldState = new System.Windows.Forms.TextBox();
      this.fieldCity = new System.Windows.Forms.TextBox();
      this.fieldAddress = new System.Windows.Forms.TextBox();
      this.fieldName = new System.Windows.Forms.TextBox();
      this.submitBtn = new System.Windows.Forms.Button();
      this.resetBtn = new System.Windows.Forms.Button();
      this.btnTestTeacher = new System.Windows.Forms.Button();
      this.btnTestStudent = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(18, 24);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(71, 13);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "School Name";
      // 
      // labelAddress
      // 
      this.labelAddress.AutoSize = true;
      this.labelAddress.Location = new System.Drawing.Point(18, 57);
      this.labelAddress.Name = "labelAddress";
      this.labelAddress.Size = new System.Drawing.Size(45, 13);
      this.labelAddress.TabIndex = 1;
      this.labelAddress.Text = "Address";
      // 
      // labelCity
      // 
      this.labelCity.AutoSize = true;
      this.labelCity.Location = new System.Drawing.Point(18, 94);
      this.labelCity.Name = "labelCity";
      this.labelCity.Size = new System.Drawing.Size(24, 13);
      this.labelCity.TabIndex = 2;
      this.labelCity.Text = "City";
      // 
      // labelState
      // 
      this.labelState.AutoSize = true;
      this.labelState.Location = new System.Drawing.Point(18, 129);
      this.labelState.Name = "labelState";
      this.labelState.Size = new System.Drawing.Size(32, 13);
      this.labelState.TabIndex = 3;
      this.labelState.Text = "State";
      // 
      // labelZip
      // 
      this.labelZip.AutoSize = true;
      this.labelZip.Location = new System.Drawing.Point(18, 162);
      this.labelZip.Name = "labelZip";
      this.labelZip.Size = new System.Drawing.Size(22, 13);
      this.labelZip.TabIndex = 4;
      this.labelZip.Text = "Zip";
      // 
      // labelPhone
      // 
      this.labelPhone.AutoSize = true;
      this.labelPhone.Location = new System.Drawing.Point(18, 195);
      this.labelPhone.Name = "labelPhone";
      this.labelPhone.Size = new System.Drawing.Size(78, 13);
      this.labelPhone.TabIndex = 5;
      this.labelPhone.Text = "Phone Number";
      // 
      // labelTwitter
      // 
      this.labelTwitter.AutoSize = true;
      this.labelTwitter.Location = new System.Drawing.Point(18, 229);
      this.labelTwitter.Name = "labelTwitter";
      this.labelTwitter.Size = new System.Drawing.Size(39, 13);
      this.labelTwitter.TabIndex = 6;
      this.labelTwitter.Text = "Twitter";
      // 
      // fieldTwitter
      // 
      this.fieldTwitter.Location = new System.Drawing.Point(112, 226);
      this.fieldTwitter.Name = "fieldTwitter";
      this.fieldTwitter.Size = new System.Drawing.Size(100, 20);
      this.fieldTwitter.TabIndex = 13;
      // 
      // fieldPhone
      // 
      this.fieldPhone.Location = new System.Drawing.Point(112, 192);
      this.fieldPhone.Name = "fieldPhone";
      this.fieldPhone.Size = new System.Drawing.Size(100, 20);
      this.fieldPhone.TabIndex = 12;
      // 
      // fieldZip
      // 
      this.fieldZip.Location = new System.Drawing.Point(112, 159);
      this.fieldZip.Name = "fieldZip";
      this.fieldZip.Size = new System.Drawing.Size(100, 20);
      this.fieldZip.TabIndex = 11;
      // 
      // fieldState
      // 
      this.fieldState.Location = new System.Drawing.Point(112, 126);
      this.fieldState.Name = "fieldState";
      this.fieldState.Size = new System.Drawing.Size(100, 20);
      this.fieldState.TabIndex = 10;
      // 
      // fieldCity
      // 
      this.fieldCity.Location = new System.Drawing.Point(112, 91);
      this.fieldCity.Name = "fieldCity";
      this.fieldCity.Size = new System.Drawing.Size(100, 20);
      this.fieldCity.TabIndex = 9;
      // 
      // fieldAddress
      // 
      this.fieldAddress.Location = new System.Drawing.Point(112, 54);
      this.fieldAddress.Name = "fieldAddress";
      this.fieldAddress.Size = new System.Drawing.Size(100, 20);
      this.fieldAddress.TabIndex = 8;
      // 
      // fieldName
      // 
      this.fieldName.Location = new System.Drawing.Point(112, 20);
      this.fieldName.Name = "fieldName";
      this.fieldName.Size = new System.Drawing.Size(100, 20);
      this.fieldName.TabIndex = 7;
      // 
      // submitBtn
      // 
      this.submitBtn.Location = new System.Drawing.Point(52, 268);
      this.submitBtn.Name = "submitBtn";
      this.submitBtn.Size = new System.Drawing.Size(121, 23);
      this.submitBtn.TabIndex = 14;
      this.submitBtn.Text = "Submit";
      this.submitBtn.UseVisualStyleBackColor = true;
      this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
      // 
      // resetBtn
      // 
      this.resetBtn.Location = new System.Drawing.Point(52, 297);
      this.resetBtn.Name = "resetBtn";
      this.resetBtn.Size = new System.Drawing.Size(121, 23);
      this.resetBtn.TabIndex = 15;
      this.resetBtn.Text = "Reset Form";
      this.resetBtn.UseVisualStyleBackColor = true;
      this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
      // 
      // btnTestTeacher
      // 
      this.btnTestTeacher.Location = new System.Drawing.Point(52, 349);
      this.btnTestTeacher.Name = "btnTestTeacher";
      this.btnTestTeacher.Size = new System.Drawing.Size(121, 23);
      this.btnTestTeacher.TabIndex = 16;
      this.btnTestTeacher.Text = "Test Teacher";
      this.btnTestTeacher.UseVisualStyleBackColor = true;
      this.btnTestTeacher.Click += new System.EventHandler(this.btnTestTeacher_Click);
      // 
      // btnTestStudent
      // 
      this.btnTestStudent.Location = new System.Drawing.Point(52, 378);
      this.btnTestStudent.Name = "btnTestStudent";
      this.btnTestStudent.Size = new System.Drawing.Size(121, 23);
      this.btnTestStudent.TabIndex = 16;
      this.btnTestStudent.Text = "Test Student";
      this.btnTestStudent.UseVisualStyleBackColor = true;
      this.btnTestStudent.Click += new System.EventHandler(this.btnTestStudent_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(234, 508);
      this.Controls.Add(this.btnTestStudent);
      this.Controls.Add(this.btnTestTeacher);
      this.Controls.Add(this.resetBtn);
      this.Controls.Add(this.submitBtn);
      this.Controls.Add(this.fieldName);
      this.Controls.Add(this.fieldAddress);
      this.Controls.Add(this.fieldCity);
      this.Controls.Add(this.fieldState);
      this.Controls.Add(this.fieldZip);
      this.Controls.Add(this.fieldPhone);
      this.Controls.Add(this.fieldTwitter);
      this.Controls.Add(this.labelTwitter);
      this.Controls.Add(this.labelPhone);
      this.Controls.Add(this.labelZip);
      this.Controls.Add(this.labelState);
      this.Controls.Add(this.labelCity);
      this.Controls.Add(this.labelAddress);
      this.Controls.Add(this.labelName);
      this.Name = "Form1";
      this.Text = "School Form";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTwitter;
        private System.Windows.Forms.TextBox fieldTwitter;
        private System.Windows.Forms.TextBox fieldPhone;
        private System.Windows.Forms.TextBox fieldZip;
        private System.Windows.Forms.TextBox fieldState;
        private System.Windows.Forms.TextBox fieldCity;
        private System.Windows.Forms.TextBox fieldAddress;
        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button btnTestTeacher;
        private System.Windows.Forms.Button btnTestStudent;
    }
}

