namespace WindowsFormsApplication1
{
  partial class AddOrEditCarForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxInfo = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownEngine = new System.Windows.Forms.NumericUpDown();
			this.labelEngine = new System.Windows.Forms.Label();
			this.textBoxBrand = new System.Windows.Forms.TextBox();
			this.LabelBrand = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEngine)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonOK.Location = new System.Drawing.Point(262, 367);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(222, 13);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Model";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Rok produkcji";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBoxInfo
			// 
			this.textBoxInfo.Location = new System.Drawing.Point(7, 220);
			this.textBoxInfo.Multiline = true;
			this.textBoxInfo.Name = "textBoxInfo";
			this.textBoxInfo.Size = new System.Drawing.Size(315, 96);
			this.textBoxInfo.TabIndex = 7;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(163, 367);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Anuluj";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(202, 47);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
			this.numericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownYear.TabIndex = 10;
			this.numericUpDownYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			// 
			// numericUpDownEngine
			// 
			this.numericUpDownEngine.DecimalPlaces = 1;
			this.numericUpDownEngine.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownEngine.Location = new System.Drawing.Point(202, 78);
			this.numericUpDownEngine.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownEngine.Name = "numericUpDownEngine";
			this.numericUpDownEngine.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownEngine.TabIndex = 11;
			// 
			// labelEngine
			// 
			this.labelEngine.AutoSize = true;
			this.labelEngine.Location = new System.Drawing.Point(4, 85);
			this.labelEngine.Name = "labelEngine";
			this.labelEngine.Size = new System.Drawing.Size(91, 13);
			this.labelEngine.TabIndex = 12;
			this.labelEngine.Text = "Pojemność silnika";
			// 
			// textBoxBrand
			// 
			this.textBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.textBoxBrand.Location = new System.Drawing.Point(222, 111);
			this.textBoxBrand.Name = "textBoxBrand";
			this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
			this.textBoxBrand.TabIndex = 13;
			// 
			// LabelBrand
			// 
			this.LabelBrand.AutoSize = true;
			this.LabelBrand.Location = new System.Drawing.Point(4, 111);
			this.LabelBrand.Name = "LabelBrand";
			this.LabelBrand.Size = new System.Drawing.Size(37, 13);
			this.LabelBrand.TabIndex = 14;
			this.LabelBrand.Text = "Marka";
			this.LabelBrand.Click += new System.EventHandler(this.LabelBrand_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(186, 147);
			this.dateTimePicker1.MinDate = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
			this.dateTimePicker1.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Data ostatniego przeglądu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Uwagi:";
			// 
			// AddOrEditCarForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(349, 439);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.LabelBrand);
			this.Controls.Add(this.textBoxBrand);
			this.Controls.Add(this.labelEngine);
			this.Controls.Add(this.numericUpDownEngine);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxInfo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.buttonOK);
			this.Name = "AddOrEditCarForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.AddOrEditCarForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEngine)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxInfo;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.NumericUpDown numericUpDownYear;
    private System.Windows.Forms.NumericUpDown numericUpDownEngine;
    private System.Windows.Forms.Label labelEngine;
    private System.Windows.Forms.TextBox textBoxBrand;
    private System.Windows.Forms.Label LabelBrand;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

